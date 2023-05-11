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
    public class StGuService
    {
        public static List<StGuTeDTO> Get()
        {
            var data = DataAccessFactory.StGuData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StudentGuardianTeacher, StGuTeDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<StGuTeDTO>>(data);
            return mapped;
        }

        public static StGuTeDTO Get(int id)
        {
            var data = DataAccessFactory.StGuData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StudentGuardianTeacher, StGuTeDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<StGuTeDTO>(data);
            return mapped;
        }

        public static bool Create(StGuTeDTO StGu)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StGuTeDTO, StudentGuardianTeacher>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<StudentGuardianTeacher>(StGu);
            var res = DataAccessFactory.StGuData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(StGuTeDTO StGu)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StGuTeDTO, StudentGuardianTeacher>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<StudentGuardianTeacher>(StGu);
            var res = DataAccessFactory.StGuData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.StGuData().Delete(id);
        }
    }
}
