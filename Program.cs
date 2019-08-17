namespace InheritanceFirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            42.Ambulate(17);
            42.Ambulate();
            Util.Ambulate(77, 100);

            new App().Run();
        }
    }
       static class Util

       {
          public static void Ambulate(this int i)
          {
            System.Console.WriteLine($"{i} ambulates with swagger");
          }

           public static void Ambulate (this int i, int steps)
           {
                System.Console.WriteLine($"{i} ambulateswith swagger for {steps}");
           }
        
       }
    
}
        

