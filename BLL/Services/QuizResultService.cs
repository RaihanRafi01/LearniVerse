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
    public class QuizResultService
    {
      
            public static List<QuizResultDTO> Get()
            {
                var data = DataAccessFactory.QuizResultData().Get();
                var config = new MapperConfiguration(c =>
                {
                    c.CreateMap<QuizResult, QuizResultDTO>();
                });
                var mapper = new Mapper(config);
                var mapped = mapper.Map<List<QuizResultDTO>>(data);
                return mapped;
            }

            public static QuizResultDTO Get(int id)
            {
                var data = DataAccessFactory.QuizResultData().Get(id);
                var config = new MapperConfiguration(c =>
                {
                    c.CreateMap<QuizResult, QuizResultDTO>();
                });
                var mapper = new Mapper(config);
                var mapped = mapper.Map<QuizResultDTO>(data);
                return mapped;
            }

            public static bool Create(QuizResultDTO QuizResult)
            {
                var config = new MapperConfiguration(c =>
                {
                    c.CreateMap<QuizResultDTO, QuizResult>();
                });
                var mapper = new Mapper(config);
                var mapped = mapper.Map<QuizResult>(QuizResult);
                var res = DataAccessFactory.QuizResultData().Insert(mapped);
                if (res != null) return true;
                return false;
            }

            public static bool Update(QuizResultDTO QuizResult)
            {
                var config = new MapperConfiguration(c =>
                {
                    c.CreateMap<QuizResultDTO, QuizResult>();
                });
                var mapper = new Mapper(config);
                var mapped = mapper.Map<QuizResult>(QuizResult);
                var res = DataAccessFactory.QuizResultData().Update(mapped);
                if (res != null) return true;
                return false;
            }
            public static bool Delete(int id)
            {
                return DataAccessFactory.QuizResultData().Delete(id);
            }
        }
    }
