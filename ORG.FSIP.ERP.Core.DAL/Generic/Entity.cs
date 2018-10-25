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

        public string Status { get; set; }

        public bool IsDelete { get; set; }

        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public string ModifiedBy { get; set; }
    }
}
