using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories
{
    public class HomeFacilityRepository : Repository<HomeFacility>, IHomeFacilityRepository
    {
        private readonly DbContext db;
        
        public HomeFacilityRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
