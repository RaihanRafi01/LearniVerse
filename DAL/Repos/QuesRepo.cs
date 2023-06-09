﻿using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class QuesRepo : Repo, IRepo<Ques, int, Ques>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.ques.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Ques> Get()
        {
            var ques = db.ques.ToList();
            foreach (var que in ques)
            {
                que.TeacherName = que.Teacher.Name;
            }
            return ques;
        }

        public Ques Get(int id)
        {
            return db.ques.Find(id);
        }

        public Ques Insert(Ques obj)
        {
            db.ques.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Ques Update(Ques obj)
        {
            var exdata = db.ques.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
