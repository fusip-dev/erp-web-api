using System;
using System.Collections.Generic;
using System.Text;

namespace ORG.FSIP.ERP.Core.DAL.Infraestructure
{
    public interface IEntity
    {
        Guid Id { get; set; }

        string Status { get; set; }

        bool IsDelete { get; set; }
    }
}
