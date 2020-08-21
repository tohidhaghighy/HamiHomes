using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Home
{
    public class HomeWithGardenRepository : Repository<DomainLayer.Home.HomewithGarden>, IHomeWithGardenRepository
    {
        private readonly DbContext db;
        public HomeWithGardenRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

    }
}
