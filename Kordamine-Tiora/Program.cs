using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_Tiora
{
    class Program
    {
        static void Main(string[] args)
        {                               //------------5 variant-----------//


            //1.Sisestage klaviatuurilt suvalise pikkusega string ja arvutage ladina tähestiku täishäälikute esinemise protsent stringis(suurtähti ei ole oluline).

             int total = 0;
             var glasnie = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

             Console.WriteLine("Sisestage lause");
             string slova = Console.ReadLine().ToLower();

             for (int i = 0; i < slova.Length; i++)
             {
                 if (glasnie.Contains(slova[i]))
                 {
                     total++;
                 }
             }
             Console.WriteLine("Teie vokaalide koguarv on: {0}", total);

            //2.Esitatakse N elemendi reaalarvude massiiv (kasutage juhuslike arvude generaatorit). Määrake elementide arv, mille väärtused on vahemikus -100 kuni +100

            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                a[i] = r.Next(-100, 100);
                if (a[i] > -100 && a[i] < 100) count++;
            }
            Console.WriteLine("Count {0}", count);

            //3.Kirjutage alamprogramm, mis arvutab kasutaja sisestatud palgalt tulumaksu.

            Console.WriteLine("Sisestage oma palk:"); 
            int palk = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine( $"teie tulumaks{palk} {Alamprogramm.nalog(palk)}");




            Console.ReadLine();
        }


    }
}
