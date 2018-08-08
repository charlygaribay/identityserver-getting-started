using Identity.ApiModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Identity.Controllers
{
    [Produces("application/json")]
    [Route("api/Events")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class EventsController : Controller
    {
        public async Task<ActionResult> GetEvents()
        {
            await Task.Delay(10);

            return Ok(new List<TaskApiModel>()
            {
                new TaskApiModel
                {
                    Id = 123,
                    Title = "Hola",
                    Description = "Hello"
                }
            });
        }
    }
}