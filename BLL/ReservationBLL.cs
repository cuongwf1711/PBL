using PBL.DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using static PBL.DTO.HMSDB;

namespace PBL.BLL
{
    public class ReservationBLL : ICrudBLL<Reservation>
    {
        public bool Create(params Reservation[] reservations)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Reservations.AddRange(reservations);
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

        public Reservation Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Reservations.Find(id); 
            }
        }

        public List<Reservation> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Reservations.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Reservation reservation)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(reservation).State = EntityState.Modified;
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
    }
}
