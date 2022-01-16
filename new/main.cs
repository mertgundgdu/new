using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{

   public class main
    {
        public void DrawBoard()
        {
            Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[1], f[2], f[3]);
            Console.WriteLine("===================");
            Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[4], f[5], f[6]);
            Console.WriteLine("===================");
            Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[7], f[8], f[9]);
        }

        static string[] f = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        internal void Main(string[] args)
        {
            string player1 = "", player2 = "";
            int choice = 0, turn = 1, score1 = 0, score2 = 0;
            bool winFlag = false, playing = true, correctInput = false;

            Console.WriteLine("Hello! This is Tic Tac Toe.");
            Console.WriteLine("What is the name of player 1?");
            player1 = Console.ReadLine();
            Console.WriteLine("What is the name of player 2?");
            player2 = Console.ReadLine();
            Console.WriteLine("Okay good. {0} is O and {1} is X.", player1, player2);
            Console.WriteLine("{0} goes first.", player1);
            Console.ReadLine();
            Console.Clear();


            while (playing == true)
            {
                while (winFlag == false)
                {
                    DrawBoard();
                    Console.WriteLine("");

                    Console.WriteLine("Score: {0} - {1}     {2} - {3}", player1, score1, player2, score2);
                    if (turn == 1)
                    {
                        Console.WriteLine("{0}'s (O) turn", player1);
                    }
                    if (turn == 2)
                    {
                        Console.WriteLine("{0}'s (X) turn", player2);
                    }

                    while (correctInput == false)
                    {
                        Console.WriteLine("Which sequence would you like to take?");
                        choice = int.Parse(Console.ReadLine());
                        if (choice > 0 && choice < 10)
                        {
                            correctInput = true;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    correctInput = false; // 

                    if (turn == 1)
                    {
                        if (f[choice] == "X")
                        {
                            Console.WriteLine("illegal move! ");
                            Console.Write("Try again.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            f[choice] = "O";
                        }
                    }
                    if (turn == 2)
                    {
                        if (f[choice] == "O")
                        {
                            Console.WriteLine("illegal move! ");
                            Console.Write("Try again.");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            f[choice] = "X";
                        }
                    }


                }

            }
        }
    }
}
