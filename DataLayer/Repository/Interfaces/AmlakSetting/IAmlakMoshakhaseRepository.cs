using DataLayer.Infrastracture;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces.AmlakSetting
{
    public interface IAmlakMoshakhaseRepository:IRepository<AmlakMoshakhase>
    {
        Task<bool> ChangeStatus(int id);
    }
}
