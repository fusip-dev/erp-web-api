using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Periods")]
    public class Period: Entity, IAuditable
    {
        [Required, MaxLength(100)]
        public string PeriodName { get; set; }

        [Required]
        public DateTime PeriodStartDate { get; set; }

        public DateTime? PeriodEndDate { get; set; }

        public Period ParentPeriod { get; set; }

        public virtual ICollection<Period> Periods { get; set; } = new HashSet<Period>();

        public virtual ICollection<PeriodState> PeriodStates { get; set; } = new HashSet<PeriodState>();

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion
    }
}
