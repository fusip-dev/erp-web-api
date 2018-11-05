using System;
using System.Collections.Generic;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Infraestructure
{
    public interface IAuditable
    {
        DateTime Created { get; set; }

        Guid CreatedBy { get; set; }

        DateTime Modified { get; set; }

        Guid ModifiedBy { get; set; }
    }
}
