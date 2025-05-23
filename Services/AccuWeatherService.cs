using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class AccuWeatherService : IWeatherService
{
  private const string ApiKey = "SzTnRICvkfxgzGoWkfrxxwCLRUJNxAdG"; // ПАЛЮ АПИ КЛЮЧ

  private static readonly HttpClient s_httpClient = new();

  public async Task<string> GetWeatherAsync(string cityName)
  {
    try
    {
      string locationRequestUrl = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={ApiKey}&q={cityName}";

      HttpResponseMessage locationResponse = await s_httpClient.GetAsync(locationRequestUrl);

      locationResponse.EnsureSuccessStatusCode();

      string locationJson = await locationResponse.Content.ReadAsStringAsync();

      JsonElement locationsJsonElement = JsonDocument.Parse(locationJson).RootElement;

      if (locationsJsonElement.GetArrayLength() == 0)
      {
        return $"Город {cityName} не найден.";
      }

      string locationKey = locationsJsonElement[0].GetProperty("Key").GetString();

      string weatherRequestUrl = $"http://dataservice.accuweather.com/currentconditions/v1/{locationKey}?apikey={ApiKey}&language=ru-ru";

      HttpResponseMessage weatherResponse = await s_httpClient.GetAsync(weatherRequestUrl);

      weatherResponse.EnsureSuccessStatusCode();

      string weatherJson = await weatherResponse.Content.ReadAsStringAsync();

      JsonElement weatherArrayJsonElement = JsonDocument.Parse(weatherJson).RootElement;

      if (weatherArrayJsonElement.GetArrayLength() == 0)
      {
        return $"Погода для города {cityName} не найдена.";
      }

      JsonElement weatherJsonElement = weatherArrayJsonElement[0];

      string weatherText = weatherJsonElement.GetProperty("WeatherText").GetString();

      double temperatureCelsius = weatherJsonElement
        .GetProperty("Temperature")
        .GetProperty("Metric")
        .GetProperty("Value")
        .GetDouble();

      return $"Погода в {cityName}: {weatherText}, {temperatureCelsius}°C";
    }
    catch (Exception exception)
    {
      return $"Ошибка получения данных о погоде: {exception.Message}";
    }
  }
}
