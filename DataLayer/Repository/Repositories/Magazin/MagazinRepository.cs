﻿using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Magazin;
using DomainLayer.Magzine;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Magazin
{
    public class MagazinRepository : Repository<Magazine>, IMagazinRepository
    {
        private readonly DbContext db;
        public MagazinRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}