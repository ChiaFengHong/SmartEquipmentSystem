using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Device Simulator Started...");

        while (true)
        {
            var temp = new Random().Next(20, 100);

            Console.WriteLine($"Temperature: {temp}");

            Thread.Sleep(1000);
        }
    }
}