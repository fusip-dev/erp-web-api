using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Resources")]
    public class Resource: Entity, IAuditable
    {
        [Required, MaxLength(50)]
        public string Entity { get; set; }

        [Required]
        public Guid Reference { get; set; }

        [Required, MaxLength(100)]
        public string MimeType { get; set; }

        [Required, MaxLength(255)]
        public string Path { get; set; }

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion

    }
}
