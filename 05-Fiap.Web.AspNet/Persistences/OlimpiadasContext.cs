using _05_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Persistences
{
    public class OlimpiadasContext : DbContext
    {
        public DbSet<Time> Times { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Treinador> Treinadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a tabela associativa
            //configurar as chaves da tabela
            modelBuilder.Entity<CampeonatoTime>()
                .HasKey(c => new { c.CampeonatoId, c.TimeId });

            //configurar o relacionamento com o Campeonato
            modelBuilder.Entity<CampeonatoTime>()
                .HasOne(c => c.Campeonato)
                .WithMany(c => c.Times)
                .HasForeignKey(c => c.CampeonatoId);

            //Configurar o relacionamento com o time
            modelBuilder.Entity<CampeonatoTime>()
                .HasOne(c => c.Time)
                .WithMany(c => c.Times)
                .HasForeignKey(c => c.TimeId);
        }
        public OlimpiadasContext(DbContextOptions o) : base(o)
        {

        }
    }
}
