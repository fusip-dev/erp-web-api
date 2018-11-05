using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Resources", Schema = "dbo")]
    public class Resource : Entity
    {
        [Required, MaxLength(255)]
        public string Entity { get; set; }

        [Required]
        public Guid Reference { get; set; }

        [Required, MaxLength(100)]
        public string MimeType { get; set; }

        [Required, MaxLength(255)]
        public string Path { get; set; }
    }
}
