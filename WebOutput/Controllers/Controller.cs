using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace WebOutput.Controllers;

[ApiController]
[Route("")]
public class Controller : ControllerBase
{
    // Windows Command Prompt
    // dir | curl -X POST https://localhost:7019/Data --data-binary @-

    private static readonly Dictionary<string, string> Data = [];

    [NonAction]
    private static string GenerateRandomString(int length = 5)
    {
        var random = new Random();

        // Define the characters that can be used in the random string
        char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        // Create a string builder to store the random string
        var sb = new StringBuilder();

        // Loop through the length and append a random character
        for (int i = 0; i < length; i++)
        {
            // Get a random index from the character array
            int index = random.Next(chars.Length);

            // Append the character at the index to the string builder
            _ = sb.Append(chars[index]);
        }

        // Convert the string builder to a string
        string randomString = sb.ToString();

        return randomString;
    }

    [HttpPost("Data", Name = "Data")]
    public async Task<IActionResult> PostData()
    {
        byte[] buffer = new byte[Request.ContentLength.Value];
        _ = await Request.Body.ReadAsync(buffer);
        string data = Encoding.UTF8.GetString(buffer);
        string url = GenerateRandomString();
        Data.Add(url, data);
        return Ok($"View at https://localhost:7019/Raw/{url}");
    }

    [HttpGet("Raw/{id}")]
    public IActionResult GetRaw(string id) => Ok(Data[id]);
}
