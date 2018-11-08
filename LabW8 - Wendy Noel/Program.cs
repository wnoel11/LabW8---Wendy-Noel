using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW8___Wendy_Noel
{
    class Program
    {
        static void Main(string[] args)
        {

            //#1 

            int z = 1;
            while (z < 10)
            {
                Console.WriteLine(z);
                z = z + 2;
            }

            //The loop control variable is 'z.' The counter is '+ 2.' The loop terminating 
            //condition is "z <10," when this is statement is no longer true the loop will break.
            //The loop control variable can be modified by changing the statement 'int z = 1;'
            //Changing the '1' will change the value of the loop control variable.

            Console.ReadLine();

            //#2

            {
                int x = 30;
                while (x < 46)
                {
                    Console.WriteLine(x);
                    x = x + 1;

                    if ((x % 2) == 0)
                    {
                        Console.WriteLine("Number is odd.", x);
                    }

                    else
                    {
                        Console.WriteLine("Number is even.", x);
                    }

                }

                Console.ReadLine();
            }

            //#3

            {
                Console.WriteLine("Enter an integer value for the time in the military format (HH00): ");
                Int32 ConvTime = Convert.ToInt32(Console.ReadLine());

                if (ConvTime < 1200)
                {
                    Console.WriteLine("Good Morning");
                }

                else if (ConvTime >= 1200 && ConvTime < 1600)
                {
                    Console.WriteLine("Good Afternoon");
                }

                else
                {
                    Console.WriteLine("Good Evening");
                }

                Console.ReadLine();
            }

            //#4
            //There is no action for the command to execute. 

            int y = 10;
            while (y < 21)
            {
                Console.WriteLine(y);
                y = y + 1;
            }
            Console.ReadLine();

            //#5

            for (int i = 0; i < 101; i++)
                Console.WriteLine(i);
            {
                for (int i = 0; i < 101; i++)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("********");
                }

             }

            Console.ReadLine();

            //#6


            int v, j;
            for (v = 1; v <= 10; v++)
            {
                for (j = 1; j <= v; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }

        
}



}
