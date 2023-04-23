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
    public class GuardianService
    {
        public static List<GuardianDTO> Get()
        {
            var data = DataAccessFactory.GuardianData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Guardian, GuardianDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<GuardianDTO>>(data);
            return mapped;
        }

        public static GuardianDTO Get(int id)
        {
            var data = DataAccessFactory.GuardianData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Guardian, GuardianDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<GuardianDTO>(data);
            return mapped;
        }

        public static bool Create(GuardianDTO Guardian)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<GuardianDTO, Guardian>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Guardian>(Guardian);
            var res = DataAccessFactory.GuardianData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(GuardianDTO Guardian)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<GuardianDTO, Guardian>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Guardian>(Guardian);
            var res = DataAccessFactory.GuardianData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GuardianData().Delete(id);
        }

    }
}
