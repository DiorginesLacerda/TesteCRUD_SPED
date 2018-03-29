using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteCRUD_SPED.Models
{
    public class CPFModel
    {
        [StringLength(11, ErrorMessage = "O campo deve conter 11 caracteres, apenas números")]
        public string CPF { get; set; }

        public TipoPessoaModel Tipo { get; set; }
    }
}