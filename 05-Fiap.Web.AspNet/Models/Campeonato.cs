using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        public decimal Premiacao{ get; set; }
        public string Nome { get; set; }
        public TipoCampeonato TipoCampeonato { get; set; }

        public IList<CampeonatoTime> Times { get; set; }
    }
}
