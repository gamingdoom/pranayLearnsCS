using System;

namespace branchesandloops{
    class branchesandloops{
       public static void Loop(){
        int a = 5;
        int b = 6;
        int c = a+b;
        int whilecount = 0;
        if(c>10){
            Console.WriteLine($"the answer of a and b is greater than 10 it is actually {c}");
         }
         else{
             Console.WriteLine($"the answer is less than 10 it is actually {c}");
         }
         while(whilecount<10){
             Console.WriteLine($"The counter for while loops is at {whilecount} right now!");
             ++whilecount;
         }
         for(int forcount = 0; forcount<10; forcount++){
             Console.WriteLine($"the counter for for loops is at {forcount} right now!");
         }
         for(int row=1; row<11; row++){
             for(char collum = 'a';collum < 'k'; collum++){
                Console.WriteLine($"the cell is ({row}, {collum})");
             }
         }
         Console.WriteLine("I did this to test out for loops");
             int total = 0;
            for(int sum = 0; sum<21;sum++){
                if(sum % 3 == 0){
                total = sum + total;
                }
            }
            Console.WriteLine($"the total of all numbers divisible by 3 between 1 and 20 is {total}");
            Console.WriteLine("press enter to go to the calculator");
            Console.ReadKey();
            calculator.calculator.Calc();
         }
        }
    }
