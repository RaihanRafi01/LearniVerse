using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class SalaryRepo : Repo, IRepo<Salary, int, Salary>
    {
        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.salarys.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Salary> Get()
        {
            return db.salarys.ToList();
        }

        public Salary Get(int id)
        {
            return db.salarys.Find(id);
        }

        public Salary Insert(Salary obj)
        {
            db.salarys.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Salary Update(Salary obj)
        {
            var exdata = db.salarys.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
