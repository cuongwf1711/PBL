using PBL.DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using static PBL.DTO.HMSDB;

namespace PBL.BLL
{
    public class AdditionBLL : ICrudBLL<Addition>
    {
        public bool Create(params Addition[] additions)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Additions.AddRange(additions);
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

        public Addition Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Additions.Find(id); 
            }
        }

        public List<Addition> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Additions.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Addition addition)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(addition).State = EntityState.Modified;
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
