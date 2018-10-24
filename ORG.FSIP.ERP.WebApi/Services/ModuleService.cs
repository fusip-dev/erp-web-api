using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ORG.FSIP.ERP.WebApi.Models;

namespace ORG.FSIP.ERP.WebApi.Services
{
    public class ModuleService : IModuleService
    {
        private List<Module> modules;

        public ModuleService()
        {
            modules = new List<Module> {
                new Module { Id = new Guid("c53988b6-0a1d-4764-8e96-b2f86659252d"), Name = "Accounting" },
                new Module { Id = new Guid("3ad4dac2-561d-479e-a161-34f56ac05bba"), Name = "AssetManagement" },
                new Module { Id = new Guid("27afefaf-2f74-41f0-b2ad-204d425110a6"), Name = "HumanResources" },
                new Module { Id = new Guid("19b16226-3d19-4fa5-ae0e-5e95e7343bd7"), Name = "Invoicing" },
                new Module { Id = new Guid("77f83185-e044-4d0a-ba74-b35ea9e35d9b"), Name = "Security" }
            };
        }
        public Module Delete(Guid id)
        {
            var module = modules.First(m => m.Id == id);

            modules.Remove(module);

            return module;
        }

        public Module Get(Guid id)
        {
            return modules.FirstOrDefault(m => m.Id == id);
        }

        public List<Module> List()
        {
            return modules;
        }

        public Module Save(Module module)
        {
            module.Id = Guid.NewGuid();

            modules.Add(module);
            return module;
        }

        public Module Update(Guid id, Module data)
        {
            var module = modules.First(m => m.Id == id);

            module.Name = data.Name;

            return module;
        }
    }
}
