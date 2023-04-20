using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course, int, Course>
    {
        public bool Delete(int id)
        {
            var data = Get(id);
            db.courses.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Course> Get()
        {
            return db.courses.ToList();
        }

        public Course Get(int id)
        {
            return db.courses.Find(id);
        }

        public Course Insert(Course obj)
        {
            db.courses.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Course Update(Course obj)
        {
            var exdata = db.courses.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
