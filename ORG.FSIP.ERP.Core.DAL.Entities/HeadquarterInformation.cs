using ORG.FSIP.ERP.Core.DAL.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Entities
{
    [Table("HeadquartersInformation", Schema = "dbo")]
    public class HeadquarterInformation : Entity
    {
        [Required]
        [Column(TypeName = "text")]
        public string Value { get; set; }

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        public CustomField CustomField { get; set; }

        public Headquarter Headquarter { get; set; }

    }
}
