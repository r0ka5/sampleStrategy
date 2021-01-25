using System;
using System.Collections.Generic;
using System.Linq;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputDate = new DateTime(2021, 10, 1);

            var inputModel = new CalculateFeeModel();

            ICalculate selectedStrategy = SelectStrategy(inputDate);
            var result = selectedStrategy.CalculateSomeFee(inputModel);

            Console.WriteLine(result);
        }

        private static ICalculate SelectStrategy(DateTime date)
        {
            var descendingComparer = Comparer<DateTime>.Create((x, y) => y.CompareTo(x));

            SortedList<DateTime, Func<ICalculate>> strategies = new SortedList<DateTime, Func<ICalculate>>(descendingComparer)
            {
                {new DateTime(2020,1,1), ()=>new CalculateFeeFrom20200101()},
                {new DateTime(2021,1,1), ()=>new CalculateFeeFrom20210101()},
                {new DateTime(2025,1,1), ()=>new CalculateFeeFrom20250101()},
            };

            var key = strategies.Keys.FirstOrDefault(x => date.Date >= x.Date);

            if (key == null)
            {
                throw new NotImplementedException();
            }

            return strategies[key]();
        }
    }

    class DecendingComparer<TKey> : IComparer<DateTime>
    {
        public int Compare(DateTime x, DateTime y)
        {
            return y.CompareTo(x);
        }
    }
}
