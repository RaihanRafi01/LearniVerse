using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GuardianRepo : Repo, IRepo<Guardian, int, Guardian>, IAuthGuardian<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.guardians.FirstOrDefault(x => x.Name.Equals(username) && x.Password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.guardians.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Guardian> Get()
        {
            return db.guardians.ToList();
        }

        public Guardian Get(int id)
        {
            return db.guardians.Find(id);
        }

        public Guardian Insert(Guardian obj)
        {
            db.guardians.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Guardian Update(Guardian obj)
        {
            var exdata = db.guardians.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
        int IRepo<Guardian, int, Guardian>.Count()
        {
            var data = db.guardians.Count();
            return data;
        }
    }
}
