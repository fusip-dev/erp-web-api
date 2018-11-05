using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("SeasonStates", Schema = "dbo")]
    public class SeasonState: Entity
    {
        [Required]
        public string State { get; set; }

        public Module Module { get; set; }

        public Season Season { get; set; }

        public Headquarter Headquarter { get; set; }
    }
}
