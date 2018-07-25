using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //random numbers
            string NumberOfSides, UserChoice; //, NumberOfDice;
            UserChoice = "y";
            while (UserChoice == "y")
            {
                Console.WriteLine("How many sides would you like on each die?");
                NumberOfSides = Console.ReadLine();
                NumberOfSides = ValidateInteger(NumberOfSides);

                //Console.WriteLine("How many would you like to roll?");
                //NumberOfDice = Console.ReadLine();
                //NumberOfDice = ValidateInteger(NumberOfDice);

                int Outcome = PlayerRoll(int.Parse(NumberOfSides));
                Console.WriteLine(Outcome);

                Console.WriteLine("Would you like to play again? (y/n)");
                UserChoice = Console.ReadLine();
                UserChoice = ValidateString(UserChoice);
            }
        }
        
        //Validate Integer
        public static string ValidateInteger(string UserInput)
        {
            try
            {
                int.Parse(UserInput);
                return (UserInput);
            }
            catch (Exception)
            {
                return "0";
            }
        }
        public static int PlayerRoll(int UserInput)
        {
            Random rnd = new Random();
            int Roll1 = rnd.Next(1, UserInput);
            int Roll2 = rnd.Next(1, UserInput);
            return Roll1 + Roll2;
        }
        //public static int PlayerRoll2(int NumSides, int NumDice)
        //{
            
        //    for (int i = NumDice-1; i>0; i--)
        //    {
        //        Random rnd = new Random();
        //        return i + rnd.Next(1, NumSides);
                
        //    }
        //    return 1000;
        //}
        public static string ValidateString(string UserInput)
        {
            try
            {
                UserInput = UserInput.ToLower();
                return (UserInput);
            }
            catch (Exception)
            {
                return "0";
            }
        }
    }
}
