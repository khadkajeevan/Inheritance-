﻿using System;

namespace InheritanceFirstSteps
{
    class Bat : Mammal
    {
        public Bat()
            :base("Bat", 2, 102.5)
        {
        }
        public override void Ambulate()
        {
            Console.WriteLine($"{creatureName} flies from place to place");
        }

        public override double Sleep()
        {
            Console.WriteLine($"{creatureName} sleeps 19.9 hours");
            return 19.9;
        }
    }
}
