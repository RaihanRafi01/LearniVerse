using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class StudentService
    {
        public static List<StudentDTO> Get()
        {
            var data = DataAccessFactory.StudentData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<StudentDTO>>(data);
            return mapped;
        }

        public static StudentDTO Get(int id)
        {
            var data = DataAccessFactory.StudentData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<StudentDTO>(data);
            return mapped;
        }

        public static bool Create(StudentDTO student)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Student>(student);
            var res = DataAccessFactory.StudentData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(StudentDTO student)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Student>(student);
            var res = DataAccessFactory.StudentData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.StudentData().Delete(id);
        }
    }
}
