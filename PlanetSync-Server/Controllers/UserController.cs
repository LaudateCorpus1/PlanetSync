using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlanetSync_Server.Data;
using PlanetSync_Server.Data.Models;

namespace PlanetSync_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("id/{id}")]
        public async Task<ActionResult<User>> GetUser(ulong id)
        {
            using (var db = new PsContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Id.Equals(id));
                if(user != null)
                    return Ok(user);
            }

            return StatusCode(404, "User not found");
        }
    }
}