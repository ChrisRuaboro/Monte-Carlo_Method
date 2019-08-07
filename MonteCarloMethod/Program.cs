using System;

namespace MonteCarloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int radius = 1;
            RandArray(getNum(), radius);
        }
        public static int getNum()
        {
            int num = 0;
            bool done = false;
            do
            {
                Console.WriteLine("enter number");
                bool success = int.TryParse(Console.ReadLine(), out num);
                if (success)
                {
                    if (num > 0)
                    {
                        done = true;
                    }
                    if (num<=0)
                    {
                        Console.WriteLine("Enter a vaild number");
                    }
                }
                if (!success)
                {
                    Console.WriteLine("Not a number, try again");
                }
                    
            } while (done!=true);
            return num;
        }
        public static double RandArray(int amount, int radius)
        {
            Random r = new Random();
            Coordinate[] randArray = new Coordinate[amount];
            int count = 0;
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = new Coordinate(r);
                if (randArray[i].getHypotenuse() < radius)
                {
                    count++;
                }
            }
            double pi = (double)count / randArray.Length * 4;
            Console.WriteLine($"Count is = {count}");
            double diff = Math.Abs(Math.PI - pi);
            Console.WriteLine($"Difference between estOfPi and Pi = { diff}");
            return diff;

        }
        public struct Coordinate
        {
            double x, y;

            public Coordinate(double X, double Y)
            {
                x = X;
                y = Y;
            }
            public Coordinate(Random r)
            {
                x = r.NextDouble();
                y = r.NextDouble();
            }
            public double getHypotenuse() => Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
        //1.Why do we multiply the value from step 5 above by 4?
        //to account for all four quadrants of a circle since the calculation is done to find only one
        //2.What do you observe in the output when running your program with parameters of increasing size?
        //The difference between estPi and Pi are decreasing
        //3.If you run the program multiple times with the same parameter, does the output remain the same? Why or why not?
        //Does not because of the random points being generated everytime
        //4.Find a parameter that requires multiple seconds of run time.What is that parameter? How accurate is the estimated value of π?
        //100,000,000. The difference is in scientific notation "Difference between estOfPi and Pi = 4.70641020688944E-06"
        //5.Research one other use of Monte-Carlo methods.Record it in your exercise submission and be prepared to discuss it in class.
        //FNMOC used it to find possible locations of an object in the ocean based off weather and time.

    }
}
