using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SearchRepo : Repo, IRepo<Search, string, Search>
    {

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Search> Get()
        {
            return db.searches.ToList();
        }

       
        public Search Get(string id)
        {
            return db.searches.Find(id);
        }

        public Search Insert(Search obj)
        {
            var match = db.searches.Count(c => c.SearchName == obj.SearchName);
            if (match > 0) 
            {
                var upd = (from s in db.searches
                           where s.SearchName == obj.SearchName
                           select s).SingleOrDefault();
                obj.Count = upd.Count + 1;
                obj.Id = upd.Id;
                obj.SearchName = upd.SearchName;
                db.Entry(upd).CurrentValues.SetValues(obj);
                db.SaveChanges();
               
            }
            else if (match == 0)
            {
                db.searches.Add(obj);
                db.SaveChanges();
               
            }
            return obj;
        }

        public Search Update(Search obj)
        {
            // throw new NotImplementedException();
            var exdata = db.salarys.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
