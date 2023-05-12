using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthGuardianService
    {
        public static TokenTeacherDTO Authenticate(string username, string password)
        {
            var res = DataAccessFactory.AuthGuardianData().Authenticate(username, password);
            if (res)
            {
                var token = new TokenTeacher();
                token.UserId = username;
                token.Createtime = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenDataTeacher().Insert(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c => {
                        c.CreateMap<TokenTeacher, TokenTeacherDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenTeacherDTO>(ret);
                }
            }
            return null;
        }
        public static bool IsTokenValid(string tkey)
        {
            var extoken = DataAccessFactory.TokenDataTeacher().Get(tkey);
            if (extoken != null && extoken.ExpireTime == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var extoken = DataAccessFactory.TokenDataTeacher().Get(tkey);
            extoken.ExpireTime = DateTime.Now;
            if (DataAccessFactory.TokenDataTeacher().Update(extoken) != null)
            {
                return true;
            }
            return false;

        }
    }
}
