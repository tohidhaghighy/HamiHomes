using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories
{
    public class HomeGroupRepository : Repository<HomeGroup>, IHomeGroupRepository
    {
        private readonly DbContext db;

        public HomeGroupRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
