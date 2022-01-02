using BethanyPieShop.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShop
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Teste de console";
      int monthlyWage = 1234;
      int months = 12;

      int yearlyWage = CalculateYearlyWage(monthlyWage, months);

      CalculateYearlyWage((double)monthlyWage, (double)months);

      //Using named params
      CalculateYearlyWage(numberOfMonthsWorked: 36, bonus: 500, monthlyWage: 5000);

      CalculateSum(10.5, 30.9, 11.6);

      EmployeeType employeeType = EmployeeType.Manager;

      EmployeeStruct employee;

      employee.Name = "Ikaro";
      employee.Department = "Development";
      employee.GetPaid();

      Console.WriteLine(int.MaxValue);

      Employee employee1 = new Employee("Ikaro", "Silva", "ikaro.amorim@gmail.com", null, new DateTime(1988, 09, 27), new DateTime(2021,09,10));
      Manager employee2 = new Manager("John", "Green", "ikaro.amorim@gmail.com", null, new DateTime(1988, 09, 27), new DateTime(2021, 09, 10), Status.Employed);

      employee1.PerformWork();
      employee2.PerformWork();

      Console.WriteLine(employee1.ToString());

      Console.ReadLine();
      
    }

    public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
    {
      //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
      return monthlyWage * numberOfMonthsWorked;
    }

    //optional param
    public static void CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus = 1000)
    {
      Console.WriteLine("Yearly Wage: $" + monthlyWage * numberOfMonthsWorked + bonus);
    }

    // using params
    public static void CalculateSum(params double[] values)
    {
      double sum = 0;
      for (int i = 0; i < values.Length; i++)
      {
        sum += values[i];
      }

      Console.WriteLine("Soma: " + sum);
    }

    //using expression body
    public static float CalculateYearlyWage(float monthlyWage, float numberOfMonthsWorked, float bonus = 1000) => monthlyWage * numberOfMonthsWorked + bonus;

    enum EmployeeType
    {
      Operator,
      Manager,
      Director
    }

    struct EmployeeStruct
    {
      public string Name;
      public string Department;

      public void GetPaid()
      {
        Console.WriteLine($"{Name}, seu salário foi pago!");
      }
    }

  }
}
