using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Home
{
    public class GardenWithVilaRepository : Repository<DomainLayer.Home.GardenWithVila>, IGardenWithVilaRepository
    {
        private readonly DbContext db;
        public GardenWithVilaRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

    }
}
