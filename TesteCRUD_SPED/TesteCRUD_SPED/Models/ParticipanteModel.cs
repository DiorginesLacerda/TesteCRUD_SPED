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
        [Required]
        public int Cod_Part { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public PAISES_IBGE Pais { get; set; }

        public ESTADOS_IBGE Estado { get; set; }

        public TipoPessoaModel TipoPessoa { get; set; }

        private string cnpj;
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
        private string cpf;
        public string CPF
        {
            get
            {
                return this.cpf;
            }
            set
            {
                if (TipoPessoa.Equals("Fisica"))
                {
                    CPF c = value;
                    if (c.IsValid())
                        this.cpf = value;
                    else
                        throw new Exception("Valor De CPF Inválido");
                }
                else this.cpf = null;
                
            }
        }

        private string ie;
        public string IE
        {
            get { return this.ie; }
            set
            {
                if (!IsentoIE)
                {
                    IE i = new IE(value, Estado.COD_ESTADO);
                    if (i.IsValid())
                        this.ie = value;
                }
            }
        }

        public MUNICIPIOS_IBGE Municipio
        { get; set; }

        public string SUFRAMA { get; set; }

        [Required]
        public string Endereco { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public bool IsentoIE { get; set; }

    }
}