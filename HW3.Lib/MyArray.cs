using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class MyArray : IOutput, IMath
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

        public int Max()
        {
            int max = MyArr[0];
            for (int i = 1; i < MyArr.Length; i++)
            {
                if (MyArr[i] > max)
                    max = MyArr[i];
            }
            return max;
        }

        public int Min()
        {
            int min = MyArr[0];
            for (int i = 1; i < MyArr.Length; i++)
            {
                if (MyArr[i] < min)
                    min = MyArr[i];
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < MyArr.Length; i++)
            {
                sum += MyArr[i];
            }
            return sum/MyArr.Length;
        }

        /*Оскільки пошук може відбуватися як в відсортованому, так і в невідсортованому масиві
        то знайти елемент швидше за O(n) за допомогою бінарного пошуку не вдасться,
        так як попередньо треба відсортувати масив*/
        public bool Search(int valueToSearch)
        {
            foreach (int item in MyArr)
            {
                if(item == valueToSearch)
                    return true;
            }
            return false;
        }
    }
}
