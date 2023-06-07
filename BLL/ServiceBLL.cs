using PBL.DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;

namespace PBL.BLL
{
    public class ServiceBLL
    {
        public bool Create(params Service[] services)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Services.AddRange(services);
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

        public Service Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Services.Find(id); 
            }
        }

        public List<Service> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Services.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Service service)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(service).State = EntityState.Modified;
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
        public List<Addition> GetAdditions(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Services.Find(id).Additions.ToList();
            }
        }
    }
}
