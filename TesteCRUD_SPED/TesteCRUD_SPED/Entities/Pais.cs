namespace TesteCRUD_SPED.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pais()
        {
            PARTICIPANTEs = new HashSet<Participante>();
        }

        [Key]
        [StringLength(5)]
        public string COD_PAIS { get; set; }

        [Required]
        [StringLength(60)]
        public string NOME_PAIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participante> PARTICIPANTEs { get; set; }
    }
}
