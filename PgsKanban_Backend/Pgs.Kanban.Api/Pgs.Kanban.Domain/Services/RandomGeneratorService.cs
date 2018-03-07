using System;
using System.Collections.Generic;
using System.Text;

namespace Pgs.Kanban.Domain.Services
{
    public class RandomGeneratorService
    {
        private Random _randomGenerator = new Random();

        public int GenerateRandomNumber()
        {
            var number = _randomGenerator.Next();
            return number;
        }

        public int GenerateRandomNumber(int maxValue)
        {
            var number = _randomGenerator.Next(maxValue);
            return number;
        }
    }
}
