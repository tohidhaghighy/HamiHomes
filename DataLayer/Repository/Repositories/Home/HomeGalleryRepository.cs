using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Home
{
    class HomeGalleryRepository : Repository<DomainLayer.Home.HomeGallery>, IHomeGalleryRepository
    {
        private readonly DbContext db;
        public HomeGalleryRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
