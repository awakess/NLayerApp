using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]  //endpoint olmadığını belirtmek için kullandık. Swagger endpoint olarakalgılarsa hata fırlatırdı.
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)    //204 =>NO Content (geriye bir şey dönmeyecek)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }
            return new ObjectResult(response) //status kod ne ise geriye onu dönecek
            {
                StatusCode = response.StatusCode
            };
        }
    }
}

