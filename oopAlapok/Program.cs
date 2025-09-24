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

        public Szemely(string nev)
        {
            _nev = nev;
        }

        public string nev
        {
            get { return _nev; }
            //set { _nev = value; }
        }

        public int eletkor
        {
            get { return _eletkor; }
            set
            {
            if(value>=0) 
                {
                    _eletkor = value;
                }
            else
                {
                    Console.WriteLine("Hibás érték");
                }
            }
            
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Jozsi");
            tanulo1.eletkor = 40;
            Console.WriteLine(tanulo1.nev + tanulo1.eletkor);
        }
    }
}
