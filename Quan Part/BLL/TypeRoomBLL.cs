using PBL.DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using static PBL.DTO.HMSDB;

namespace PBL.BLL
{
    public class TypeRoomBLL
    {
        public bool Create(params TypeRoom[] typeRooms)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.TypeRooms.AddRange(typeRooms);
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

        public TypeRoom Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.TypeRooms.Find(id); 
            }
        }

        public List<TypeRoom> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.TypeRooms.AsNoTracking().ToList(); 
            }
        }

        public bool Update(TypeRoom typeRooms)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(typeRooms).State = EntityState.Modified;
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
        public List<Room> GetRooms(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.TypeRooms.Find(id).Rooms.ToList();
            }
        }
    }
}
