using ORG.FSIP.ERP.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORG.FSIP.ERP.WebApi.Services
{
    public interface IModuleService
    {
        List<Module> List();

        Module Get(Guid id);

        Module Save(Module module);

        Module Update(Guid id, Module module);

        Module Delete(Guid id);
    }
}
