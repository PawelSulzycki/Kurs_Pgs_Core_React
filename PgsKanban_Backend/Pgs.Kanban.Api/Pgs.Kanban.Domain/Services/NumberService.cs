using System;
using System.Collections.Generic;
using System.Text;

namespace Pgs.Kanban.Domain.Services
{
    public class NumberService
    {
        private static List<int> _magicNumber = new List<int>();

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
