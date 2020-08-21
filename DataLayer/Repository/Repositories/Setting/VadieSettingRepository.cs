using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Setting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataLayer.Repository.Repositories.Setting
{
    public class VadieSettingRepository : Repository<VadieSetting>, IVadieSettingRepository
    {
        private readonly DbContext db;
        public VadieSettingRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
