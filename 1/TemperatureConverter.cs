
namespace Practics1
{
    public class TemperatureConverter
    {
        public double FahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * 5/9;
        }

        public double CelsiusToFahrenheit(double temperature)
        {
            return temperature * 9/5 + 32;
        }
    }

}
