using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Setting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataLayer.Repository.Repositories.Setting
{
    public class EjareSettingRepository : Repository<EjareSetting>, IEjareSettingRepository
    {
        private readonly DbContext db;
        public EjareSettingRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
