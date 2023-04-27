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
        public static List<StGuDTO> Get()
        {
            var data = DataAccessFactory.StGuData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StGu, StGuDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<StGuDTO>>(data);
            return mapped;
        }

        public static StGuDTO Get(int id)
        {
            var data = DataAccessFactory.StGuData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StGu, StGuDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<StGuDTO>(data);
            return mapped;
        }

        public static bool Create(StGuDTO StGu)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StGuDTO, StGu>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<StGu>(StGu);
            var res = DataAccessFactory.StGuData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(StGuDTO StGu)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<StGuDTO, StGu>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<StGu>(StGu);
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
