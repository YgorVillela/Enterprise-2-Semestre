using _04_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.AspNet.Persistence
{
    public class LocadoraContext : DbContext
    {

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Proprietario> Proprietario { get; set; }

        //ctor tab + tab
        public LocadoraContext(DbContextOptions opts):base(opts)
        {
                
        }
    }
}
