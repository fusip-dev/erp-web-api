using System;
using System.Collections.Generic;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Infraestructure
{
    public interface IAuditable
    {
        DateTime Created { get; set; }

        string CreatedBy { get; set; }

        DateTime Modified { get; set; }

        string ModifiedBy { get; set; }
    }
}
