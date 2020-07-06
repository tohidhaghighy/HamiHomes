using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Repositories
{
    public class MagzineRepository : Repository<Magzine>, IMagzineRepository
    {
        private readonly DbContext db;
        public MagzineRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

        public async Task<bool> ChangeStatus(int id)
        {
            var find = GetById(id);
            if (find != null)
            {
                if (find.Is_Show)
                {
                    find.Is_Show = false;
                }
                else
                {
                    find.Is_Show = true;
                }
                Update(find);
                return true;
            }
            return false;
        }
    }
}
