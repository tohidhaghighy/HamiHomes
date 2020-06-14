using DataLayer;
using DataLayer.Infrastracture;
using DomainLayer;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        private readonly DbContext db;
        public UserRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }


    }
}
