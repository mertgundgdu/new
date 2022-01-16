using System;

namespace newproject
{
 
   public class Program
{

    static string[] f = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    static void DrawBoard()
    {
        Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[1], f[2], f[3]);
        Console.WriteLine("===================");
        Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[4], f[5], f[6]);
        Console.WriteLine("===================");
        Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[7], f[8], f[9]);
    }
    class main
    {
        static void Main(string[] args)
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

                    winFlag = CheckWin();

                    if (winFlag == false)
                    {
                        if (turn == 1)
                        {
                            turn = 2;
                        }
                        else if (turn == 2)
                        {
                            turn = 1;
                        }
                        Console.Clear();
                    }
                }

                Console.Clear();

                DrawBoard();

                for (int i = 1; i < 10; i++)
                {
                    f[i] = i.ToString();
                }

                if (winFlag == false)
                {
                    Console.WriteLine("It's a draw!");
                    Console.WriteLine("Score: {0} - {1}     {2} - {3}", player1, score1, player2, score2);
                    Console.WriteLine("");
                    Console.WriteLine("What would you like to do now?");
                    Console.WriteLine("1. Play again");
                    Console.WriteLine("2. Exit");
                    Console.WriteLine("3. Game About the author");
                    Console.WriteLine("");

                    while (correctInput == false)
                    {
                        Console.WriteLine("Enter your option: ");
                        choice = int.Parse(Console.ReadLine());

                        if (choice > 0 && choice < 4)
                        {
                            correctInput = true;
                        }
                    }

                    correctInput = false;

                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Thanks for playing!");
                            Console.ReadLine();
                            playing = false;
                            break;
                        case 3:
                            Console.WriteLine("Mert Gundogdu " +
                                "mertgndogdu@gmail.com");
                            break;
                    }
                }

                if (winFlag == true)
                {
                    if (turn == 1)
                    {
                        score1++;
                        Console.WriteLine("{0} wins!", player1);
                        Console.WriteLine("What would you like to do now?");
                        Console.WriteLine("1. Play again");
                        Console.WriteLine("2. Exit");
                        Console.WriteLine("3. Game About the author");

                        while (correctInput == false)
                        {
                            Console.WriteLine("Enter your option: ");
                            choice = int.Parse(Console.ReadLine());

                            if (choice > 0 && choice < 4)
                            {
                                correctInput = true;
                            }
                        }

                        correctInput = false;

                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                winFlag = false;
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Thanks for playing!");
                                Console.ReadLine();
                                playing = false;
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("MertGundogdu " +
                                    "mertgndogdu@gmail.com");
                                Console.ReadLine();
                                playing = false;
                                break;
                        }
                    }

                    if (turn == 2)
                    {
                        score2++;
                        Console.WriteLine("{0} wins!", player2);
                        Console.WriteLine("What would you like to do now?");
                        Console.WriteLine("1. Play again");
                        Console.WriteLine("2. Exit");
                        Console.WriteLine("3. Game About the author");

                        while (correctInput == false)
                        {
                            Console.WriteLine("Enter your option: ");
                            choice = int.Parse(Console.ReadLine());

                            if (choice > 0 && choice < 4)
                            {
                                correctInput = true;
                            }
                        }

                        correctInput = false;

                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                winFlag = false;
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Thanks for playing!");
                                Console.ReadLine();
                                playing = false;
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("MertGundogdu " +
                                    "mertgndogdu@gmail.com");
                                Console.ReadLine();
                                playing = false;
                                break;
                        }
                    }
                }
            }
        }
    }
    static bool CheckWin()
    {
        if (f[1] == "O" && f[2] == "O" && f[3] == "O")
        {
            return true;
        }
        else if (f[4] == "O" && f[5] == "O" && f[6] == "O")
        {
            return true;
        }
        else if (f[7] == "O" && f[8] == "O" && f[9] == "O")
        {
            return true;
        }

        else if (f[1] == "O" && f[5] == "O" && f[9] == "O")
        {
            return true;
        }
        else if (f[7] == "O" && f[5] == "O" && f[3] == "O")
        {
            return true;
        }

        else if (f[1] == "O" && f[4] == "O" && f[7] == "O")
        {
            return true;
        }
        else if (f[2] == "O" && f[5] == "O" && f[8] == "O")
        {
            return true;
        }
        else if (f[3] == "O" && f[6] == "O" && f[9] == "O")
        {
            return true;
        }

        if (f[1] == "X" && f[2] == "X" && f[3] == "X")
        {
            return true;
        }
        else if (f[4] == "X" && f[5] == "X" && f[6] == "X")
        {
            return true;
        }
        else if (f[7] == "X" && f[8] == "X" && f[9] == "X")
        {
            return true;
        }

        else if (f[1] == "X" && f[5] == "X" && f[9] == "X")
        {
            return true;
        }
        else if (f[7] == "X" && f[5] == "X" && f[3] == "X")
        {
            return true;
        }

        else if (f[1] == "X" && f[4] == "X" && f[7] == "X")
        {
            return true;
        }
        else if (f[2] == "X" && f[5] == "X" && f[8] == "X")
        {
            return true;
        }
        else if (f[3] == "X" && f[6] == "X" && f[9] == "X")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
}
