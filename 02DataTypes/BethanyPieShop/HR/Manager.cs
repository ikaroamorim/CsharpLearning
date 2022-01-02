using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShop.HR
{
  //sealed significa que nenhuma classe pode herdar de Manager
  public sealed class Manager : Employee
  {
    public Manager(string firstName, string last, string em, double? hourRate, DateTime bday, DateTime hDate, Status st) : base(firstName, last, em, hourRate, bday, hDate, st)
    {
    }

    public override void PerformWork()
    {
      numberOfHoursWorked++;
      Console.WriteLine($"Be careful the manager {FirstName} {LastName} is now Working!!");
    }
  }
}
