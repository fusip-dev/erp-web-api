using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Generic
{
    public class Entity : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required, StringLength(10)]
        public string Status { get; set; }

        public bool IsDelete { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
    }
}
