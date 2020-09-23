using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Sazande;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Sazande
{
    public class SazandeGalleryRepository : Repository<DomainLayer.Sazande.SazandeGallery>, ISazandeGallery
    {
        private readonly DbContext db;
        public SazandeGalleryRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

    }
}
