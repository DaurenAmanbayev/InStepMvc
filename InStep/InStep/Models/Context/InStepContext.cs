using InStep.Models.Dictionaries;
using System.Data.Entity;

namespace InStep.Models.Context
{
    public class InStepContext : DbContext
    {
        public InStepContext()
            : base(@"Server=1303_10PC\SQLEXPRESS1303;Database=InStep;Trusted_Connection=True;")
        {}

        public DbSet<UserData> UserData { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}