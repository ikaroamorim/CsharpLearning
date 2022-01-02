using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShop.HR
{
  public class Employee
  {
    public Employee(string firstName, string last, string em, double? hourRate, DateTime bday, DateTime hDate, Status st)
    {
      //this.firstName = firstName;

      //Using properties
      FirstName = firstName;
      LastName = last;

      Email = em;
      hourlyRate = hourRate ?? 10;
      birthDay = bday;
      hireDate = hDate;
      status = st;
    }

    public Employee(string firstName, string last, string em, double? hourRate, DateTime bday, DateTime hDate) : this(firstName, last, em, hourRate, bday, hDate, Status.Hiring) { }

    protected int id;

    protected static double bonusPercentage = 0.15; //Value will be shared between all objects of the class and the class itself
    protected const double bonusOverPercentage = 0.1; //We never want this to change, is also implicitily static

    protected string firstName;
    public string LastName
    { get; set; }

    protected string email;

    protected Status status;

    protected int numberOfHoursWorked;
    protected double wage;
    protected double hourlyRate;
    protected DateTime birthDay;
    protected DateTime hireDate;

    protected int age;

    public string FirstName
    {
      get;
      set;
    }
    public string Email
    {
      get
      {
        return email;
      }
      set
      {
        email = value;
      }
    }

    public static void SetBonusPercentage( double percentage)
    {
      bonusPercentage = percentage;
    }

    virtual public void PerformWork()
    {
      numberOfHoursWorked++;
      Console.WriteLine($"{FirstName} {LastName} is now Working!!");
    }
  }


}
