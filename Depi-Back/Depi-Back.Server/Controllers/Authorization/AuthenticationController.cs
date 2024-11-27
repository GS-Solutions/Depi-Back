 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MOE.School.Server.Controllers.Authorization
{

    [Route("api/[controller]")]
    [ApiController]

    public class AuthenticationController : ControllerBase
    {

        [HttpPost]
        [Route("Login")]
        //[Authorize]
        public async Task<ActionResult > Login()
        {

            

            var empDetailsData = new
            {
                id = 101,
                username = "UserGS",
                isActive = true,
                role = "admin"
            };
            if (empDetailsData != null)
            {
                return Ok(empDetailsData);

            }
            else
            {
                return Ok(null);

            }


        }


    }
}
