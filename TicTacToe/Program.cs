using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] pos = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            


           static void UserinputX(string[] pos)
            {
            Console.WriteLine("Player X: pick a position (1 through 9) to place your 'X' ");

            int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1)
                {
                    pos[0] = "X";
                }
                else if (answer == 2) { pos[1] = "X"; }
                else if (answer == 3) { pos[2] = "X"; }
                else if (answer == 4) { pos[3] = "X"; }
                else if (answer == 5) { pos[4] = "X"; }
                else if (answer == 6) { pos[5] = "X"; }
                else if (answer == 7) { pos[6] = "X"; }
                else if (answer == 8) { pos[7] = "X"; }
                else if (answer == 9) { pos[8] = "X"; }
                else { Console.WriteLine("invalid position"); }
                PrintBoard(pos);  
            }

            static void UserinputO(string[] pos)
            {
                Console.WriteLine("Player O: pick a position (1 through 9) to place your 'O' ");

                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1)
                {
                    pos[0] = "O";
                }
                else if (answer == 2) { pos[1] = "O"; }
                else if (answer == 3) { pos[2] = "O"; }
                else if (answer == 4) { pos[3] = "O"; }
                else if (answer == 5) { pos[4] = "O"; }
                else if (answer == 6) { pos[5] = "O"; }
                else if (answer == 7) { pos[6] = "O"; }
                else if (answer == 8) { pos[7] = "O"; }
                else if (answer == 9) { pos[8] = "O"; }
                else { Console.WriteLine("invalid position"); }
                PrintBoard(pos);
            }

            // this is a comment
            
            UserinputX(pos);
            Console.ReadLine();
            UserinputO(pos);
            Console.ReadLine();
            UserinputX(pos);
            Console.ReadLine();
            UserinputO(pos);
            Console.ReadLine();
            UserinputX(pos);
            Console.ReadLine();
            UserinputO(pos);
            Console.ReadLine();
            UserinputX(pos);
            Console.ReadLine();
            UserinputO(pos);
            Console.ReadLine();
            UserinputX(pos);
            Console.ReadLine();
            UserinputO(pos);
            Console.ReadLine();


            static void PrintBoard(string[] pos)
            {

                Console.WriteLine("     |     |    ");
                Console.WriteLine("  " + pos[0] + "  |  " + pos[1] + "  |  " + pos[2]);
                Console.WriteLine(" ____|_____|____");
                Console.WriteLine("     |     |    ");
                Console.WriteLine("  " + pos[3] + "  |  " + pos[4] + "  |  " + pos[5]);
                Console.WriteLine(" ____|_____|____");
                Console.WriteLine("     |     |    ");
                Console.WriteLine("  " + pos[6] + "  |  " + pos[7] + "  |  " + pos[8]);
                Console.WriteLine("     |     |    ");
                Console.WriteLine("");

            }
        }
    }
}
