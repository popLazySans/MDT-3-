using System;

namespace WeLoveCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBox1 = int.Parse(Console.ReadLine());
            int numberOfBox2 = int.Parse(Console.ReadLine());
            int numberOfBox3 = int.Parse(Console.ReadLine());

            string player ="A";
            int turn = 0;
            bool checkNegative = false;


            while(numberOfBox1 >0 || numberOfBox2 >0 || numberOfBox3 > 0)
            {
                Console.WriteLine("Box 1 : {0}", numberOfBox1);
                Console.WriteLine("Box 2 : {0}", numberOfBox2);
                Console.WriteLine("Box 3 : {0}", numberOfBox3);
                Console.Write("Player {0} Choose Box : ",player);
                int chooseBox = int.Parse(Console.ReadLine());
                Console.Write("How many boxes to take out? : ");
                int numberOut = int.Parse(Console.ReadLine());
                if ((numberOut == 1 || numberOut == 2 )&&((chooseBox==1 && numberOfBox1-numberOut>=0)||(chooseBox == 2 && numberOfBox2 - numberOut >=0)||(chooseBox == 3 && numberOfBox3 - numberOut >=0)))
                { 
                    turn = turn + 1;
                    if (turn % 2 == 1)
                    {
                        player = "B";
                    }
                    else
                    {
                        player = "A";
                    }

                    if (chooseBox == 1)
                    {
                        numberOfBox1 = numberOfBox1 - numberOut;
                    }
                    else if (chooseBox == 2)
                    {
                        numberOfBox2 = numberOfBox2 - numberOut;
                    }
                    else if (chooseBox == 3)
                    {
                        numberOfBox3 = numberOfBox3 - numberOut;
                    }
                }
                else if (chooseBox > 3 || chooseBox < 1)
                {
                    Console.WriteLine("Box {0} not found!!!",chooseBox);
                }
                else
                {
                    Console.WriteLine("{0} is too much!!!! Please try again.",numberOut);
                }
            }
            Console.WriteLine("The Winner is {0}", player);
        }
    }
}
