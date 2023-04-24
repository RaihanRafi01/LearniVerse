using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Migrations;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthTeacherService
    {
        public static TokenTeacherDTO Authenticate(string username, string password) 
        {
            var res = DataAccessFactory.AuthTeacherData().Authenticate(username, password);
            if (res) 
            {
                var token = new TokenTeacher();
                token.UserName = username;
                token.Createtime = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenDataTeacher().Insert(token);
                if(ret != null) 
                {
                    var cfg = new MapperConfiguration(c => {
                        c.CreateMap<TokenTeacher,TokenTeacherDTO> ();
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenTeacherDTO>(ret);
                }
            }
            return null;
        }
    }
}
