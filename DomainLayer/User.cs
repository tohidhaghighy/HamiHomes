using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class User:BaseEntity<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
