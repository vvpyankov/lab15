using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ArithProgression arith = new ArithProgression();
            arith.setStart(5);
            arith.setDiff(8);
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.ReadKey();

            GeomProgression geom = new GeomProgression();
            geom.setStart(5);
            geom.setDiff(6);
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.ReadKey();

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
        int diff;
        int firstNum;
        int nextNum;

        public void setStart(int x) // устанавливает начальное значение
        {
            firstNum = x;
            nextNum = firstNum;
        }

        public int getNext() //возвращает следующее число ряда
        {
            nextNum += diff;
            return nextNum;
        }

        public void reset() //выполняет сброс к начальному значению
        {
            nextNum = firstNum;
        }
        public void setDiff(int d)
        {
            diff = d;
        }
    }

    public class GeomProgression : ISeries
    {
        int diff;
        int firstNum;
        int nextNum;

        public int getNext() //возвращает следующее число ряда
        {
            nextNum *= diff;
            return nextNum;
        }
        public void reset() //выполняет сброс к начальному значению
        {
            nextNum = firstNum;
        }
        public void setStart(int x) // устанавливает начальное значение
        {
            firstNum = x;
            nextNum = firstNum;
        }
        public void setDiff(int d)
        {
            diff = d;
        }
    }
}
