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
      Rocket moonRocket = new Rocket(50, 50);
      Rocket marsRocket = new Rocket(25, 150);

      Console.WriteLine(moonRocket.ToString());
      Console.WriteLine(marsRocket.ToString());

      Console.ReadLine();
    }
  }
}
