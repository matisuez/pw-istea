using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Persistencia.Models;

namespace Persistencia
{
    public class PeopleDBContext : DbContext
    {
        public virtual DbSet<Person> Person { get;set; }
        //public virtual DbSet<Role> Role { get;set; }
        public PeopleDBContext() { }

        public PeopleDBContext(DbContextOptions<PeopleDBContext> options) : base(options) {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            base.OnConfiguring(optionsBuilder);
        }

    }

}