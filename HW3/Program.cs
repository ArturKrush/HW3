using System;

namespace Homework3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = [ 1, 10, 12, 20, 35 ];
            string str = "After casting to the interface type...";

            MyArray myArray = new(array);
            //myArray.Show();

            IOutput outputInterface = myArray;
            outputInterface.Show(); //фактично виклик методу Show() класу MyArray 
            outputInterface.Show(str); /* фактично виклик методу Show(string info)
            класу MyArray, відбувається перекриття реалізації за замовчуванням з інтерфесу */
        }
    }
}