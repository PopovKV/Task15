using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();

            arithProgression.setStart(15);            
            arithProgression.getNext();            
            arithProgression.reset();

            geomProgression.setStart(15);
            geomProgression.getNext();
            geomProgression.reset();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);

        void getNext();

        void reset();
    }
    class ArithProgression : ISeries
    {
        public int X { get; set; }
        public int a { get; set; }
        public int x1 { get; set; }
        public void setStart(int x)
        {
            x1 = x;
            X = x;
        }
        public void getNext()
        {
            Console.WriteLine("Введите значение шага прогрессии");
            a=Convert.ToInt32(Console.ReadLine());
            X = X + a;
            Console.WriteLine(X);
        }

        public void reset()
        {
            X = x1;
            Console.WriteLine(X);
        }

        
    }
    class GeomProgression : ISeries
    {
        public int X;
        public int g;
        public int x1;
        public void setStart(int x)
        {            
            x1 = x;
            X = x;
        }
        public void getNext()
        {
            Console.WriteLine("Введите значение шага прогрессии");
            g = Convert.ToInt32(Console.ReadLine());
            X = X * g;
            Console.WriteLine(X);
        }

        public void reset()
        {
            X = x1;
            Console.WriteLine(X);
        }

        
    }
}