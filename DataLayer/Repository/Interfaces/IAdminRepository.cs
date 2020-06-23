using DataLayer.Infrastracture;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Task<bool> Login(string username, string password);
        Task<bool> ChangeCheck(int id);
    }
}
