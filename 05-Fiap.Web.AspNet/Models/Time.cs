using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public bool Mascote { get; set; }
        public Esporte Esporte { get; set; }

        //Relacionamento
        public Treinador Tecnico { get; set; }
       
        public int TreinadorId { get; set; }

        public IList<Jogador> Jogadores { get; set; }
        public IList<CampeonatoTime> Times { get; set; }

    }
}
