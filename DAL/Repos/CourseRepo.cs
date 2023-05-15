using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CourseRepo : Repo, IRepo<Course, string, Course>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(string course)
        {
            var data = Get(course);
            db.courses.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Course> Get()
        {
            return db.courses.ToList();
        }

        public Course Get(string course)
        {
            
            return db.courses.FirstOrDefault(c => c.Name == course);
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
