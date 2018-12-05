using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Modules")]
    public class Module: Entity, IAuditable
    {
        [Required, MaxLength(50)]
        public string ModuleCode { get; set; }

        [Required, MaxLength(100)]
        public string ModuleName { get; set; }

        [MaxLength(255)]
        public string ModuleDescription { get; set; }

        public virtual ICollection<PeriodState> PeriodStates { get; set; } = new HashSet<PeriodState>();

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion
    }
}
