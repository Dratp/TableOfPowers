using System;

namespace TableofPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lab 2.2: Table of Powers
            Enter an ineger and display the square and cube of number 1 up to the input in a table
            Made by David Heizer */
            //i < 1291

            int num;
            string cont;
            bool check;
            

            do
            {
                Console.Clear();
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine();

                do
                {
                    num = GetInput();
                } while (!CheckInput(num));

                Console.WriteLine();

                DisplayTable(num);
                Console.WriteLine();

                do
                {
                    Console.Write("Continue? (y/n): ");
                    cont = Console.ReadLine();
                    cont = cont.ToUpper();
                } while (cont != "N" && cont != "Y");
                
            } while (cont != "N");


        }

        static void DisplayTable(int input)
        {
            Console.WriteLine(String.Format("{0,17} {1,17} {2,17}", "Number", "Squared", "Cubed"));
            Console.WriteLine(String.Format("{0,17} {1,17} {2,17}", "=======", "=======", "======="));

            for (int i = 0; i < input;)
            {
                i++;
                int squaredi = i * i;
                int cubedi = squaredi * i;
                
                string num = i.ToString("N0");
                string numsquare = cubedi.ToString("N0");
                string numcubed = cubedi.ToString("N0");

                Console.WriteLine(String.Format("{0,17} {1,17} {2,17}", num, numsquare, numcubed));
            }
        }

        static int GetInput()
        {
            int num = 0;
            bool isValidInput;
            do
            {
                Console.Write("Enter an integer: ");
                isValidInput = int.TryParse(Console.ReadLine(), out num);
            } while (!isValidInput);

            return num;
        }

        static bool CheckInput(int num)
        {
            bool check;
            if (num <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0");
                check = false;
            }
            else if (num > 1290)
            {
                Console.WriteLine("Please choose a number smaller than 1,290");
                check = false;
            }
            else
            {
                check = true;
            }
            return check;
        }

    }
}
