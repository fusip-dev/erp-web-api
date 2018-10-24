using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ORG.FSIP.ERP.WebApi.Models;
using ORG.FSIP.ERP.WebApi.Services;

namespace ORG.FSIP.ERP.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesController : ControllerBase
    {

        public IModuleService ModuleService { get; }

        public ModulesController(IModuleService moduleService)
        {
            ModuleService = moduleService;
        }
        // GET api/modules
        [HttpGet]
        public ActionResult<IEnumerable<Module>> Get()
        {
            return ModuleService.List();
        }

        // GET api/modules/77f83185-e044-4d0a-ba74-b35ea9e35d9b
        [HttpGet("{id}", Name = "ModuleById")]
        public ActionResult<Module> Get(Guid id)
        {
            var module = ModuleService.Get(id);

            if (module == null)
                return NotFound();

            return Ok(module);
        }

        // POST api/modules
        [HttpPost]
        public IActionResult Post([FromBody] Module module)
        {
            if (ModelState.IsValid)
            {
                ModuleService.Save(module);

                return new CreatedAtRouteResult("ModuleById", new { id = module.Id }, module);
            }

            return BadRequest(ModelState);
        }

        // PUT api/modules/77f83185-e044-4d0a-ba74-b35ea9e35d9b
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Module data)
        {
            if (data.Id != id)
            {
                return BadRequest();
            }
            var module = ModuleService.Get(id);
            if (module == null)
            {
                return NotFound();
            }

            ModuleService.Update(id, data);

            return Ok();

        }

        // DELETE api/modules/77f83185-e044-4d0a-ba74-b35ea9e35d9b
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var module = ModuleService.Get(id);
            if (module == null) return NotFound();

            ModuleService.Delete(id);
            return Ok(module);
        }
    }
}
