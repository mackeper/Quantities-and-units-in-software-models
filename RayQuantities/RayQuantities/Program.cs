using System;
using System.Diagnostics;

namespace RayQuantities
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = Length.FromCentimeters(10);
            var duration = Time.FromSeconds(2);
            var velocity = length / duration;

            Debug.Assert(velocity.GetValueInCentimeterPerSeconds() == 5);

            Console.WriteLine(velocity);
            Console.ReadLine();
        }
    }
}
