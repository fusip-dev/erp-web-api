using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("CustomFields", Schema = "dbo")]
    public class CustomField: Entity
    {
        [Required, MaxLength(100)]
        public string Entity { get; set; }

        [Required, MaxLength(30)]
        public string CustomFieldCode { get; set; }

        [Required, MaxLength(100)]
        public string CustomFieldName { get; set; }

        [Required, MaxLength(50)]
        public string CustomFieldType { get; set; }

        [Column(TypeName = "text")]
        public string CustomFieldValidationRules { get; set; }

        [Column(TypeName = "text")]
        public string CustomFieldDefaultValue { get; set; }

        [Column(TypeName = "text")]
        public string CustomFieldValues { get; set; }

        [MaxLength(255)]
        [Column(TypeName = "text")]
        public string CustomFieldDescription { get; set; }

        [Required]
        public byte Order { get; set; }

        [InverseProperty("CustomFields")]
        public CustomFieldGroup CustomFieldGroup { get; set; }

        [InverseProperty("CustomField")]
        public ICollection<HeadquarterInformation> HeadquarterAdditionalInformation { get; set; } = new HashSet<HeadquarterInformation>();

    }
}
