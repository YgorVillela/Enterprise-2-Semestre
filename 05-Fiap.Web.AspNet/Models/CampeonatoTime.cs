using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class CampeonatoTime
    {
        public Time Time { get; set; }
        public int TimeId { get; set; }
        public Campeonato Campeonato { get; set; }
        public int CampeonatoId { get; set; }
    }
}
