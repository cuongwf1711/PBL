using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    public class LateBLL : ICrudBLL<Late>
    {
        public bool Create(params Late[] lates)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Lates.AddRange(lates);
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

        public Late Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Lates.Find(id);
            }
        }

        public List<Late> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Lates.AsNoTracking().ToList();
            }
        }

        public bool Update(Late late)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(late).State = EntityState.Modified;
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
