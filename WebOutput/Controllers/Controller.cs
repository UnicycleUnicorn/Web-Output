using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebOutput.Controllers;

[ApiController]
[Route("")]
public class Controller : ControllerBase
{
    [HttpPost("Data", Name = "Data")]
    //[Authorize]
    public async Task<IActionResult> PostData()
    {
        byte[] buffer = new byte[Request.ContentLength.Value];

        _ = await Request.Body.ReadAsync(buffer);
        string data = Encoding.UTF8.GetString(buffer);

        string url = Application.UrlGenerator.GenerateNewUrl();

        if (Application.OutputStore.Store(url, data))
        {
            return Ok($"View at {Application.BaseUrl}/Raw/{url}");
        }
        else
        {
            return StatusCode(500, "Output data could not be stored");
        }
    }

    [HttpGet("Raw/{id}")]
    //[Authorize]
    public IActionResult GetRaw(string id)
    {
        if (Application.OutputStore.Retrieve(id, out string? data))
        {
            return Ok(data!);
        }
        else
        {
            return NotFound("Data is not associated with this url");
        }
    }
}
