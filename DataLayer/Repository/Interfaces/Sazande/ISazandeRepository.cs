using DataLayer.Infrastracture;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Interfaces.Sazande
{
    public interface ISazandeRepository : IRepository<DomainLayer.Sazande.Sazande>
    {
        Task<bool> Login(string username, string password);
        Task<bool> ChangeCheck(int id);
    }
}
