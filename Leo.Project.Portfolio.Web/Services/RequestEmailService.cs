using System.Net.Http.Json;
using Leo.Project.Portfolio.Web.DataSource;

namespace Leo.Project.Portfolio.Web.Services;

public class RequestEmailService
{
    private readonly HttpClient _httpClient;

    public RequestEmailService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<DataSourceResponse> GetRequestEmails(DataSourceRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync("api/RequestEmail/GetRequestEmails", request);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<DataSourceResponse>();
    }

    public async Task<string> SendEmail(string clientEmail, string subject, string body)
    {
        if (string.IsNullOrEmpty(clientEmail) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(body))
        {
            throw new ArgumentException("All parameters (clientEmail, subject, body) must be provided and non-empty.");
        }

        var query = $"api/RequestEmail/send-email?ClientEmail={Uri.EscapeDataString(clientEmail)}&Subject={Uri.EscapeDataString(subject)}&Body={Uri.EscapeDataString(body)}";

        var response = await _httpClient.PostAsync(query, null);

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}
