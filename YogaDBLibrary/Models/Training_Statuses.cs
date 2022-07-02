namespace YogaDBLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Training_Statuses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Training_Statuses()
        {
            Trainings = new HashSet<Training>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatusId { get; set; }

        [Required]
        [StringLength(25)]
        public string Status_Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Training> Trainings { get; set; }

        public override string ToString()
        {
            return Status_Description.ToString();
        }
    }
}
