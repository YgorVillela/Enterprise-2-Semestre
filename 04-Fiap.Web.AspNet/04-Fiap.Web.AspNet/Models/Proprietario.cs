using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.AspNet.Models
{
    [Table("T_PROPRIETARIA")]
    public class Proprietario
    {
        [Key]
        [Column("cd_codigo")]
        public int ProprietarioId { get; set; }

        public String Nome { get; set; }

        public bool Deficiente { get; set; }
    }
}
