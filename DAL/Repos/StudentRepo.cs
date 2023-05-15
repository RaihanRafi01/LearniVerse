using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class StudentRepo : Repo, IRepo<Student, int, Student> , IAuthStudent<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data = db.students.FirstOrDefault(x => x.Name.Equals(username) && x.Password.Equals(password));
            if (data != null) return true;
            return false;
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.students.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Student> Get()
        {
            return db.students.ToList();
        }

        public Student Get(int id)
        {
            return db.students.Find(id);
        }

        public Student Insert(Student obj)
        {
            db.students.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Student Update(Student obj)
        {
            var exdata = db.students.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
