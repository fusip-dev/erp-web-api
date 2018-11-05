using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Headquarters", Schema = "dbo")]
    public class Headquarter: Entity
    {
        [Required, MaxLength(100)]
        public string HeadquarterName { get; set; }

        [Required, MaxLength(20)]
        public string HeadquarterCity { get; set; }

        [MaxLength(255)]
        public string HeadquarterAddress { get; set; }

        [Required, MaxLength(10)]
        public string HeadquarterCode { get; set; }

        [Required, MaxLength(15)]
        public string Acronym { get; set; }

        public byte Order { get; set; }

        public virtual Headquarter ParentHeadquarter { get; set; }

        public virtual ICollection<Headquarter> SubHeadquarters { get; set; } = new HashSet<Headquarter>();

        public virtual ICollection<HeadquarterInformation> HeadquarterInformation { get; set; } = new HashSet<HeadquarterInformation>();

        public virtual ICollection<SeasonState> SeasonStatus { get; set; } = new HashSet<SeasonState>();
    }
}
