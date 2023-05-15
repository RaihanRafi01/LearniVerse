using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StGuTeRepo : Repo, IRepo<StudentGuardianTeacher, int, StudentGuardianTeacher>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.stGus.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<StudentGuardianTeacher> Get()
        {
            return db.stGus.ToList();
        }

        public StudentGuardianTeacher Get(int id)
        {
            return db.stGus.Find(id);
        }

        public StudentGuardianTeacher Insert(StudentGuardianTeacher obj)
        {
            db.stGus.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public StudentGuardianTeacher Update(StudentGuardianTeacher obj)
        {
            var exdata = db.stGus.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
