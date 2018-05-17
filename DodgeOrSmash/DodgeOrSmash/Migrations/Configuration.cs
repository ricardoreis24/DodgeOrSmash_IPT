using System.Collections.Generic;
using System.ComponentModel.Design;
using DodgeOrSmash.Models;

namespace DodgeOrSmash.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DodgeOrSmash.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DodgeOrSmash.Models.ApplicationDbContext context)
        {
            var user = new List<Users>
            {
                new Users
                {
                    UserID = 1,
                    Name = "Gamer4Life",
                    Wallet = 10,
                    Score = 0,
                    ActiveSkin = "default",
                }
                
            };
            user.ForEach(aa => context.Users.AddOrUpdate(a => a.Name,aa));
                context.SaveChanges();

            var skin = new List<Skins>
            {
                new Skins
                {
                    SkinsID = 1,
                    IsActive = true,
                    Name = "default",
                    Price = 0,
                    ImagePath = "default.png",
                }
            };
            skin.ForEach(aa => context.Skins.AddOrUpdate(a => a.SkinsID, aa));
            context.SaveChanges();

            var inventory = new List<Inventory>
            {
                new Inventory
                {
                    InventoryID = 1,
                    idUser = 1,
                    idSkin = 1,
                }
            };
            inventory.ForEach(aa => context.Inventory.AddOrUpdate(a => a.idUser, aa));
            context.SaveChanges();
        }
    }
}
