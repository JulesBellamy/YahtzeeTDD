using System;

namespace YahtzeeTDD
{

    public class PointsCalculator
    {
        public PointsCalculator()
        {
            
        }

        public int GetNumbers(int[] dice, int number)
        {
            int res = 0;
            foreach(int die in dice)
            {
                if(die == number) res += die;
            }
            return res;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
