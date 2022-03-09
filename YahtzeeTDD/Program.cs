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

        public int GetThreeOfAKind(int[] dice)
        {
            Array.Sort(dice);
            int current = 0;
            int count = 0;
            foreach (int die in dice)
            {
                if (current == die)
                {
                    count++;
                    if (count >= 3)
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

        public int GetFourOfAKind(int[] dice)
        {
            throw new NotImplementedException();
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
