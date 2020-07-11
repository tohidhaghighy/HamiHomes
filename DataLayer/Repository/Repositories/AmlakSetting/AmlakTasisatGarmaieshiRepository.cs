using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.AmlakSetting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.AmlakSetting
{
    public class AmlakTasisatGarmaieshiRepository: Repository<AmlakTasisatGarmaieshi> , IAmlakTasisatGarmaieshiRepository
    {
        private readonly DbContext db;
        public AmlakTasisatGarmaieshiRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
