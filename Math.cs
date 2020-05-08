using System;

namespace hewowold
{
    class Math{
        public const double Pi = 3.141592653589793238462643383;

        //static void main is needed at the begining of stuff to make it work
       public static void Main(){
            //integers are just numbers
       int a = 11;
       int b = 34;
       int c = a % b;
       int d = a / b;
       int max = int.MaxValue;
       int min = int.MinValue;
       int oof = max+3;
       //this is how you write stuff
       Console.WriteLine(c);
       Console.WriteLine($"quotient = {d} remainder = {c}");
       Console.WriteLine($"max limit = {max} min limit = {min}");
       Console.WriteLine($"overflow aka oof = {oof}");
       //doubles are more precise integers capable of decimals
       double e = 11;
       double f = 56;
       double g = 45;
       double h = (e+f)/g;
       double mind = Double.MinValue;
       double maxd = Double.MaxValue;
       double urbad = 1.0/3.0;
       Console.WriteLine($"this is she value of (11+56)/45 {h}");
       Console.WriteLine($"the min value is {mind} and the max value is {maxd}");
       Console.WriteLine($"HaHa i can make my computer do math wrong see 1.0/3.0 = {urbad}(well its not really wrong)");
       //decimal is even more precise than doubles
       decimal i = 1.0M;
       decimal j = 3.0M;
       Console.WriteLine(i/j);
       //here is me calculating the area of a 2.5 cm radius circle
       double rad = 2.5;
       double pI= Pi;
       double area = (rad*rad)*pI;
       Console.WriteLine($"this is the area of a 2.5 radius circle {area}");
       //here i decided to just mess around and make a loop that increments to 10 and stops
       int k = 0;
       while (k != 10){
         if(k != 10){
             ++k;
             Console.WriteLine(k);
         }

        }
        Console.WriteLine("Press enter to see my experience with Branches and Loops");
        Console.ReadKey();
       branchesandloops.branchesandloops.Loop();
       Console.ReadLine();

        
    }
    
    }
}

