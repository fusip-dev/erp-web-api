using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Generic
{
    public class Entity : IEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(10)]
        public string Status { get; set; }

        public bool IsDelete { get; set; }
    }
}
