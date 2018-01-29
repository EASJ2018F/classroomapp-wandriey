using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRumA = new KlasseRum();
            klasseRumA.KasseNavn = "3A";
            klasseRumA.SemesterStart = DateTime.Now;             // will give the date of today.

            Console.WriteLine($"Semester start er: {klasseRumA.SemesterStart}");   //Checking the data is set. 

            klasseRumA.Klasseliste.Add(new Studerende("Jonas", 06, 22));
            klasseRumA.Klasseliste.Add(new Studerende("Ian", 06, 23));
            klasseRumA.Klasseliste.Add(new Studerende("Kasper", 08, 05));
            klasseRumA.Klasseliste.Add(new Studerende("Christoffer", 02, 3));

            foreach (var item in klasseRumA.Klasseliste)
            {
                Console.WriteLine(item);                          //making sure our students are properly created 
            }

            Console.ReadLine();
         
        }
    }
}
