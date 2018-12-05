using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("HeadquartersInformation")]
    public class HeadquarterInformation: Entity, IAuditable
    {
        [Required]
        public string Value { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public CustomField CustomField { get; set; }

        [Required]
        public Headquarter Headquarter { get; set; }

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion
    }
}
