using System;

namespace PolymorphismAssigment
{
    class Program 
    {
        static void Main(string[] args)
        {
            Engine v6LS = new InternalCombustionEngine("Unleaded", 600, 60);
            Engine telsa = new ElectricEngine("L-ION", 600, 120);
            v6LS.Rev();
            v6LS.Refuel(1);
            v6LS.Rev(45);
            v6LS.Refuel(40);
            telsa.Rev();
            telsa.Refuel(1);
            telsa.Rev(45);
            telsa.Refuel(40);
            
        }
    }
}