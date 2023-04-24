using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, IRepo<Admin, int, Admin>
    {
        public bool Delete(int id)
        {
            var data = Get(id);
            db.admins.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Admin> Get()
        {
            return db.admins.ToList();
        }

        public Admin Get(int id)
        {
            return db.admins.Find(id);
        }

        public Admin Insert(Admin obj)
        {
            db.admins.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Admin Update(Admin obj)
        {
            var exdata = db.admins.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
