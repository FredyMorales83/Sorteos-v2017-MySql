using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Models;
using System.Configuration;

namespace DrawsDAL
{
    public partial class SorteosDB : DbContext
    {
        public SorteosDB() : base(GetConnectionString("compummc_prueba")) //Debug "pruebassorteos"
        {
        }

        //public SorteosDB() : base("pruebassorteos") //Debug "pruebassorteos"
        //{
        //}

        //public SorteosDB() : base("SorteosDB") //Release "SorteosDB"
        //{
        //}

        public static string GetConnectionString(string dbName)
        {
            var connString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString.ToString();

            return String.Format(connString, dbName);
        }

        public virtual DbSet<Boleto> Boletos { get; set; }
        public virtual DbSet<Configuracion> Configuraciones { get; set; }
        public virtual DbSet<Ganador> Ganadores { get; set; }
        public virtual DbSet<Participante> Participantes { get; set; }
        public virtual DbSet<SorteoReferencia> SorteoReferencias { get; set; }
        public virtual DbSet<Sorteo> Sorteos { get; set; }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
        }
    }
}
