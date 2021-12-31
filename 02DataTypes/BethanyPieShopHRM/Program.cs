// See https://aka.ms/new-console-template for more information

//int monthlyWage = 1234;
//int months = 12, bonus = 1000;
//bool isActive = true;
//double rating = 99.25;

using System.Text;

DateTime today = DateTime.Now;

Console.WriteLine(today.ToString());
Console.WriteLine(today.ToLongDateString());
Console.WriteLine(today.ToShortTimeString());

string myString = "Hello World";
Console.WriteLine(myString.ToUpper());

string employeeName = "Bethany";
int age = 42;

string greetingText1 = "Hello " + employeeName + ", you are " + age + " years.";
string greetingText2 = string.Format("Hello {0}, you are {1} years.", employeeName, age);
string greetingText3 = $"Hello {employeeName}, you are {age} years.";

Console.WriteLine(greetingText1);
Console.WriteLine(greetingText2);
Console.WriteLine(greetingText3);

string escapedFilePath = "C:\\Documents\\readme.txt";
string escapedFilePath2 = @"C:\Documents\readme.txt";
Console.WriteLine(escapedFilePath, escapedFilePath2);


//Mostrano o uso do StringBuilder, a concatenação abaixo sempre irá criar uma nova cópia da string, consumindo memória.
string indexes = string.Empty;
string indexes2 = string.Empty;

/*
for (int i = 0; i < 2500; i++)
{
  indexes += i.ToString();
}

//String Builder requer o uso do namespace System.Text
StringBuilder builder = new StringBuilder();
for (int i = 0; i < 2500; i++)
{
  builder.Append(i.ToString());
}
indexes2 = builder.ToString();

*/

//Trabalhando com parsing
Console.WriteLine("Digite um valor numérico");
string wage = Console.ReadLine();

//Usando o parse direto
//double wageValue = double.Parse(wage);

double wageValue;
if ( double.TryParse(wage, out wageValue))
{
  Console.WriteLine($"Parsing value {wageValue}");
}
else
{
  Console.WriteLine("Parsing failed");
}




Console.ReadLine();