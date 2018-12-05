using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("PeriodStates")]
    public class PeriodState: Entity, IAuditable
    {
        [Required]
        public Period Period { get; set; }

        [Required]
        public Headquarter Headquarter { get; set; }

        [Required]
        public Module Module { get; set; }

        [Required, MaxLength(10)]
        public string State { get; set; }

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion
    }
}
