namespace TesteCRUD_SPED.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PARTICIPANTE")]
    public partial class Participante
    {
        [Required]
        [StringLength(4)]
        public string REG { get; set; }

        [Key]
        [StringLength(60)]
        public string COD_PART { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [Required]
        [StringLength(5)]
        public string COD_PAIS { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(14)]
        public string IE { get; set; }

        [StringLength(7)]
        public string COD_MUN { get; set; }

        [StringLength(9)]
        public string SUFRAMA { get; set; }

        [Required]
        [StringLength(60)]
        public string END { get; set; }

        [StringLength(10)]
        public string NUM { get; set; }

        [StringLength(60)]
        public string COMPL { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }

        public virtual Pais PAISES_IBGE { get; set; }
    }
}
