using System;

namespace MyFirstProgram
{

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

  class Program
  {
    static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Hello World!");
    }
  }
}
