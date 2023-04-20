using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeacherRepo : Repo, IRepo<Teacher, int, Teacher>
    {
        public bool Delete(int id)
        {
            var pro = Get(id);
            db.teachers.Remove(pro);
            return db.SaveChanges() > 0;
        }

        public List<Teacher> Get()
        {
            return db.teachers.ToList();
        }

        public Teacher Get(int id)
        {
            return db.teachers.Find(id);
        }

        public Teacher Insert(Teacher obj)
        {
            db.teachers.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Teacher Update(Teacher obj)
        {
            var expro = db.teachers.Find(obj.Id);
            db.Entry(expro).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
