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
    public class TeacherService
    {
        public static List<TeacherDTO> Get()
        {
            var data = DataAccessFactory.TeacherData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<TeacherDTO>>(data);
            return mapped;
        }

        public static TeacherDTO Get(int id)
        {
            var data = DataAccessFactory.TeacherData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Teacher, TeacherDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<TeacherDTO>(data);
            return mapped;
        }

        public static bool Create(TeacherDTO teacher)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TeacherDTO, Teacher>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Teacher>(teacher);
            var res = DataAccessFactory.TeacherData().Insert(mapped);
            if (res != null) return true;
            return false;
        }
        
        public static bool Update(TeacherDTO teacher)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TeacherDTO, Teacher>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Teacher>(teacher);
            var res = DataAccessFactory.TeacherData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.TeacherData().Delete(id);
        }
        public static int Count()
        {
            return DataAccessFactory.TeacherData().Count();
        }
    }
}
