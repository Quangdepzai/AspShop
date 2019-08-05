using Models.Dao;
using Models.EF;
using OnlineShop.Common;
using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;

namespace Shop.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(string searchString,int page = 1,int pageSize =2)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(searchString,page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
            var user = new UserDao().ViewDetail(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            var dao = new UserDao();
            var Pass = Encryptor.MD5Hash(user.Password);
            // user.Password = Pass;
            user.PasswordLevel2 = Pass;
            long id = dao.Insert(user);
            if (ModelState.IsValid)
            {
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm User thành công");
                }
            }
            else
            {

            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult Edit(User user)
        {
            var dao = new UserDao();
            var Pass = Encryptor.MD5Hash(user.Password);
            // user.Password = Pass;
            user.PasswordLevel2 = Pass;
            bool result = dao.Update(user);
            if (ModelState.IsValid)
            {
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm User thành công");
                }
            }
            else
            {

            }
            return View("Index");
         }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new UserDao().Delete(id);

            return RedirectToAction("Index");
        }
    }
}