using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PagedList;
using System.Threading.Tasks;

namespace Models.Dao
{
  public  class UserDao
    {
        OnlineShopDBContext db = null;
        public UserDao()
        {
            db = new OnlineShopDBContext();
        }
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public IEnumerable<User> ListAllPaging(int page,int pageSize)
        {
            return db.Users.OrderByDescending(x=>x.CreatedDate).ToPagedList(page,pageSize);
        }
        public bool Update(User entity)
        {
            try
            {
                var user = db.Users.Find(entity.ID);
                user.Address = entity.Address;
                user.Email = entity.Email;
                user.Mobile = entity.Mobile;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public User ViewDetail(int id)
        {
            return db.Users.Find(id);
        }
        public int Login(string userName, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (result.IsLocked == false)
                {
                    return -1;
                }
                else
                {
                    if (result.PasswordLevel2 == password)
                        return 1;
                    else
                        return -2;
                }
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
