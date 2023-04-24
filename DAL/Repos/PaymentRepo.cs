using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace DAL.Repos
{
    internal class PaymentRepo : Repo, IRepo<Payment, int, Payment>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> Get()
        {
            throw new NotImplementedException();
        }

        public Payment Get(int id)
        {
            throw new NotImplementedException();
        }

        public Payment Insert(Payment obj)
        {
            throw new NotImplementedException();
        }

        public Payment Update(Payment obj)
        {
            throw new NotImplementedException();
        }
    }
}
