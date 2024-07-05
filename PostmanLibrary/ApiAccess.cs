using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PostmanLibrary;

public class ApiAccess
{
    // enables you to make a web call
    // used to send HTTP requests and receive responses
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url)
    {
        // fetches data from a web server using an HTTP GET request which is "GetAsync"
        var response = await client.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            // this will read the string content from Content and converts into a string
            string Json = await response.Content.ReadAsStringAsync();

            // converting json string to a Json document
            var DeserilizedJson = JsonSerializer.Deserialize<JsonElement>(Json);


            string prettyJsonFormat = JsonSerializer.Serialize(DeserilizedJson,
                new JsonSerializerOptions { WriteIndented = true });

            return prettyJsonFormat;
        }
        else
        {
            return $"Error {response.StatusCode}";
            // eg Error 404/Error 401 etc
        }
    }
}
