using System;
namespace PolymorphismAssigment
{
    class InternalCombustionEngine: Engine
    {
        public string FuelType {get;}
        public InternalCombustionEngine():base() {

        }
        public InternalCombustionEngine(string pFuelType, int pHorsePower, int pEnergyStoreMaxSize):base(pHorsePower, pEnergyStoreMaxSize) {
            this.FuelType = pFuelType;
        }
        public override void Rev()
        {
            if (CurrentEnergyStore > 0) {
                System.Console.WriteLine("VROOOOMMMM!");
                CurrentEnergyStore = CurrentEnergyStore-= 1;
            } else {
                System.Console.WriteLine("OUT OF FUEL");
                return;
            }
        }
        public override void Rev(int j)
        {
            for (int i = 0; i <j; i++) {
                Rev();
            }
        }
        public override void Refuel()
        {
            CurrentEnergyStore = EnergyStoreMaxSize;
            System.Console.WriteLine("REFUELED TO FULL");
        }
        public override void Refuel(int j)
        {
            if (CurrentEnergyStore + j >= EnergyStoreMaxSize)
            {
                Refuel();
            } else {
                CurrentEnergyStore += j;
                System.Console.WriteLine("REFUELLED {0} LITRES",j);
            }
        
        }
    }
}