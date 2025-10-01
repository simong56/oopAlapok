using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAlapok
{
    public class Szemely
    {
        protected string _nev;
        protected int _eletkor;

        public Szemely(string nev, int kor)
        {
            _nev = nev;
            _eletkor = kor;
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

        public override string ToString()
        {
            return $"A tanuló neve {_nev}, életkora {_eletkor}";
        }

    }

    class Bankszamla
    {
        private int _egyenleg;
        public int Egyenleg
        {
            set
            {
                if (value >= 0) 
                {                     
                    _egyenleg = value;
                }
                else
                {
                    Console.WriteLine("Az egyenleg nem lehet kisebb 0-nál");
                }
            }
        }

        public void Betesz()
        {

        }
        public void Kivesz()
        {
            
        }
    }

    class Hallgato : Szemely
    {
        private string _neptunkod;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Jozsi", 98);

            Console.WriteLine(tanulo1);
            //Console.WriteLine(tanulo1.nev + tanulo1.eletkor);
        }
    }
}
