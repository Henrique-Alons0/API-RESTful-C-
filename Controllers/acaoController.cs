using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using chamadosTeste.data;
using chamadosTeste.Models;

namespace chamadosTeste.Controllers
{
    [ApiController]
    [Route("v1/acoes")]

    public class AcoesController : ControllerBase
    {

        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Acoes>>> GET([FromServices] dataContext context){
            
            var acoes = await context.Acoes.ToListAsync();
            return acoes;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Acoes> Post(
            [FromServices] dataContext context,
            [FromBody]Acoes model)
        {
            if (ModelState.IsValid)
            {
                context.Acoes.Add(model);
                awayt context.SaveChangesAsync();
                return model;
            }else{
                return BadRequest(ModelState);
            }
        }
        
    }
}
