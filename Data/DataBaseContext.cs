using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using CustomerApi.Models.DataBase;

namespace CustomerApi.Data
{
    public partial class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly IHttpContextAccessor httpAccessor;

        public DataBaseContext(IHttpContextAccessor httpAccessor, DbContextOptions<DataBaseContext> options):base(options)
        {
            this.httpAccessor = httpAccessor;
        }

        public DataBaseContext(IHttpContextAccessor httpAccessor)
        {
            this.httpAccessor = httpAccessor;
        }

        //partial void OnModelBuilding(ModelBuilder builder);

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);



        //    builder.Entity<Customer>()
        //          .Property(p => p.CreatedDate)
        //          .HasColumnType("datetime2");

        //    builder.Entity<Customer>()
        //          .Property(p => p.LastUpdated)
        //          .HasColumnType("datetime2");

        //    builder.Entity<Customer>()
        //          .Property(p => p.Id)
        //          .HasPrecision(10, 0);
        //    this.OnModelBuilding(builder);
        //}


        public DbSet<Customer> Customers
        {
          get;
          set;
        }

        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
        //    configurationBuilder.Conventions.Add(_ => new BlankTriggerAddingConvention());
        //}
    }
}
