using DataLayer.Infrastracture;
using DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces
{
    public interface IUserRepository :IRepository<User>
    {
        Task<User> Login(string username, string password);
        Task<bool> ChangeCheck(int id);
    }
}
