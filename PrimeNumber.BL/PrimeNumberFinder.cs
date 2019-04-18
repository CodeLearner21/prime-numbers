using System;

namespace PrimeNumber.BL
{
    public class PrimeNumberFinder
    {
        public bool IsPrimeNumber(int num)
        {
            if(num > 100)
                throw new Exception("value is too large");

            if(num == 1)
                return false;

            var k = 0;

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    k++;
                }
            }    
            if(k == 2)
            {
                return true;
            }
            return false;
        }
    }
}
