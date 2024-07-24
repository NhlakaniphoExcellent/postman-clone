using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PostmanLibrary;

public class ApiAccess : IApiAccess
{
    // enables you to make a web call
    // used to send HTTP requests and receive responses
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET)
    {
        // fetches data from a web server using an HTTP GET request which is "GetAsync"
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            // this will read the string content from Content and converts into a string
            string Json = await response.Content.ReadAsStringAsync();

            if (formatOutput)
            {
                // converting json string to a Json document
                var DeserilizedJson = JsonSerializer.Deserialize<JsonElement>(Json);

                string prettyJsonFormat = JsonSerializer.Serialize(DeserilizedJson,
                    new JsonSerializerOptions { WriteIndented = true });

                return prettyJsonFormat;
            }

            // raw json file/object
            return Json;
        }
        else
        {
            return $"Error - {response.ReasonPhrase}";
            // eg Error 404/Error 401 etc
        }
    }

    // this method validates the url entered on the Api textbox
    public bool ValidUrl(string Url)
    {
        if (string.IsNullOrWhiteSpace(Url))
        {
            return false;
        }

        // checks if the Url can be parsed as a valid absolute URL using Uri.TryCreate
        // ensures the scheme of the URL is specifically "https"
        bool finalOutput = Uri.TryCreate(Url, UriKind.Absolute, out Uri uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps);

        return finalOutput;
    }
}
