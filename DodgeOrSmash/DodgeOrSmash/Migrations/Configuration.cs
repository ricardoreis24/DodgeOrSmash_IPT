using System.Collections.Generic;
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
                Users.For
            };
        }
    }
}
