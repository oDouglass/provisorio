using System;
class Cars
{
  static void Main(string[] args)
  {
    Car civic = new();
    Car celta = new("Chevrolet", "Celta");

    celta.Accelerate();
    celta.Accelerate(3.5f);

    Console.WriteLine(
      celta.Accelerate(1f, true)
    );

    Console.WriteLine(civic.ToString());
    Console.WriteLine(celta.ToString());
  }
}