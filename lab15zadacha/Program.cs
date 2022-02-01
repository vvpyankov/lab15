using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
метод void setStart(int x) - устанавливает начальное значение
метод int getNext() - возвращает следующее число ряда
метод void reset() - выполняет сброс к начальному значению
Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.*/

namespace lab15zadacha
{
    class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    class ArithProgression : ISeries
    {
        int x = 0;
        int diff = 5;
        int nextNum;
        public void setStart(int x) // устанавливает начальное значение
        {
            x = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }

        public int getNext() //возвращает следующее число ряда
        {
            int nextNum = x + diff;
            return nextNum;
        }

        public void reset() //выполняет сброс к начальному значению
        {
            int firstNum = nextNum - diff;
        }
    }

    public class GeomProgression : ISeries
    {
        int x = 0;
        int diff = 5;
        int nextNum;

        public void setStart(int x) // устанавливает начальное значение
        {
            x = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }

        public int getNext() //возвращает следующее число ряда
        {
            int nextNum = x * diff;
            return nextNum;
        }
        public void reset() //выполняет сброс к начальному значению
        {
            int firstNum = nextNum / diff;
        }
    }
}
