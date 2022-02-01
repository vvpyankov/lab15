using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IMovable
    {
        void Move();
        void Break();
    }
    class Mercedess : IMovable
    {
        public void Break()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
