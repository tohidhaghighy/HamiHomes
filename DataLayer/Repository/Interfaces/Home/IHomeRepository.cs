using DataLayer.Infrastracture;
using System;
using System.Collections.Generic;
using System.Text;
using DomainLayer.Home;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces.Home
{
    public interface IHomeRepository : IRepository<DomainLayer.Home.Home>
    {
        Task<bool> ChangeCheck(int id);
    }
}
