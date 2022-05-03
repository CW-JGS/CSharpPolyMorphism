using System;
namespace PolymorphismAssigment
{
    class ElectricEngine: Engine
    {
        public string BatteryType {get;}
        public ElectricEngine():base() {

        }
        public ElectricEngine(string pBatteryType, int pHorsePower, int pEnergyStoreMaxSize):base(pHorsePower, pEnergyStoreMaxSize) {
            this.BatteryType = pBatteryType;
        }
        public override void Rev()
        {
            if (CurrentEnergyStore > 0) {
                System.Console.WriteLine("SWWIIIISSSSHHH!");
                CurrentEnergyStore = CurrentEnergyStore-= 1;
            } else {
                System.Console.WriteLine("FLAT BATTERY");
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
            System.Console.WriteLine("RECHARGED TO FULL");
        }
        public override void Refuel(int j)
        {
            if (CurrentEnergyStore + j >= EnergyStoreMaxSize)
            {
                Refuel();
            } else {
                CurrentEnergyStore += j;
                System.Console.WriteLine("RECHARGED {0} AMP HOURS",j);
            }
        
        }
    }
}