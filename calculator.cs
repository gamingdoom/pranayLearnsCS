using System;

    namespace calculator{
        class calculator{
        public static void Calc(){
            Console.WriteLine("Welcome to the calculator please input an integer here:");
            string rawnumone = Console.ReadLine();
            int numone = Convert.ToInt32(rawnumone); 
            Console.WriteLine($"Great! You entered {numone}! Now what operator do you want to use?");
            string operate = Console.ReadLine();
            Console.WriteLine($"Great! You inputted {operate}! Now input another integer here:");
            string rawnumtwo = Console.ReadLine();
            int numtwo = Convert.ToInt32(rawnumtwo);
            int answer = 0;
            if(operate == "+"){
                answer = numone + numtwo;
            }
            if(operate == "-"){
                answer = numone-numtwo;
            }
            if(operate == "*"){
                answer = numone * numtwo;
            }
            if(operate == "/"){
                answer = numone / numtwo;
            }
            Console.WriteLine($"Ok! We are done calculating and your answer is {answer}!");
            Console.WriteLine("If you would like to do more calculations please press y otherwise just press enter.");
            if(Console.ReadKey().Key == ConsoleKey.Y){
                      Calc();          
             }
             Console.WriteLine("press enter to go to the next thing");
             Console.ReadKey();
             hewowold.Math.Main();
    }
  }
}