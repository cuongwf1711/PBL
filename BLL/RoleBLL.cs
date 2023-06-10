using PBL.DTO;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using static PBL.DTO.HMSDB;

namespace PBL.BLL
{
    public class RoleBLL : ICrudBLL<Role>
    {
        public bool Create(params Role[] roles)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Roles.AddRange(roles);
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

        public Role Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Roles.Find(id); 
            }
        }

        public List<Role> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Roles.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Role role)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(role).State = EntityState.Modified;
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
        public List<Account> GetAccounts(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Roles.Find(id).Accounts.ToList();
            }
        }
    }
}
