using System;

namespace InheritanceLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
          TVSets tv1 = new TVSets();
            Radio radio1 = new Radio();
            ElectronicDevice device   = new ElectronicDevice();

            tv1.Brand = "TCL";
            radio1.IsOn = false;
            device.Brand = "Huawei";
            Console.WriteLine("The TV is from {0}",tv1.Brand);
        }
    }
}
