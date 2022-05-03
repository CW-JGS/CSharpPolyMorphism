using System;

namespace PolymorphismAssigment
{
    abstract class Engine 
    {
        public int HorsePower {get;}
        public int EnergyStoreMaxSize {get;}
        public int CurrentEnergyStore {get;set;}
        public Engine () {}
        public Engine(int  pHorsePower, int pEnergyStoreMaxSize) {
            this.HorsePower = pHorsePower;
            EnergyStoreMaxSize = pEnergyStoreMaxSize;
            CurrentEnergyStore = pEnergyStoreMaxSize;
        }
        abstract public void Rev();
        abstract public void Rev(int i);
        abstract public void Refuel();
        abstract public void Refuel(int i);

    }
}