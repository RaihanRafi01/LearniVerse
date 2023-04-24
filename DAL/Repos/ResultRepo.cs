using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ResultRepo : Repo, IRepo<Result, int, Result>
    {
        public bool Delete(int id)
        {
              var data = Get(id);
            db.results.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Result> Get()
        {
            return db.results.ToList();
        }

        public Result Get(int id)
        {
            return db.results.Find(id);
        }

        public Result Insert(Result obj)
        {
            db.results.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Result Update(Result obj)
        {
            var exdata = db.results.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
