﻿public interface IWeatherService
{
  Task<string> GetWeatherAsync(string cityName);
}
