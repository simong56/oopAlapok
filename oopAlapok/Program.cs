using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAlapok
{
    public class Szemely
    {
        public string _nev;
        public int _eletkor;

        public Szemely(string nev, int kor)
        {
            _nev = nev;
            _eletkor = kor;
        }
        public string kiiratas()
        {
            return _nev + _eletkor;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Jozsi", 23);
            Console.WriteLine(tanulo1.kiiratas());
        }
    }
}
