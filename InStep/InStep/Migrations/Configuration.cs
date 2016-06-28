namespace InStep.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using InStep.Helpers;

    internal sealed class Configuration : DbMigrationsConfiguration<InStep.Models.Context.InStepContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(InStep.Models.Context.InStepContext context)
        {
            context.Countries.Add(new Models.Dictionaries.Country { CountryName = "Казахстан", Id = 1 });
            context.Countries.Add(new Models.Dictionaries.Country { CountryName = "Россия", Id = 2 });

            context.Cities.Add(new Models.Dictionaries.City { CityName = "Астана", CountryId = 1, Id = 1 });
            context.Cities.Add(new Models.Dictionaries.City { CityName = "Алматы", CountryId = 1, Id = 2 });
            context.Cities.Add(new Models.Dictionaries.City { CityName = "Томск", CountryId = 2, Id = 3 });
            context.Cities.Add(new Models.Dictionaries.City { CityName = "Санкт-Петербург", CountryId = 2, Id = 4 });

            context.UserData.Add(new Models.UserData
            {
                Id = 1,
                FirstName = "test",
                SecondName = "test",
                LastName = "test",
                PhoneNumber = "123345",
                BirthDate = new DateTime(1990, 05, 10),
                Email = "a@mail.ru",
                Sex = true,
                Password = "12345".Encrypt()
            });

            //  This method will be called after migrating to the latest version.

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
