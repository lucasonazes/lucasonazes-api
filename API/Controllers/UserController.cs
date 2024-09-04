using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<UserModel>> SearchAllUsers()
    {
        return Ok();
    }
}
