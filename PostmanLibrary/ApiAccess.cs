using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json;

namespace PostmanLibrary;

public class ApiAccess : IApiAccess
{
    // enables you to make a web call
    // used to send HTTP requests and receive responses
    private readonly HttpClient client = new();
    

    public async Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true)
    {
        StringContent stringContent = new(content, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, stringContent, action, formatOutput);
    }

    public async Task<string> CallApiAsync(string url,HttpContent? content = null, HttpAction action = HttpAction.GET, bool formatOutput = true)
    {
        // fetches data from a web server using an HTTP GET request which is "GetAsync"
        HttpResponseMessage? response;

        switch(action)
        {
            case HttpAction.GET:
                response = await client.GetAsync(url);
                break;
            case HttpAction.POST:
                response = await client.PostAsync(url, content);
                break;
            case HttpAction.PUT:
                response = await client.PutAsync(url, content);
                break;
            case HttpAction.PATCH:
                response = await client.PatchAsync(url, content);
                break;
            case HttpAction.DELETE:
                response = await client.DeleteAsync(url);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action));
        }
        
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
