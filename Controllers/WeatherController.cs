using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Net.Http.Headers;
using System.Text.Json;
using Väder.Models;

namespace Väder.Controllers
{
    public class WeatherController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IMemoryCache _cache;

        public WeatherController(HttpClient httpClient, IMemoryCache cache)
        {
            _httpClient = httpClient;
            _cache = cache;
            _httpClient.DefaultRequestHeaders.UserAgent.Add(
                new ProductInfoHeaderValue("VaderApp", "1.0")
            );
        }

        public async Task<IActionResult> Index()
        {
            string cacheKey = "weather_orebro";

            if (!_cache.TryGetValue(cacheKey, out WeatherForecast? forecast))
            {
                string url = "https://api.met.no/weatherapi/locationforecast/2.0/compact?lat=59.2753&lon=15.2134";

                string json = await _httpClient.GetStringAsync(url);

                forecast = JsonSerializer.Deserialize<WeatherForecast>(json);

                var today = DateTime.UtcNow.Date;
                var tomorrow = today.AddDays(1);

                if (forecast?.Properties?.Timeseries != null)
                {
                    forecast.Properties.Timeseries = forecast.Properties.Timeseries
                        .Where(entry => entry.Time.Date == today || entry.Time.Date == tomorrow)
                        .ToList();
                }

                _cache.Set(cacheKey, forecast, TimeSpan.FromMinutes(30));
            }

            return View(forecast);
        }

    }
}