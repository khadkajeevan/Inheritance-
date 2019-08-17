using System;
using System.Collections.Generic;

namespace InheritanceFirstSteps
{
    class App
    {
        public void Run()
        {
            var bat = new Bat();
            var human = new Human();
            var cow = new Cow();

            //Mammal mCow = cow;

            //Mammal mBat = bat;

            //cow.Stampede();
            //((Cow)mCow).Stampede();

            //Console.WriteLine($"Bat is bat? {mBat is Bat}");
            //Console.WriteLine($"Bat is cow? {mBat is Cow}");

            var mammals = new List<Mammal>() { bat, human, cow };

            foreach (var mammal in mammals)
            {
                DoMammalStuff(mammal);
            }
        }

        private void DoMammalStuff(Mammal mammal)
        {
            if (mammal is Cow asCow)
            {
                asCow.Stampede();
            }
            else
            {
                mammal.Ambulate();
            }

            if (mammal is Cow)
            {
                    Cow cow = (Cow)mammal;
                    //Cow cow = mammal as Cow;  //same as above
                    cow.Stampede();

            }
             else
             {

               mammal.Ambulate();
             }

                var totalSleep = mammal.Sleep();

                mammal.Eat();
                mammal.Lactate();

                totalSleep += mammal.Sleep();

                Console.WriteLine($"Total hours of sleep {totalSleep}\n");

        }
        


        //DoMammalStuff(bat);
        //DoMammalStuff(human);
        //DoMammalStuff(cow);

    }
}
        

