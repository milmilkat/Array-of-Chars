using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 97;

            char myChar = 'a';

            string[,] strings = new string[3, 3];

            for(int i =0; i < 3; i++)
                for(int j = 0; j < 3; j++)
                {
                    myChar = Convert.ToChar(count);
                    strings[i, j] = myChar.ToString();
                    Console.WriteLine("the character is: " + myChar);
                    count++;
                }

            Console.WriteLine(strings[2, 1]);

            Console.ReadKey();
        }
    }
}
