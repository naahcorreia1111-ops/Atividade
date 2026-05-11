using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ativ_MVC.Models
{
    public class Musica
    {

        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Artista { get; set; }

        [Required]
        [Range(1801, 2026)]
        public int AnoLancamento { get; set; }

        [Required]
        public decimal Duracao_Minutos { get; set; }

        public string Genero { get; set; }

        public DateTime DataCadastro { get; set; }


    }
}