using System;
//importando uma classe específica
//using WeatherUtilities = MyUtilities.WeatherUtilities;

//importando todas as classes
using MyUtilities;

namespace MyFirstProgram
{

  /*
class Temperature
{

  static float FahrenheitToCelsius(float temperatureFahrenheit)
  {

    //Casting usando float na frente da expressão para usar como float
    //float temperatureCelsius = (float)((temperatureFahrenheit - 32) / 1.8);

    //Podemos usar a inferência de tipo utilizando o var invés do tipo já que os outros parâmetros já tem tipo
    var temperatureCelsius = (float)((temperatureFahrenheit - 32) / 1.8f);

    return temperatureCelsius;
  }
}
  */

  class CheckComfort
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Hello World!");

      Console.WriteLine("Where should we go in May?");
      WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
      WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
      WeatherUtilities.Report("São Paulo", 23, 65);

    }
  }
}
