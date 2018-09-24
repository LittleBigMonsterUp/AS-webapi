using ASWebapi22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ASWebapi22.DAL
{
    public class AccountContext : DbContext
    {
        public AccountContext()
              : base("AccountContext")
        {

        }
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}