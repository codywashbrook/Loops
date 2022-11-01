using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static bool gameOver; //init
        static int x; //player position
        static int y;//player position
        static void Main(string[] args)
        {
            Console.WriteLine("Loops");
            Console.WriteLine();

            // init
            gameOver = false; // can be true or false

            x = 10;
            y = 10;


            //this is game loop/ can last forever
            while(gameOver == false)
            {
                PlayerUpdate();
                PlayerDraw();
            }

            Console.Clear(); // clears screen
            Console.WriteLine("Game Over");
            Console.ReadKey(true);

        }

        static void PlayerDraw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("@");
        }

        static void PlayerUpdate()
        {
            //read user input
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            //Console.WriteLine(input);
           // Console.WriteLine(input.KeyChar);
            //KeyChar = prints out pressed key Char = one part of a string EX = (G)ameover

            //update player position
            if (input.KeyChar == 'w')
            {
                y = y - 1; // - 1 bc goes down up = minus

            }
            if (input.KeyChar == 's')
            {
                y = y + 1; // - 1 bc goes down up = minus

            }
            if (input.KeyChar == 'a')
            {
                x = x - 1; // - 1 bc goes down up = minus

            }
            if (input.KeyChar == 'd')
            {
                x = x + 1; // - 1 bc goes down up = minus

            }
            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }

            //debug
            //Console.WriteLine("(" + x + "," + y + ")");
        }

    }
}
