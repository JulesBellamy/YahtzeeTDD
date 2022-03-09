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
            foreach (int die in dice)
            {
                if (die == number) res += die;
            }
            return res;
        }

        public int GetSum(int[] dice)
        {
            int res = 0;
            foreach (int die in dice)
            {
                res += die;
            }
            return res;
        }


        public int GetMultipleOfAKind(int[] dice, int multiple)
        {
            Array.Sort(dice);
            int current = 0;
            int count = 0;
            foreach (int die in dice)
            {
                if (current == die)
                {
                    count++;
                    if (count >= multiple)
                    {
                        return GetSum(dice);
                    }
                }
                else
                {
                    current = die;
                    count = 1;
                }
            }
            return 0;
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
