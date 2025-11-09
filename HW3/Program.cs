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
            //myArray.Show();

            IOutput outputInterface = myArray;
            outputInterface.Show(); //фактично виклик методу Show() класу MyArray 
            outputInterface.Show(info); /* фактично виклик методу Show(string info)
            класу MyArray, відбувається перекриття реалізації за замовчуванням з інтерфесу */


        }
    }
}