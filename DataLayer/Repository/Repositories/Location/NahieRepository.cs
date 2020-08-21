using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Location;
using DomainLayer.Location;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Location
{
    public class NahieRepository : Repository<Nahie>, INahieRepository
    {
        private readonly DbContext db;
        public NahieRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
