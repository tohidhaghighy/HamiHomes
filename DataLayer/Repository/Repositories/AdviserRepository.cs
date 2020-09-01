using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utilities.Hash;

namespace DataLayer.Repository.Repositories
{
    public class AdviserRepository : Repository<Adviser>, IAdviserRepository
    {
        private readonly DbContext db;
        private VerifyHash verifyhash;
        public AdviserRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

        public async Task<Adviser> Login(string username, string password)
        {
            verifyhash = new VerifyHash();
            var find = await GetManyAsync(a => a.Username == username && a.Active == true);
            if (find != null)
            {
                foreach (var item in find)
                {
                    if (verifyhash.IsValidPassword(password, item.Password))
                    {
                        return item;
                    }
                }
            }
            return null;
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
