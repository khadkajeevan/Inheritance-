using System;

namespace InheritanceFirstSteps
{
    abstract class Mammal
    {
        protected readonly int legs = 4;
        protected readonly double internalTemperature;

        protected readonly string creatureName;

        protected Mammal (string creatureName, double internalTemperature)
        {
            this.creatureName = creatureName;
            this.internalTemperature = internalTemperature;
        }

        protected Mammal(string creatureName, int legs, double internalTemperature)
        {
            this.creatureName = creatureName;
            this.legs = legs;
            this.internalTemperature = internalTemperature;
        }

        public virtual void Eat() // designed to be overridden by derived class
        {
            Console.WriteLine($"{creatureName} eats");
        }
        public virtual void Gestate()
        {
            Console.WriteLine($"{creatureName}gestates");
        }
        public  void Lactate()
        {
            Console.WriteLine($"{creatureName} lectates");
        }
        public virtual void Ambulate()
        {
            Console.WriteLine($"{creatureName} ambulates on {legs} legs");
        }
        public abstract double Sleep(); //has no good implementation so abstract
       
    }
}
