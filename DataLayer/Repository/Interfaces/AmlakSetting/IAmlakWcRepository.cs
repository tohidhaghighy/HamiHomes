using DataLayer.Infrastracture;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces.AmlakSetting
{
    public interface IAmlakWcRepository:IRepository<AmlakWC>
    {
        Task<bool> ChangeStatus(int id);
    }
}
