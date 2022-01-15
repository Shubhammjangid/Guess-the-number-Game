using System;

namespace GuessNum{

	class Func{
		public void Hero(){
			Console.WriteLine("Welcome to game Guess the Number ");
            Console.WriteLine("If you want to play game enter 1 else 0 to exit");
            string? userRep = Console.ReadLine();
            int tNum = Convert.ToInt32(userRep);
            bool Value = false;
            Random rnd = new Random();
            int Target = rnd.Next(11);
            int Try = 0;
            if(tNum==1){
            	while(!Value){
            		Console.WriteLine("Guess the number between 1 to 10");
            		string? guessNum = Console.ReadLine();
            		int realNum = Convert.ToInt32(guessNum);
            		if(Target==realNum){
            			Console.WriteLine($"Yay, you have won the game and taken {Try} try to win the game");
            			Value=true;
            		}
            		else{
            			Console.WriteLine("Try guessing the Number");
            			Try++;
            		}
            	}
            }

            else{
            	Console.WriteLine("Thankyou for visiting us");
            }
		}
	}


}