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

            Studerende Jonas = new Studerende("Jonas", 16, 22);
            Studerende Ian = new Studerende("Ian", 06, 23);
            Studerende Kasper = new Studerende("Kasper", 08, 05);
            Studerende Christoffer = new Studerende("Christoffer", 12, 03);
            klasseRumA.Klasseliste.Add(Jonas);
            klasseRumA.Klasseliste.Add(Ian);
            klasseRumA.Klasseliste.Add(Kasper);
            klasseRumA.Klasseliste.Add(Christoffer);

            klasseRumA.Klasseliste.Add(new Studerende("Mads", 06, 3));           //instead og first create and then add
            klasseRumA.Klasseliste.Add(new Studerende("Nikolaj", 12, 03));       //you can do it in one go 
            klasseRumA.Klasseliste.Add(new Studerende("Vicki", 04, 03));


            foreach (var Student in klasseRumA.Klasseliste)
            {
                Console.WriteLine($"{Student.Navn} født d.{Student.Fødselsdag}/{Student.Fødselsmåned} i årstiden {Student.Årstid(Student.Fødselsmåned)} ");                     
            }
            //Console.WriteLine($"Jonas har født i årstiden: {Jonas.Årstid(Jonas.Fødselsmåned)}");   //you can also check it one by one like 



            Console.WriteLine("------------------------");                 //line shift. to make it a little more visualized

            klasseRumA.coutingÅrstider();                                  //Method which can count how many students there are born 
                                                                           //in each Season. 





            Console.ReadLine();                                           //Keep the program running, until a button is pushed.
        }
    }
}
