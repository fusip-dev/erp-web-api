using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("CustomFields")]
    public class CustomField : Entity, IAuditable
    {
        [Required, MaxLength(100)]
        public string Entity { get; set; }

        [Required, MaxLength(30)]
        public string CustomFieldCode { get; set; }

        [Required, MaxLength(100)]
        public string CustomFieldName { get; set; }

        [Required, MaxLength(50)]
        public string CustomFieldType { get; set; }

        public string CustomFieldValidationRules { get; set; }

        public string CustomFieldDefaultValue { get; set; }

        public string CustomFieldValues { get; set; }

        [MaxLength(255)]
        public string CustomFieldDescription { get; set; }

        [Required]
        public byte Order { get; set; }

        [Required]
        public virtual CustomFieldGroup CustomFieldGroup { get; set; }

        public virtual ICollection<HeadquarterInformation> HeadquarterAdditionalInformation { get; set; } = new HashSet<HeadquarterInformation>();

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion
    }
}
