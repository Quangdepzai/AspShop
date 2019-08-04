﻿using Models.Dao;
using Shop.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShop.Common;
using System.Web.Mvc;

namespace Shop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)// kiểm tra form rỗng
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = dao.GetById(model.UserName);
                    var useSession = new UserLogin();
                    useSession.UserName = user.UserName;
                    useSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION, useSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                    if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else
                    if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khóa");
                }
                else
                    if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập không thành công");
            }
            return View("Index");
        }
    }
}