using logoline_CS.Models;
using logoline_CS.Services;
using Microsoft.AspNetCore.Mvc;

namespace logoline_CS.Controllers;

[ApiController]
[Route("[controller]")]

public class LogolineController : ControllerBase
{
    public LogolineController()
    {

    }

    // Get all products
    [HttpGet]
    public ActionResult<Pizza> GetProducts()
    {
        var clientId = "";
        var clientSecret = "";

        var authenticationString = $"{clientId}:{clientSecret}";
        var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));

        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.logoline.com.au/"),
            Headers =
            {
                { "User-Agent", "insomnia/9.2.0" },
                { "Authorization", "Basic " + base64EncodedAuthenticationString },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }

    }
}

