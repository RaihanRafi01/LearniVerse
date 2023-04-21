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
    public class QuesService
    {
        public static List<QuesDTO> Get()
        {
            var data = DataAccessFactory.QuesData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Ques, QuesDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<QuesDTO>>(data);
            return mapped;
        }

        public static QuesDTO Get(int id)
        {
            var data = DataAccessFactory.QuesData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Ques, QuesDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<QuesDTO>(data);
            return mapped;
        }

        public static bool Create(QuesDTO ques)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<QuesDTO, Ques>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Ques>(ques);
            var res = DataAccessFactory.QuesData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(QuesDTO ques)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<QuesDTO, Ques>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Ques>(ques);
            var res = DataAccessFactory.QuesData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.QuesData().Delete(id);
        }
    }
}
