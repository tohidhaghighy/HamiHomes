using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Setting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Setting
{
    public class CostSettingRepository : Repository<CostSetting>, ICostSettingRepository
    {
        private readonly DbContext db;
        public CostSettingRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
