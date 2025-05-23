using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class OpenWeatherService : IWeatherService
{
  private const string ApiKey = "ab933c0b319d633b984799be5f4edd19"; // ЗДЕСЬ ТОЖЕ ПАЛЮ АПИ КЛЮЧ

  private static readonly HttpClient s_httpClient = new();

  public async Task<string> GetWeatherAsync(string cityName)
  {
    try
    {
      string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={ApiKey}&units=metric&lang=ru";

      HttpResponseMessage httpResponse = await s_httpClient.GetAsync(requestUrl);

      httpResponse.EnsureSuccessStatusCode();

      string jsonResponse = await httpResponse.Content.ReadAsStringAsync();

      using JsonDocument jsonDocument = JsonDocument.Parse(jsonResponse);

      string weatherDescription = jsonDocument.RootElement
        .GetProperty("weather")[0]
        .GetProperty("description")
        .GetString();

      double temperature = jsonDocument.RootElement
        .GetProperty("main")
        .GetProperty("temp")
        .GetDouble();

      return $"Погода в {cityName}: {weatherDescription}, {temperature}°C";
    }
    catch (Exception exception)
    {
      return $"Ошибка получения данных о погоде: {exception.Message}";
    }
  }
}
