using System;
using Xunit;
using ComparingNumbers.Services;

namespace ComparingNumbers.UnitTests.Services
{
    public class ComparingNumbers_IsPrimeShould
    {
        private readonly ComparingNumbersService _comparingNumbers; 
        public ComparingNumbers_IsPrimeShould()
        {
            _comparingNumbers = new ComparingNumbersService();
            //bool result = ComparingNumbers.IsPrime(1);

            //Assert.False(result, "1 should not be prime");
        }
    }
}