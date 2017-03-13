using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Gethub.Test
{
  class Rocket
  {
    private int speed;
    private int fuel;

    public Rocket(int speed, int fuel)
    {
      Speed = speed;
      Fuel = fuel;
    }

    public int Speed
    {
      get
      {
        return speed;
      }

      set
      {
        speed = value;
      }
    }

    public int Fuel
    {
      get
      {
        return fuel;
      }

      set
      {
        fuel = value;
      }
    }

    public override string ToString()
    {
      return $"Flying at: {speed}mph\nRemaining fuel: {fuel}";
    }
  }
}
