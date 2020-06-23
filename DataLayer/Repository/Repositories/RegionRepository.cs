using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        private readonly DbContext db;
        public RegionRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
