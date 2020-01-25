using System;

namespace MobileHomeworkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAnswer = 0;
            int menuUserAnswer = 0;

            //Get number from user for times table
            Console.WriteLine("Choose a number between 3 - 9");
            //Convert is a built in operation to parse strings to ints
            userAnswer = Convert.ToInt32(Console.ReadLine());
            
            //Get what type of times table to display
            Console.WriteLine("Choose an option: Flip on" + "\n" + "1) Horizon" + "\n" + "2) Vertical" + "\n" + "3) Diagonal Left" + "\n" + "4) Diagonal Right" + "\n" + "5) To End:");
            menuUserAnswer = Convert.ToInt32(Console.ReadLine());


            if (menuUserAnswer == 1)
            {
                Console.WriteLine("Original Times Table:");
                for (int i = 1; i <= userAnswer; i++)
                {
                    for (int a = 1; a <= userAnswer; a++)
                    {
                        Console.Write(i * a + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Horizontal Flip:");
                for (int i = userAnswer; i >= 1; i--)
                {
                    for (int a = 1; a <= userAnswer; a++)
                    {
                        Console.Write(i * a + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
            //is correct
            else if (menuUserAnswer == 2)
            {
                Console.WriteLine("Original Times Table:");
                for (int i = 1; i <= userAnswer; i++)
                {
                    for (int a = 1; a <= userAnswer; a++)
                    {
                        Console.Write(i * a + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Vertical Flip:");
                for (int i = userAnswer; i >= 1; i--)
                {
                    for (int a = 1; a <= userAnswer; a++)
                    {
                        Console.Write(i * a + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
            else if(menuUserAnswer == 3)
                {
                Console.WriteLine("Original Times Table:");
                for (int i = 1; i <= userAnswer; i++)
                {
                    for (int a = 1; a <= userAnswer; a++)
                    {
                        Console.Write(i* a + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Diagonal Left:");
                for (int i = userAnswer; i >= 1; i--)
                {
                    for (int a = 1; a <= userAnswer; a++)
                    {
                        Console.Write(i* a + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
            //is correct
            else if (menuUserAnswer == 4)
            {
                Console.WriteLine("Original Times Table: ");
                Console.WriteLine("\n");
                for (int i = 1; i <= userAnswer; i++)
                {
                    for (int a = 1; a <= userAnswer; a++)
                    {
                        Console.Write(i* a + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("Diagonal Right");
                Console.WriteLine("\n");
                for (int i = userAnswer; i >= 1; i--)
                {
                    for (int a = userAnswer; a >= 1; a--)
                    {
                        Console.Write(i* a + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
        }

    }
            
}



////running through a loop as many times as its <= to the userAnswer. This loop
////is like the "userAnswer" number
//for (int i = 1; i <= userAnswer; i++)
//{
//    //this loop is the number to multiple by to get the table
//    for(int a = 1; a <= userAnswer; a++)
//    {
//        Console.Write(i * a + "\t");
//    }
//    //This is outside of the second loop bc we don't need a new space until after both loops have run.
//    Console.WriteLine("\n");

