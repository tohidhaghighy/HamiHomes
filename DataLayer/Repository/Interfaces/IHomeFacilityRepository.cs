using DataLayer.Infrastracture;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces
{
    public interface IHomeFacilityRepository : IRepository<HomeFacility>
    {
        Task<bool> ChangeStatus(int id);
    }
}
