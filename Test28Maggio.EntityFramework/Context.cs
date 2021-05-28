using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test28Maggio.Library;

namespace Test28Maggio.EntityFramework
{
    public class Context : DbContext
    {
        //Creazione del DbSet
        public DbSet<Cliente> Clienti { get; set; }
        public DbSet<Ordine> Ordini { get; set; }

        #region CTors
        public Context() : base() { }

        public Context(DbContextOptions<Context> options) : base(options) { }

        #endregion

        #region Override

        //Connessione al Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=GestioneClientiOrdini;Integrated Security=True";

                optionsBuilder.UseSqlServer(connString);
            }
        }

        //Modellare le tabelle
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration<Ordine>(new OrdineConfiguration());
        }
        #endregion
    }
}
