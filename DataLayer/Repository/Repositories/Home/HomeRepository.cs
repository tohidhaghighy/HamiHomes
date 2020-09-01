using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Repositories.Home
{
    public class HomeRepository : Repository<DomainLayer.Home.Home>, IHomeRepository
    {
        private readonly DbContext db;
        public HomeRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

        public async Task<bool> ChangeCheck(int id)
        {
            var finduser = GetById(id);
            if (finduser != null)
            {
                if (finduser.IsShow)
                {
                    finduser.IsShow = false;
                }
                else
                {
                    finduser.IsShow = true;
                }
                Update(finduser);
                
                return true;
            }
            return false;
        }
    }
}
