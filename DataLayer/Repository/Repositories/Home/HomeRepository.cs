using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Home
{
    public class HomeRepository : Repository<DomainLayer.Home.Home>, IHomeRepository
    {
        private readonly DbContext db;
        public HomeRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

    }
}
