using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    public class VoucherBLL : ICrudBLL<Voucher>
    {
        public bool Create(params Voucher[] vouchers)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Vouchers.AddRange(vouchers);
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

        public Voucher Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Vouchers.Find(id);
            }
        }

        public List<Voucher> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Vouchers.AsNoTracking().ToList();
            }
        }

        public bool Update(Voucher voucher)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    if(Db.Vouchers.Find(voucher.VoucherId).Payments.Any())
                    {
                        return false;
                    }
                    Db.Entry(voucher).State = EntityState.Modified;
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
        public List<Voucher> GetNow()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Vouchers.AsNoTracking().Where(p => p.Quantity > p.Payments.Count).ToList();
            }
        }
        public List<Voucher> GetOld()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Vouchers.AsNoTracking().Where(p => p.Quantity == p.Payments.Count).ToList();
            }
        }
        public Voucher GetByCode(string code)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Vouchers.AsNoTracking().FirstOrDefault(p => p.Code == code && p.Quantity > p.Payments.Count);
            }
        }
        public List<Payment> GetPayments(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Vouchers.Find(id).Payments.ToList();
            }
        }
    }
}
