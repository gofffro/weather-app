
namespace weather_app
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private async void GetWeatherButton_Click(object sender, EventArgs eventArgs)
    {
      string cityName = CityTextBox.Text;
      string selectedServiceName = ServiceComboBox.Text;

      IWeatherService weatherService = selectedServiceName switch
      {
        "OpenWeather" => new OpenWeatherService(),
        "AccuWeather" => new AccuWeatherService(),
        _ => null
      };

      if (weatherService != null)
      {
        WeatherResultLabel.Text = "Загрузка...";

        string weatherInformation = await weatherService.GetWeatherAsync(cityName);

        WeatherResultLabel.Text = weatherInformation;
      }
      else
      {
        WeatherResultLabel.Text = "Сервис не выбран.";
      }
    }
  }
}
