using System;
using System.Diagnostics;

class Controller { }

class Program
{

  static void Main(string[] args)
  {
    var testController = "Test";
    testController += nameof(Controller);

    Stopwatch sw = new Stopwatch();
    sw.Start();
    for(var i = 0; i < 10000; i += 1)
    {
      var controllerName = testController;
      if( controllerName.EndsWith(nameof(Controller)))
      {
        controllerName = controllerName.Substring(0, controllerName.Length - nameof(Controller).Length);
      }
    }
    sw.Stop();
    Console.WriteLine($"First loop took {sw.ElapsedTicks} ticks");

    sw = new Stopwatch();
    sw.Start();
    for (var i = 0; i < 10000; i += 1)
    {
      var controllerName = testController;
      if (controllerName.EndsWith(nameof(Controller)))
      {
        controllerName = controllerName.Replace(nameof(Controller), string.Empty);
      }
    }
    sw.Stop();
    Console.WriteLine($"Second loop took {sw.ElapsedTicks} ticks");

  }
}