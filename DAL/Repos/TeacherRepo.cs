using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TeacherRepo : Repo, IRepo<Teacher, int, Teacher> , IAuthTeacher<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.teachers.FirstOrDefault(x => x.Name.Equals(username) && x.Password.Equals(password));
            if (data != null ) return true;
            return false;
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.teachers.Remove(data);
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
            var exdata = db.teachers.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
      

        int IRepo<Teacher, int, Teacher>.Count()
        {
             var data = db.teachers.Count();
            return data;
        }
    }
}
