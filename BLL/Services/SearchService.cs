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
    public class SearchService
    {
        public static List<SearchDTO> Get()
        {
            var data = DataAccessFactory.SearchData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Search, SearchDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<SearchDTO>>(data);
            return mapped;
        }

        public static SearchDTO Get(string id)
        {
            var data = DataAccessFactory.SearchData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Search, SearchDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<SearchDTO>(data);
            return mapped;
        }

        public static bool Create(SearchDTO search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SearchDTO, Search>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Search>(search);
            var res = DataAccessFactory.SearchData().Insert(mapped);
            if (res != null) return true;
            return false;
        }



    }
}