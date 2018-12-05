using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("CustomFieldGroups")]
    public class CustomFieldGroup: Entity, IAuditable
    {
        [Required, MaxLength(100)]
        public string Entity { get; set; }

        [Required, MaxLength(30)]
        public string CustomFieldGroupCode { get; set; }

        [Required, MaxLength(100)]
        public string CustomFieldGroupName { get; set; }

        [MaxLength(255)]
        public string CustomFieldGroupDescription { get; set; }

        [Required]
        public byte Order { get; set; }

        public virtual ICollection<CustomField> CustomFields { get; set; } = new HashSet<CustomField>();

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion
    }
}
