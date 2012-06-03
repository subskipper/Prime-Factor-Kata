using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeKata
{
    public class PrimeFinder
    {
        public IList<int> FindPrimeFactors(int number)
        {
            int divisor = 2;
            var primeList = new List<int>();

            while (divisor <= number)
            {
                if (number % divisor == 0)
                {
                    primeList.Add(divisor);
                    number /= divisor;
                }
                else
                    divisor++;
            }

            return primeList;
        }
    }
}
