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
    public class ResultService
    {
        public static List<ResultDTO> Get()
        {
            var data = DataAccessFactory.ResultData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Result, ResultDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<ResultDTO>>(data);
            return mapped;
        }

        public static ResultDTO Get(int id)
        {
            var data = DataAccessFactory.ResultData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Result, ResultDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<ResultDTO>(data);
            return mapped;
        }

        public static bool Create(ResultDTO Result)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ResultDTO, Result>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Result>(Result);
            var res = DataAccessFactory.ResultData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(ResultDTO Result)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ResultDTO, Result>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Result>(Result);
            var res = DataAccessFactory.ResultData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.ResultData().Delete(id);
        }
    }
}
