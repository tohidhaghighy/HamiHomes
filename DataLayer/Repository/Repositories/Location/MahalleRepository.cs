using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Location;
using DomainLayer.Location;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Location
{
    public class MahalleRepository : Repository<Mahalle>, IMahalleRepository
    {
        private readonly DbContext db;
        public MahalleRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
