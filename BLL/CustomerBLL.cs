using PBL.DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace PBL.BLL
{
    public class CustomerBLL : ICrudBLL<Customer>
    {
        public bool Create(params Customer[] customers)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Customers.AddRange(customers);
                    Db.SaveChanges();
                    return true; 
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(params int[] ids)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    foreach (int id in ids)
                    {
                        Db.Entry(Get(id)).State = EntityState.Deleted;
                    }
                    Db.SaveChanges();
                    return true; 
                }
            }
            catch
            {
                return false;
            }
        }

        public Customer Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Customers.Find(id); 
            }
        }

        public List<Customer> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Customers.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Customer customer)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(customer).State = EntityState.Modified;
                    Db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //
        public bool AddOrUpdate(Customer customer)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Customers.AddOrUpdate(customer);
                    Db.SaveChanges();
                    return true; 
                }
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> GetOld()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Customers.AsNoTracking().Where(p => p.Reservations.All(q => q.Payment.Status)).ToList(); 
            }
        }

        public List<Customer> GetNow()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Customers.AsNoTracking().Where(p => p.Reservations.Any(q => !q.Payment.Status)).ToList(); 
            }
        }

        public List<Payment> GetPayments(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Customers.Find(id).Reservations.Select(p => p.Payment).Distinct().ToList(); 
            }
        }
    }
}
