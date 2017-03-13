using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Gethub.Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();
      List<Rocket> rockets = new List<Rocket>(0);
      for(int i = 0; i < 5; i++)
      {
        rockets.Add(new Rocket(rnd.Next(1, 1000), rnd.Next(1, 1000)));
      }
      foreach(Rocket r in rockets)
      {
        Console.WriteLine();
        Console.WriteLine(r.ToString());
        Console.WriteLine("\nPress any key to start flight.");
        Console.ReadKey();
        r.launche();
      }

      Console.ReadLine();
    }
  }
}
