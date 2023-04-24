using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class PaymentService
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAccessFactory.PaymentData().Get();
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<List<PaymentDTO>>(data);
            return mapped;
        }

        public static PaymentDTO Get(int id)
        {
            var data = DataAccessFactory.PaymentData().Get(id);
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<PaymentDTO>(data);
            return mapped;
        }

        public static bool Create(PaymentDTO payment)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentDTO, Payment>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Payment>(payment);
            var res = DataAccessFactory.PaymentData().Insert(mapped);
            if (res != null) return true;
            return false;
        }

        public static bool Update(PaymentDTO payment)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentDTO, Payment>();
            });
            var mapper = new Mapper(config);
            var mapped = mapper.Map<Payment>(payment);
            var res = DataAccessFactory.PaymentData().Update(mapped);
            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.PaymentData().Delete(id);
        }
    }
}
