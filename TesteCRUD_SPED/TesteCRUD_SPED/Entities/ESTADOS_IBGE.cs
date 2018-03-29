namespace TesteCRUD_SPED.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTADOS_IBGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADOS_IBGE()
        {
            MUNICIPIOS_IBGE = new HashSet<MUNICIPIOS_IBGE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_ESTADO { get; set; }

        [Required]
        [StringLength(2)]
        public string SIGLA_ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUNICIPIOS_IBGE> MUNICIPIOS_IBGE { get; set; }
    }
}
