using System;

namespace YahtzeeTDD
{

    public class PointsCalculator
    {
        public PointsCalculator()
        {
            
        }

        public int GetOnes(int[] dice)
        {
            int res = 0;
            foreach(int die in dice)
            {
                if(die == 1) res += die;
            }
            return res;
        }

        public int GetTwos(int[] dice)
        {
            int res = 0;
            foreach (int die in dice)
            {
                if (die == 2) res += die;
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
