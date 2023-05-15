using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class QuizResultRepo : Repo, IRepo<QuizResult, int, QuizResult>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var data = Get(id);
            db.QuizResults.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<QuizResult> Get()
        {
            return db.QuizResults.ToList();
        }

        public QuizResult Get(int id)
        {
            return db.QuizResults.Find(id);
        }

        public QuizResult Insert(QuizResult obj)
        {
            db.QuizResults.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public QuizResult Update(QuizResult obj)
        {
            var exdata = db.QuizResults.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
