﻿using DAL.Interfaces;
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
            var courses = db.courses.ToList();
            foreach (var course in courses)
            {
                course.TeacherName = course.Teacher.Name;
                course.StudentName = course.Student.Name;
            }
            return courses;

        }

        public Course Get(string course)
        {
            var cou = (from s in db.courses
                              where s.Name.Contains(course)
                              select s).ToList();
            return cou.First();

            //return db.courses.FirstOrDefault(c => c.Name == course);
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
        int IRepo<Course, string, Course>.Count()
        {
            var data = db.courses.Count();
            return data;
        }
    }
}
