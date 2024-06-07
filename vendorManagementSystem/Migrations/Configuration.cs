using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vendorManagementSystem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<vendorManagementSystem.Models.VendorManagementContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "vendorManagementSystem.Models.VendorManagementContext";
        }

        protected override void Seed(vendorManagementSystem.Models.VendorManagementContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}