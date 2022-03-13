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

        public int Yahtzee(int[] dice)
        {
            var firstDie = dice[0];
            for (int i = 1; i < dice.Length; ++i)
                if (dice[i] != firstDie)
                    return 0;

            return 100;
        }

        public int FullHouse(int[] dice)
        {
            if(Yahtzee(dice) != 0)
                return 25;

            if(GetMultipleOfAKind(dice, 3) == 0)
                return 0;

            Array.Sort(dice);
            int testedDie = dice[0];
            int firstCombinationCount = 1;
            int secondCombinationCount = 1;
            bool testSecondCombination = false;
            for(int i = 1; i < dice.Length; ++i)
            {
                if(dice[i] == testedDie)
                {
                    if(!testSecondCombination)
                        ++firstCombinationCount;
                    else
                        ++secondCombinationCount;
                }
                else if(!testSecondCombination)
                {
                    testedDie = dice[i];
                    testSecondCombination = true;
                }
                else
                    return 0;
            }

            if(firstCombinationCount == 3 && secondCombinationCount == 2
                || firstCombinationCount == 2 && secondCombinationCount == 3)
                return 25;
            else
                return 0;
        }

        public int SmallStraight(int[] dice)
        {
            Array.Sort(dice);
            int testedDie = dice[0];
            int count = 1;
            for(int i = 1; i < 4; ++i)
            {
                var found = Array.Find(dice, d => d == testedDie+1);
                if(found != 0)
                {
                    testedDie = found;
                    ++count;
                }
                else
                {
                    count = 1;
                    testedDie = dice[i];
                }
            }
            if(count >= 4)
                return 30;

            return 0;
        }

        public int LargeStraight(int[] dice)
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
