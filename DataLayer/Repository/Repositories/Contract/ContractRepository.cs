using DataLayer.Infrastracture;
using DataLayer.Repository.Interfaces.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repository.Repositories.Contract
{
    public class ContractRepository : Repository<DomainLayer.Contract.Contract>, IContractRepository
    {
        private readonly DbContext db;
        public ContractRepository(DbContext dB) : base(dB)
        {
            this.db = (this.db ?? (AmlakDbContext)db);
        }
    }
}
