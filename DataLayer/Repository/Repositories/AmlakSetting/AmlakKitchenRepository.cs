﻿using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.AmlakSetting;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Repositories.AmlakSetting
{
    public class AmlakKitchenRepository : Repository<AmlakKitchen>, IAmlakKitchenRepository
    {
        private readonly DbContext db;
        public AmlakKitchenRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }

        public async Task<bool> ChangeStatus(int id)
        {
            var finduser = GetById(id);
            if (finduser != null)
            {
                if (finduser.ShowinSearch)
                {
                    finduser.ShowinSearch = false;
                }
                else
                {
                    finduser.ShowinSearch = true;
                }
                Update(finduser);
                return true;
            }
            return false;
        }
    }
}
