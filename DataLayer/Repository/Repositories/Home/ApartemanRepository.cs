using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Home
{
    public class ApartemanRepository : Repository<DomainLayer.Home.Aparteman>, IHomeApartemanRepository
    {
        private readonly DbContext db;
        public ApartemanRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

    }
}
