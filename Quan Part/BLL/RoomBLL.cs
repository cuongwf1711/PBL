using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;

namespace PBL.BLL
{
    public class RoomBLL : ICrudBLL<Room>
    {
        public bool Create(params Room[] rooms)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Rooms.AddRange(rooms);
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

        public Room Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Rooms.Find(id); 
            }
        }

        public List<Room> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Rooms.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Room room)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(room).State = EntityState.Modified;
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
        public List<Room> GetRoomsAvailable(DateTime start, DateTime end, int quantity)
        {
            using (HMSDB Db = new HMSDB())
            {
                List<Room> rooms = Db.Rooms.AsNoTracking().Where(
                    p => !(p.Reservations.Any(q => (start >= q.DateStart && start < q.DateEnd)
                            || (end > q.DateStart && end <= q.DateEnd))) 
                    || p.Reservations.All(q => ((start >= q.DateStart && start < q.DateEnd)
                            || (end > q.DateStart && end <= q.DateEnd)) && q.Payment.Status)
                    ).ToList();
                if (quantity > rooms.Sum(r => r.Capacity))
                {
                    return new List<Room>();
                }
                else if (quantity > rooms.Max(r => r.Capacity))
                {
                    return rooms;
                }
                return rooms.Where(p => p.Capacity >= quantity).ToList(); 
            }
        }
        public List<Reservation> GetReservations(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Rooms.Find(id).Reservations.ToList();
            }
        }
    }
}
