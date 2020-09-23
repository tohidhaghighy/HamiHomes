using System;
using System.Collections.Generic;
using System.Text;
using ViewModelLayer.Home;

namespace ViewModelLayer.User
{
    public class UserMain
    {
        public DomainLayer.User User { get; set; }
        public List<DomainLayer.Contract.Contract> homes { get; set; }
        public HomeProperty HomeProperty { get; set; }
        public DomainLayer.Contract.Contract Contract { get; set; }
    }
}
