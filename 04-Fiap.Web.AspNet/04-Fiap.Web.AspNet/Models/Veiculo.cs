using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Fiap.Web.AspNet.Models
{
    [Table("T_VEICULO")]
    public class Veiculo
    {
        [Key]
        [Column("cd_codigo"), HiddenInput]
        public int Codigo { get; set; }

        public float Peso { get; set; }

        [Required, MaxLength(100)]
        public string Modelo { get; set; }

        [Display(Name ="Data Fabricação"),DataType(DataType.Date)]
        public DateTime DataFabricacao { get; set; }

        [Required]
        public Combustivel Combustivel { get; set; }
    }
}
