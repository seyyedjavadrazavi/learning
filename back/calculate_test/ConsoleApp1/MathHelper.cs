using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MathFormulas : IEnumerable<object[]>
    {
        public bool IsEven(int a) => a % 2 == 0;

        public int Diff(int x, int y) => y - x;

        public int Add(int x, int y) => x + y;

        public int sum(int[] values)
        {
            int sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }

            return sum;
        }

        public int Average(params int[] values)
        {
            int sum = 0;

            foreach (var value in values)
                sum += value;

            return sum / values.Length;
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] {1, 2, 3}
            };

        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1, 2, 3 };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
