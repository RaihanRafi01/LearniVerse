using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StGuRepo : Repo, IRepo<StGu, int, StGu>
    {
        public bool Delete(int id)
        {
            var data = Get(id);
            db.stGus.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<StGu> Get()
        {
            return db.stGus.ToList();
        }

        public StGu Get(int id)
        {
            return db.stGus.Find(id);
        }

        public StGu Insert(StGu obj)
        {
            db.stGus.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public StGu Update(StGu obj)
        {
            var exdata = db.stGus.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
