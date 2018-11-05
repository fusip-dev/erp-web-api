using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("Modules", Schema = "dbo")]
    public class Module : Entity
    {
        [Required, MaxLength(50)]
        public string ModuleCode { get; set; }

        public string ModuleName { get; set; }

        [MaxLength(255)]
        public string ModuleDescription { get; set; }

        public virtual ICollection<SeasonState> SeasonStates { get; set; } = new HashSet<SeasonState>();
    }
}
