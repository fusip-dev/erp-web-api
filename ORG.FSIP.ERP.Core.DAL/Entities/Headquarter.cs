using ORG.FSIP.ERP.Core.DAL.Generic;
using ORG.FSIP.ERP.Core.DAL.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Headquarters")]
    public class Headquarter: Entity, IAuditable
    {
        [Required, MaxLength(100)]
        public string HeadquarterName { get; set; }

        [Required, MaxLength(50)]
        public string HeadquarterCity { get; set; }

        [Required, MaxLength(255)]
        [Column(Order = 3)]
        public string HeadquarterMainAddress { get; set; }

        [Required, MaxLength(10)]
        public string HeadquarterCode { get; set; }

        [Required, MaxLength(15)]
        public string Acronym { get; set; }

        [Required]
        public byte Order { get; set; }

        public virtual Headquarter ParentHeadquarter { get; set; }

        public virtual ICollection<Headquarter> SubHeadquarters { get; set; } = new HashSet<Headquarter>();

        public virtual ICollection<HeadquarterInformation> HeadquarterInformation { get; set; } = new HashSet<HeadquarterInformation>();

        public virtual ICollection<PeriodState> PeriodStatus { get; set; } = new HashSet<PeriodState>();

        #region IAuditable
        public DateTime Created { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime Modified { get; set; }

        public Guid ModifiedBy { get; set; }
        #endregion
    }
}
