using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAlapok
{
    public class Szemely
    {
        public string _nev = "Nagy Jozsef";
        public int _eletkor = 90;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            Console.WriteLine(tanulo1._nev);
            Console.WriteLine(tanulo1._eletkor);
        }
    }
}
