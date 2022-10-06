namespace MinimumCoinAPI.models
{
    public class Calculation
    {
        //Here we use a recursive structure   
        public int countMinCoin(int[] coin, int m, int Y)
        {
            //Here lies the base case, if Y == 0, then 0 coins returned
            if (Y == 0)
                return 0;

            int minCount = int.MaxValue;
            // Here Brute force algorithm with recursion
            for (int i = 0; i < m; i = i + 1)
            {
                if (coin[i] <= Y)
                {
                    int currCount = countMinCoin(coin, m, Y - coin[i]);
                    if (currCount != int.MaxValue && currCount + 1 < minCount)
                        minCount = currCount + 1;
                }

            }
            if (minCount == int.MaxValue)
                return -1;
            else
                return minCount;
        }
        


    }
}
