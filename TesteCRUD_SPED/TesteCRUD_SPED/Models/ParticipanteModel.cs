using DocsBr;
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
        [Required(ErrorMessage ="Necessário Informar um Código para o Participante")]
        [MaxLength(60)]
        public string Cod_Part { get; set; }

        [Required(ErrorMessage = "Necessário Informar o Nome")]
        [MaxLength(100)]
        public string Nome { get; set; }

        public PAISES_IBGE Pais { get; set; }

        public ESTADOS_IBGE Estado { get; set; }

        public TipoPessoaModel TipoPessoa { get; set; }

        [StringLength(14,ErrorMessage ="O campo deve conter 14 caracteres, apenas números")]
        public string CNPJ { get; set; }
       
        [StringLength(11,ErrorMessage ="O campo deve conter 11 caracteres, apenas números")]
        public string CPF { get; set; }

        [MaxLength(14)]
        public string IE { get; set; }
       
        public MUNICIPIOS_IBGE Municipio  { get; set; }

        [StringLength(9, ErrorMessage = "O campo deve conter 9 caracteres, apenas números")]
        public string SUFRAMA { get; set; }

        [Required(ErrorMessage = "Necessário Informar um Endereço")]
        [MaxLength(60)]
        public string Endereco { get; set; }

        [MaxLength(10)]
        public int Numero { get; set; }

        [MaxLength(60)]
        public string Complemento { get; set; }

        [MaxLength(60)]
        public string Bairro { get; set; }

        public bool IsentoIE { get; set; }

    }
}