using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class MyArray : IOutput
    {
        public int[] MyArr
        {
            get;
            private set;
        }

        public MyArray(int[] arr)
        {
            MyArr = arr;
        }

        public void Show()
        {
            for (int i = 0; i < MyArr.Length; i++)
            {
                Console.WriteLine($"Array element {i} is: {MyArr[i]}\t");
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info + " It is a MyArray class realization:");
            Show();
        }
    }
}
