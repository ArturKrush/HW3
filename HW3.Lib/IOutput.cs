using System;
using System.Threading.Tasks;

namespace Homework3
{
    public interface IOutput
    {
        public void Show(); /*Цей метод обов'язково має бути реалізованим
        у MyArray, якщо MyArray реалізовує цей інтерфейс*/

        public void Show(string info)
        {
            Console.WriteLine(info + "It is an IOutput interface realization:");
            Show();
        }
    }
}
