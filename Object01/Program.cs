using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object01
{
    class Ember
    {
        public string nev;
        public int eletkor;

        public string Bemutatkozas()
        {
            
            return nev + ", függő, " + eletkor + " éves";
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ember pisti = new Ember();
            Ember eva = new Ember();
            pisti.nev = "Nagy Pista";
            pisti.eletkor = 20;
            eva.nev = "Nagy Éva";
            eva.eletkor = 18;

            
            pisti.eletkor++;

            Console.WriteLine(pisti.Bemutatkozas());

            Console.ReadKey();

        }
    }
}
