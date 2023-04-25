using Microsoft.AspNetCore.Mvc;

namespace Myapi.Controllers;


[ApiController]
[Route("[controller]")]
public class UrlController : ControllerBase
{
    // GET
    public IEnumerable<string> Get()
    {
        IList<string> urls = new List<string>();
        urls.Add(item:"http://google");
        urls.Add(item:"http://youtube");
        
        return urls.ToArray();
    }
}