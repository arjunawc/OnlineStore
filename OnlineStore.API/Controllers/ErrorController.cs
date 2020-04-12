using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.Errors;

namespace OnlineStore.API.Controllers
{
    [Route("errors/{code}")]
    public class ErrorController : BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}
