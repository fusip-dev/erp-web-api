using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Seasons", Schema = "dbo")]
    public class Season : Entity
    {
        [Required, MaxLength(100)]
        public string SeasonName { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime SeasonStartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? SeasonEndDate { get; set; }

        public Season ParentSeason { get; set; }

        public virtual ICollection<Season> Seasons { get; set; } = new HashSet<Season>();

        public virtual ICollection<SeasonState> SeasonStates { get; set; } = new HashSet<SeasonState>();

    }
}
