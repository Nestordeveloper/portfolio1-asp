using Microsoft.AspNetCore.Mvc;
namespace ProjectName.Controllers;
public class HelloController : Controller
{
    // Route declaration Option A
    // This will go to "localhost:5XXX"
    [HttpGet]
    [Route("index")]
    public string Index()
    {
        return "Hello from the index";
    }
    [HttpGet]
    [Route("projects")]
    public string Projects()
    {
        return "Hello from the Projects Route!";
    }
    [HttpGet]
    [Route("contacts")]
    public string Contacts()
    {
        return "Hello from the Contacts Route!";
    }
}