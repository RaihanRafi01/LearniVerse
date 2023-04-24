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
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<AdminDTO>>(data);
            return mapped;
        }

        public static AdminDTO Get(int id)
        {
            var data = DataAccessFactory.AdminData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<AdminDTO>(data);
            return mapped;
        }

        public static bool Create(AdminDTO Admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Admin>(Admin);
            var res = DataAccessFactory.AdminData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(AdminDTO Admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AdminDTO, Admin>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Admin>(Admin);
            var res = DataAccessFactory.AdminData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AdminData().Delete(id);
        }
    }
}
