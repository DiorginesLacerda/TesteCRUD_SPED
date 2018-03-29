using DocsBr;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TesteCRUD_SPED.Validations
{
    public class CNPJValidoAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                CNPJ cnpj = value.ToString();
                if (!String.IsNullOrEmpty(cnpj))
                    return cnpj.IsValid();
                return false;
            }
            catch(Exception )
            {
                return false;
            }
        }
    }
}