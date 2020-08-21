using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Setting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Setting
{
    public class MetrazSettingRepository : Repository<MetrazSetting>, IMetrazSettingRepository
    {
        private readonly DbContext db;
        public MetrazSettingRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
