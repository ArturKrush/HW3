using System;

namespace Homework3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task 1
            int[] array = [ 1, 10, 12, 20, 35 ];
            string info = "After casting to the interface type...";

            MyArray myArray = new(array);

            IOutput outputInterface = myArray;
            outputInterface.Show(); //фактично виклик методу Show() класу MyArray 
            outputInterface.Show(info); /* фактично виклик методу Show(string info)
            класу MyArray, відбувається перекриття реалізації за замовчуванням з інтерфесу */

            //Task 2
            MyArray myArray2 = new(array);

            IMath mathInterface = myArray2;
            Console.WriteLine(mathInterface.Max()); //Результат: 35
            Console.WriteLine(mathInterface.Min()); //Результат: 1
            Console.WriteLine(mathInterface.Avg()); //Результат: 15
            Console.WriteLine(mathInterface.Search(12)); //True

            //Task 3
            int[] unSortedArr = [ 90, 100, 10, 15, 22, 111 ];
            MyArray myArray3 = new(unSortedArr);

            ISort sortInterface = myArray3;
            bool isAsc = true;
            sortInterface.SortByParam(isAsc);

            Console.WriteLine("The view of the array sorted by ascending:");
            myArray3.Show();

            int[] unSortedArr2 = [86, 192, 76, 12, 110, 10];
            MyArray myArray4 = new(unSortedArr2);
            ISort sortInterface2 = myArray4;
            isAsc = false;
            sortInterface2.SortByParam(isAsc);

            Console.WriteLine("The view of the array sorted by descending:");
            myArray4.Show();
        }
    }
}