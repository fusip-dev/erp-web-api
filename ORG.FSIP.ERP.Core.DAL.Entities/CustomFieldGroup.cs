using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("CustomFieldGroups", Schema = "dbo")]
    public class CustomFieldGroup:  Entity
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

        [InverseProperty("CustomFieldGroup")]
        public virtual ICollection<CustomField> CustomFields { get; set; } =  new HashSet<CustomField>();
    }
}
