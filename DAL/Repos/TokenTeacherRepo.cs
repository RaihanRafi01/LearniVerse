using DAL.Interfaces;
using DAL.Migrations;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenTeacherRepo : Repo, IRepo<TokenTeacher, string, TokenTeacher>
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<TokenTeacher> Get()
        {
            throw new NotImplementedException();
        }

        public TokenTeacher Get(string id)
        {
            //throw new NotImplementedException();
            return db.tokenTeachers.FirstOrDefault(t => t.TKey.Equals(id));
        }

        public TokenTeacher Insert(TokenTeacher obj)
        {
            db.tokenTeachers.Add(obj);
            if(db.SaveChanges()> 0 ) return obj;
            return null;
        }

        public TokenTeacher Update(TokenTeacher obj)
        {
            var token = Get(obj.TKey);
            db.Entry(token).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0 ) return token;
            return null;
        }
    }
}
