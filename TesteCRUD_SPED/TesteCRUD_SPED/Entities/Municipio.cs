namespace TesteCRUD_SPED.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Municipio
    {
        [Key]
        [StringLength(7)]
        public string COD_MUNICIPIO { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME_MUNICIPIO { get; set; }

        public int COD_ESTADO { get; set; }

        public virtual Estado ESTADOS_IBGE { get; set; }
    }
}
