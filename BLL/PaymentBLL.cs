using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using static PBL.DTO.HMSDB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace PBL.BLL
{
    public class PaymentBLL : ICrudBLL<Payment>
    {
        public bool Create(params Payment[] payments)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Payments.AddRange(payments);
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
                        Payment payment = Get(id);
                        if (payment.Status == true || payment.Deposit > 0)
                        {
                            return false;
                        }
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

        public Payment Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.Find(id); 
            }
        }

        public List<Payment> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Payment payment)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(payment).State = EntityState.Modified;
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
        public int GetCustomerId(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.Find(id).Reservations.FirstOrDefault().PersonId;
            }
        }
        public List<Payment> GetOld()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.AsNoTracking().Where(p => p.Status).ToList(); 
            }
        }

        public List<Payment> GetNow()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.AsNoTracking().Where(p => !p.Status).ToList(); 
            }
        }
        public List<Payment> GetByDateCreate(DateTime start, DateTime end)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.AsNoTracking().Where(p => DbFunctions.TruncateTime(p.DateCreate) >= start.Date && DbFunctions.TruncateTime(p.DateCreate) <= end.Date).ToList(); 
            }
        }
        public List<Payment> GetByDateCheckout(DateTime start, DateTime end)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.AsNoTracking().Where(p => DbFunctions.TruncateTime(p.DateCheckout) >= start.Date && DbFunctions.TruncateTime(p.DateCheckout) <= end.Date).ToList();
            }
        }
        public decimal GetPriceReservations(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.Find(id).Reservations.Sum(p => p.Price); 
            }
        }
        public decimal CalculatePriceNeedPayWhenAddFeeLate(int id, decimal feeLate)
        {
            return GetPriceRemain(id) + GetPriceReservations(id) * feeLate;
        }

        public decimal CalculatePriceWhenChangeDeposit(int id, decimal deposit)
        {
            return GetPriceApplyVoucher(id) * deposit;
        }

        public decimal GetPriceServices(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.Find(id).Additions.Sum(p => p.Price); 
            }
        }

        public decimal GetPriceApplyVoucher(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return (GetPriceReservations(id) + GetPriceServices(id)) * (1 - (Db.Payments.Find(id).Voucher?.Discount ?? 0)); 
            }
        }
        public decimal GetPriceDeposit(int id)
        {
            return GetPriceApplyVoucher(id) * Get(id).Deposit; 
        }
        public decimal GetPriceTotal(int id)
        {
            return GetPriceApplyVoucher(id) + GetPriceReservations(id) * Get(id).FeeLate; 
        }
        public decimal GetPriceTotalOfPayments(params int[] ids)
        {
            decimal price = 0;
            foreach (int id in ids)
            {
                price += GetPriceTotal(id);
            }
            return price;
        }
        public decimal GetPriceRemain(int id)
        {
            return GetPriceApplyVoucher(id) - GetPriceDeposit(id);
        }
        public List<Reservation> GetReservations(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.Find(id).Reservations.ToList();
            }
        }
        public List<Addition> GetAddtions(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.Find(id).Additions.ToList();
            }
        }
        public Voucher GetVoucher(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Payments.Find(id).Voucher;
            }
        }
        public bool Checkout(int id, decimal feeLate)
        {
            try
            {
                Payment payment = Get(id);
                payment.Status = true;
                payment.DateCheckout = DateTime.Now;
                payment.FeeLate = feeLate;
                Update(payment);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool BookRoomCompleted(Payment payment, List<Reservation> reservations, List<Addition> additions)
        {
            using (HMSDB Db = new HMSDB())
            {
                using (DbContextTransaction transaction = Db.Database.BeginTransaction())
                {
                    try
                    {
                        Db.Payments.Add(payment);
                        Db.SaveChanges();

                        if (reservations != null)
                        {
                            for (int i = 0; i < reservations.Count; i++)
                            {
                                reservations[i].PaymentId = payment.PaymentId;
                            }
                            Db.Reservations.AddRange(reservations);
                        }
                        if (additions != null)
                        {
                            for (int i = 0; i < additions.Count; i++)
                            {
                                additions[i].PaymentId = payment.PaymentId;
                            }
                            Db.Additions.AddRange(additions);
                        }
                        Db.SaveChanges();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}
