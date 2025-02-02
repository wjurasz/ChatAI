using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ProjektJezykiWebowe;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;
    private readonly string _baseUrl;

    public WeatherService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["WeatherApi:ApiKey"];
        _baseUrl = configuration["WeatherApi:BaseUrl"];
    }

    public async Task<WeatherData?> GetWeatherAsync(string city)
    {
        try
        {
            string url = $"{_baseUrl}/current.json?key={_apiKey}&q={city}&aqi=no";
            Console.WriteLine($"🔵 Wysyłam zapytanie: {url}");

            var response = await _httpClient.GetAsync(url);
            Console.WriteLine($"🟢 Odpowiedź API: {response.StatusCode}");

            if (!response.IsSuccessStatusCode)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"❌ Błąd API: {errorResponse}");
                return null;
            }

            var data = await response.Content.ReadFromJsonAsync<WeatherData>();
            Console.WriteLine($"✅ API zwróciło dane: {data?.Current?.Temp_C}°C");
            return data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Błąd pobierania API: {ex.Message}");
            return null;
        }
    }
}
