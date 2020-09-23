using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Sazande;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Sazande
{
    public class HomeSazandeRepository : Repository<DomainLayer.Sazande.HomeSazande>, IHomeSazandeRepository
    {
        private readonly DbContext db;
        public HomeSazandeRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
