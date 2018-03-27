using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;

namespace TesteCRUD_SPED.Models
{
    public class ParticipanteModel
    {
        
        public int Cod_Part { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public Pais Pais { get; set; }


        public string CNPJ { get; set; }

        public string CPF { get; set; }

        public string IE { get; set; }

        public Municipio Municipio { get; set; }

        public string SUFRAMA { get; set; }

        [Required]
        public string Endereco { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public bool IsentoIE { get; set; }

    }
}