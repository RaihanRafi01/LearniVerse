using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseService
    {
        public static List<CourseDTO> Get()
        {
            var data = DataAccessFactory.CourseData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<CourseDTO>>(data);
            return mapped;
        }

        public static CourseDTO Get(int id)
        {
            var data = DataAccessFactory.CourseData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<CourseDTO>(data);
            return mapped;
        }

        public static bool Create(CourseDTO course)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CourseDTO, Course>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Course>(course);
            var res = DataAccessFactory.CourseData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(CourseDTO course)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<CourseDTO, Course>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Course>(course);
            var res = DataAccessFactory.CourseData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.CourseData().Delete(id);
        }
    }
}
