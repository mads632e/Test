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
    private double fuel;
    private double burnRate;
    private double kiloMeters;
    private double timeOfFlight;

    public Rocket(int speed, double fuel)
    {
      Speed = speed;
      Fuel = fuel;
      BurnRate = speed / 50.0;
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

    public double Fuel
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

    public double BurnRate
    {
      get
      {
        return burnRate;
      }

      set
      {
        burnRate = value;
      }
    }

    public void launche()
    {
      while(fuel > burnRate)
      {
        timeOfFlight += 1000 / speed;
        fuel -= burnRate;
        kiloMeters += 1;
        Console.WriteLine($"Height: {kiloMeters}km");
      }
      if(fuel > 0)
      {
        kiloMeters += 1 / (burnRate / fuel);
        Console.WriteLine($"Height: {kiloMeters}km");
      }
      Console.WriteLine($"Hours {timeOfFlight}");
    }

    public override string ToString()
    {
      return $"Flying at: {speed}mph\nRemaining fuel: {fuel}";
    }
  }
}
