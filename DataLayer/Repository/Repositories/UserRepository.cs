using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Utilities.Hash;

namespace DataLayer.Repository.Repositories
{
    public class UserRepository:Repository<User> , IUserRepository
    {
        private readonly DbContext db;
        private VerifyHash verifyhash;
        public UserRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

        public async Task<bool> Login(string username, string password)
        {
            verifyhash = new VerifyHash();
            var find =await GetManyAsync(a => a.Username == username);
            if (find!=null)
            {
                foreach (var item in find)
                {
                    if (verifyhash.IsValidPassword(password, item.Password))
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public async Task<bool> ChangeCheck(int id)
        {
            var finduser = GetById(id);
            if (finduser != null)
            {
                if (finduser.Active)
                {
                    finduser.Active = false;
                }
                else
                {
                    finduser.Active = true;
                }
                Update(finduser);
                return true;
            }
            return false;
        }

    }
}
