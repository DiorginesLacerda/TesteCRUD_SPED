using DocsBr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Entities;
using TesteCRUD_SPED.Validations;

namespace TesteCRUD_SPED.Models
{
    public class ParticipanteModel
    {
        [Required(ErrorMessage ="Necessário Informar um Código para o Participante")]
        [MaxLength(60)]
        public int Cod_Part { get; set; }

        [Required(ErrorMessage = "Necessário Informar o Nome para o Participante")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Necessário Informar o Pais")]
        public PAISES_IBGE Pais { get; set; }

        public ESTADOS_IBGE Estado { get; set; }

        public static TipoPessoaModel tipoPessoa;
        public TipoPessoaModel TipoPessoa
        {
            get { return tipoPessoa; }
            set { tipoPessoa = value; }
        }

        private string cnpj;

        [StringLength(14,ErrorMessage ="O campo deve conter 14 caracteres, apenas números")]
        [CNPJValido]
        public string CNPJ
        {
            get
            {
                return this.cnpj;
            }
            set
            {
                if (TipoPessoa.Equals("Juridica"))
                {
                    CNPJ c = value;
                    if (c.IsValid())
                        this.cnpj = value;
                    else
                        throw new Exception("Valor De CNPJ Inválido");
                }
                
            }
        }

        
        [CPFValido]
        public string CPF { get; set; }
        

        private string ie;
        [MaxLength(14)]
        public string IE
        {
            get { return this.ie; }
            set
            {
                if (!IsentoIE && !String.IsNullOrEmpty(value))
                {
                    IE i = new IE(value, Estado.COD_ESTADO);
                    if (i.IsValid())
                        this.ie = value;
                }
            }
        }

        public MUNICIPIOS_IBGE Municipio  { get; set; }

        [StringLength(9)]
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