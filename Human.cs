using System;

namespace InheritanceFirstSteps
{
    class Human : Mammal
    {
      

        public Human()
            :this(98.6)
        {

        }
        protected Human(double bodyTemp) //only allows derived class to change values
               : base("Human", 2, 98.6)
        {

        }

        public override double Sleep() //for virtual or abstract method parent class
        {
            Console.WriteLine("Human Sleeps 8 hours");
            return 8.0;
        }

        class Ginger : Human
        {
            public Ginger()
                :base(92.0)
            {

            }
        }
    }
}
