using DataLayer.Infrastracture;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces.AmlakSetting
{
    public interface IAmlakSanadStatusRepository:IRepository<AmlakSanadStatus>
    {
        Task<bool> ChangeStatus(int id);
    }
}
