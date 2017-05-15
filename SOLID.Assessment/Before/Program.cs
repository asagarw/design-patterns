using SOLID.Assessment.Before;
using System;

namespace SOLID.Assessment.Before
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new DeviceTests();
            tests.PrintDeviceStatusInDutch();
            Console.ReadLine();
        }
    }
}
