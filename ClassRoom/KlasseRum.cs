using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string _klasseNavn;
        public List<Studerende> _klasseliste;
        public DateTime _semesterStart;

        public KlasseRum()
        {
            _klasseliste = new List<Studerende>();
        }

        public string KasseNavn { get { return _klasseNavn; } set { _klasseNavn = value; } }
        public List<Studerende> Klasseliste { get { return _klasseliste; } set { _klasseliste = value; } }
        public DateTime SemesterStart { get { return _semesterStart; } set { _semesterStart = value; } }


        public void coutingÅrstider()
        {
            var Vinterstudents =
            from Studerende in _klasseliste
            where Studerende.Fødselsmåned == 12 || Studerende.Fødselsmåned == 1 || Studerende.Fødselsmåned == 2
            select Studerende;
            
            var Forårstudents =
           from Studerende in _klasseliste
           where Studerende.Fødselsmåned == 3 || Studerende.Fødselsmåned == 4 || Studerende.Fødselsmåned == 5
           select Studerende;
            
            var Sommerstudents =
           from Studerende in _klasseliste
           where Studerende.Fødselsmåned == 6 || Studerende.Fødselsmåned == 7 || Studerende.Fødselsmåned == 8
           select Studerende;

            var Efterårstudents =
           from Studerende in _klasseliste
           where Studerende.Fødselsmåned == 9 || Studerende.Fødselsmåned == 10 || Studerende.Fødselsmåned == 11
           select Studerende;

            Console.WriteLine(Vinterstudents.Count());
            Console.WriteLine(Forårstudents.Count());
            Console.WriteLine(Sommerstudents.Count());
            Console.WriteLine(Efterårstudents.Count());

        }
    }
}
