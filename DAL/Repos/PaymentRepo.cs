using DAL.Interfaces;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class PaymentRepo : Repo, IRepo<Payment, int, Payment>
    {
        public bool Delete(int id)
        {
            var data = Get(id);
            db.payments.Remove(data);
            return db.SaveChanges() > 0;
        }

        public List<Payment> Get()
        {
            return db.payments.ToList();
        }

        public Payment Get(int id)
        {
            return db.payments.Find(id);
        }

        public Payment Insert(Payment obj)
        {
            db.payments.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public Payment Update(Payment obj)
        {
            var exdata = db.payments.Find(obj.Id);
            db.Entry(exdata).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
