namespace BlazorApp2.Pages
{
    public partial class Weather
    {
        private WeatherForecast[]? forecasts;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}