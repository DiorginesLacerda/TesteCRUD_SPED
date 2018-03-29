using DocsBr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TesteCRUD_SPED.Models;

namespace TesteCRUD_SPED.Validations
{
    public class CPFValidoAttribute : ValidationAttribute
    {
        
        public override bool IsValid(object value)
        {
            var tipo = ParticipanteModel.tipoPessoa.ToString();
            if (tipo.Equals("Fisica"))
            {
                CPF cpf = value.ToString();
                var v = cpf.IsValid();
                return v;
            }
            base.FormatErrorMessage("Necessário ser Pessoa Física");
            return false;
        }
    }
}