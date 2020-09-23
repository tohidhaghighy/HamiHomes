using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Location;
using DomainLayer.Location;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Location
{
    public class NahieDirectionRepository : Repository<NahieDirections>, INahieDirectionRepository
    {
        private readonly DbContext db;
        public NahieDirectionRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
