namespace ConsoleApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApplication1.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ConsoleApplication1.Context context)
        {            
            context.Students.AddOrUpdate(
            s => s.SName,
            new Student { SName = "Andrew Peters" },
            new Student { SName = "Brice Lambson" },
            new Student { SName = "Rowan Miller" }
            );

            context.Teachers.AddOrUpdate(
            s => s.TName,
            new Teacher { TName = "Andrew Peters" },
            new Teacher { TName = "Brice Lambson" },
            new Teacher { TName = "Rowan Miller" }
            );  
        }
    }
}
