using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    [Produces("application/json")]
    [Route("api/Events")]
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