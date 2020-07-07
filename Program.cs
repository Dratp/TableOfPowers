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
                Console.WriteLine($"Number\t\tSquared\t\tCubed");
                Console.WriteLine($"=======\t\t=======\t\t=======");
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

        static void DisplayTable(int num)
        {
            for (int i = 0; i < num;)
            {
                i++;
                int squaredi = i * i;
                int cubedi = squaredi * i;
                if (squaredi < 1000000)
                {
                    Console.WriteLine($"{i:N0}\t\t{squaredi:N0}\t\t{cubedi:N0}");
                }
                else
                {
                    Console.WriteLine($"{i:N0}\t\t{squaredi:N0}\t{cubedi:N0}");
                }
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
