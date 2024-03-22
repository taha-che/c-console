using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {

            //taha-che
            int a = 0, b = 0, k = 0;
            string direction = "Right";

            //Random rnd = new Random();

            while (true)
            {
                Console.SetCursorPosition(a, b);
                Console.Write("*");

                //***************************************
                if (direction == "Right")
                    a = a + 1;

                if (direction == "Down")
                    b = b + 1;
                if (direction == "Left")
                    a = a - 1;
                if (direction == "Up")
                    b = b - 1;
                //**************************************
                if ((a == Console.WindowWidth - 1 - k) && direction == "Right")
                    direction = "Down";

                if ((b == Console.WindowHeight - 2 - k) && direction == "Down")
                    direction = "Left";

                if ((a == k) && direction == "Left")
                    direction = "Up";

                if ((b == k) && direction == "Up")
                {
                    direction = "Right";
                    k = k + 1;
                    a = a + 1;
                    b = b + 1;
                }

                //******************************************************

                if (k == Console.WindowHeight / 2)
                    break;

                Thread.Sleep(1);

            }


            Console.ReadKey();
        }
    }
}
