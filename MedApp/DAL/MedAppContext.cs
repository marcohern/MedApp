using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MedApp.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MedApp.DAL
{
    public class MedAppContext : DbContext
    {
        public MedAppContext():base("MedAppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<TipoCita> TipoCitas { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}