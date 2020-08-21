using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Home
{
    public class EdariRepository : Repository<DomainLayer.Home.Edari>, IHomeEdariRepository
    {
        private readonly DbContext db;
        public EdariRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

    }
}
