using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer
{
    public static class DbInitializer
    {
        public static void Initialize(AmlakDbContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Admins.Any())
            {
                return;
                // DB has been seeded
            }


            var users = new Admin[]
           {
            new Admin{Name="tarh o tasvir",Family="",Username="tarhotasvir",Password="o6d2N9TJbZw/jk4nityejFom+VuWVXAwKCIaMh2qSXEiSlbZqbIDTw==",Active=true,AdminType=DomainLayer.Enums.AdminType.GoldenAdmin}
           };
            foreach (Admin s in users)
            {
                context.Admins.Add(s);
            }

            var setting = new Setting()
            {
                Mobile="",
                Description="",
                Keys="",
                Title="",
                Phone="",
                Icon="",
                Author=""
            };
            context.Settings.Add(setting);
            context.SaveChanges();


        }
    }
}
