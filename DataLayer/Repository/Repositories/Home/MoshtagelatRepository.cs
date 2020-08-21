using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Home
{
    public class MoshtagelatRepository : Repository<DomainLayer.Home.Moshtghelat>, IMoshtghelatRepository
    {
        private readonly DbContext db;
        public MoshtagelatRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

    }
}
