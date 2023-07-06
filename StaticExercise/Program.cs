namespace StaticExercise
{
    public class Program
    {
        //Now create a static class called TempConverter. The class should have at least 2 methods,
        //one called FahrenheitToCelsius that will require a double as a
        //parameter and return a double, the other CelsiusToFahrenheit which will also require a double
        //as a parameter and return a double.
        //Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!



        static void Main(string[] args)
        {
            // Call First Method
            Console.WriteLine(" ");
            Console.WriteLine("Please enter Farenheit Temp");
            var temp1 = double.Parse(Console.ReadLine());
            TempConverter.FahrenheitToCelsius(temp1);

            //Call Second Method
            Console.WriteLine(" ");
            Console.WriteLine("Please enter Celsuis Temp");
            var temp2 = double.Parse(Console.ReadLine());
            TempConverter.CelsiusToFahrenheit(temp2);
        }
    }
}
