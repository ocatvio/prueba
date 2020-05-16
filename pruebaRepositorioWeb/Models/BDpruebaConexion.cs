using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace pruebaRepositorioWeb.Models
{
    public class BDpruebaConexion :DbContext
    {

        public BDpruebaConexion() : base("name=DBpruebaConexion")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet <producto> producto { get; set; }
    }
}