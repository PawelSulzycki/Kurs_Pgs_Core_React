using System;
using System.Collections.Generic;
using System.Text;

namespace Pgs.Kanban.Domain.Services
{
    public class RandomGeneratorService
    {
        private Random _randomGenerator = new Random();
        private static List<int> _magicNumber = new List<int>();

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

        public void AddNumberToList(int number)
        {
            _magicNumber.Add(number);
        }

        public void DeleteNumber(int number)
        {
            _magicNumber.Remove(number);
        }

        public List<int> GetAllNumbers()
        {
            return _magicNumber;
        }
    }
}
