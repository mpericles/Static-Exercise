using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        
        {
            // Formula : °C = 5/9(°F – 32
            // Example Given, F = 80°|| Using the formula, °C = 5/9(°F – 32) ||
            // C = 5/9(80 – 32) || C = 26.67°C || Hence, 80°F = 26.67°C

            // Convert Fahrenheit to Celsius
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} Farenheit is {celsius} Celsuis");
            return celsius;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            // Formula : (0°C × 9/5) + 32 = 32°F
            // Example : (50°F - 32) x .5556 = 10°C
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} Celsuis is {fahrenheit} Farenheit");
            return fahrenheit ;
        }
    }
}
