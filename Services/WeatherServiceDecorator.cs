using System.Threading.Tasks;

public class WeatherServiceDecorator : IWeatherService
{
  protected readonly IWeatherService _innerWeatherService;

  public WeatherServiceDecorator(IWeatherService innerWeatherService)
  {
    _innerWeatherService = innerWeatherService;
  }

  public virtual Task<string> GetWeatherAsync(string cityName)
  {
    return _innerWeatherService.GetWeatherAsync(cityName);
  }
}
