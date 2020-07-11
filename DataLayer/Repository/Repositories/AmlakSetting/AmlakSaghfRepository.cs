using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.AmlakSetting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.AmlakSetting
{
    public class AmlakSaghfRepository:Repository<AmlakSaghf>, IAmlakSaghfRepository
    {
        private readonly DbContext db;
        public AmlakSaghfRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
