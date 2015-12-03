namespace Brello.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Brello.Models.BoardContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Brello.Models.BoardContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Colors.AddOrUpdate(
                c => c.Name,
                new Models.Color { Name = "Black", Value = "#000000"},
                new Models.Color { Name = "White", Value = "#ffffff" }
            );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
