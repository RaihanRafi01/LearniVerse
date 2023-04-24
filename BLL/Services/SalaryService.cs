using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class SalaryService
    {
        public static List<SalaryDTO> Get()
        {
            var data = DataAccessFactory.SalaryData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<SalaryDTO>>(data);
            return mapped;
        }

        public static SalaryDTO Get(int id)
        {
            var data = DataAccessFactory.SalaryData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<SalaryDTO>(data);
            return mapped;
        }

        public static bool Create(SalaryDTO salary)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryDTO, Salary>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Salary>(salary);
            var res = DataAccessFactory.SalaryData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(SalaryDTO Salary)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryDTO, Salary>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Salary>(Salary);
            var res = DataAccessFactory.SalaryData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.SalaryData().Delete(id);
        }
    }
}
