using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PBL.BLL
{
    public class AccountBLL
    {
        public bool Create(params Account[] accounts)
        {
            try
            {
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i].Password.Length >= 6)
                    {
                        accounts[i].Password = StaticFunc.ComputeSha256Hash(accounts[i].Password);
                    }
                    else
                    {
                        return false;
                    }
                }
                using (HMSDB Db = new HMSDB())
                {
                    Db.Accounts.AddRange(accounts);
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

        public Account Get(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Accounts.Find(id); 
            }
        }

        public List<Account> GetAll()
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Accounts.AsNoTracking().ToList(); 
            }
        }

        public bool Update(Account account)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    Db.Entry(account).State = EntityState.Modified;
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
        public string GetNameRole(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Accounts.Find(id).Role.Name;
            }
        }
        public List<Account> GetAllEmployeeExceptMe(int id)
        {
            return GetAll().Where(p => p.RoleId != 1 && p.PersonId != id).ToList();
        }
        public string GetPermission(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                int roleId = Get(id).RoleId;
                return Db.Roles.AsNoTracking().FirstOrDefault(p => p.RoleId == roleId).Permisssion;
            }
        }
        public Account Search(int id, int accountId)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Accounts.AsNoTracking().FirstOrDefault(p => p.RoleId != 1 && p.PersonId != accountId && p.PersonId == id);
            }
        }
        public Account GetByLogin(string email, string password)
        {
            using (HMSDB Db = new HMSDB())
            {
                password = StaticFunc.ComputeSha256Hash(password);
                return Db.Accounts.AsNoTracking().FirstOrDefault(p => p.Email == email && p.Password == password && p.Active); 
            }
        }
        public bool ActivateAccount(int[] ids)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    foreach (int id in ids)
                    {
                        Account account = Get(id);
                        if (!account.Active)
                        {
                            account.Active = true;
                            Db.Entry(account).State = EntityState.Modified;
                        }
                        else
                        {
                            return false;
                        }
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
        public bool DeactivateAccount(int[] ids)
        {
            try
            {
                using (HMSDB Db = new HMSDB())
                {
                    foreach (int id in ids)
                    {
                        Account account = Get(id);
                        if (account.Active)
                        {
                            account.Active = false;
                            Db.Entry(account).State = EntityState.Modified;
                        }
                        else
                        {
                            return false;
                        }
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
        public bool ChangePassword(int id, string oldPassword, string newPassword, string newPasswordAgain)
        {
            try
            {
                Account account = Get(id);
                if (account != null && StaticFunc.ComputeSha256Hash(oldPassword) == account.Password 
                    && StaticFunc.ComputeSha256Hash(newPassword) != account.Password
                    && newPassword.Length >= 6 && newPassword == newPasswordAgain)
                {
                    account.Password = StaticFunc.ComputeSha256Hash(newPassword);
                    Update(account);
                    return true;
                }
                return false; 
            }
            catch
            {
                return false;
            }
        }
        public List<Payment> GetPayments(int id)
        {
            using (HMSDB Db = new HMSDB())
            {
                return Db.Accounts.Find(id).Payments.ToList(); 
            }
        }
        public string CheckInfoAndSendCode(int cccd, DateTime birthday, string name, string phonenumber, string email)
        {
            try
            {
                Account account = Get(cccd);
                if(account == null || account.Birthday != birthday.Date || account.Name != name || account.PhoneNumber != phonenumber
                    || account.Email != email || !account.Active)
                {
                    return null;
                }
                string code = StaticFunc.RandomString(10);
                if (!StaticFunc.SendEmail(email, "Recovery code", code))
                { 
                    return null; 
                }
                return code;
            }
            catch
            {
                return null;
            }
        }
        public bool ResetPassword(int id)
        {
            try
            {
                Account account = Get(id);
                if (account != null)
                {
                    account.Password = StaticFunc.ComputeSha256Hash(account.PersonId.ToString());
                    Update(account);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
