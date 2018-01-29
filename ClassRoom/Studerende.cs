using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string _navn;
        public int _fødselsmåned;
        public int _fødselsdag;

        public Studerende(string Navn, int fødselsmåned, int fødselsdag)
        {
            _navn = Navn;
            _fødselsmåned = fødselsmåned;
            _fødselsdag = fødselsdag;
        }

        public string Navn{ get { return _navn; } set { _navn = value; } }
        public int Fødselsmåned { get { return _fødselsmåned; } set { _fødselsmåned = value; } }
        public int Fødselsdag { get { return _fødselsdag; } set { _fødselsdag = value; } }


        public string Årstid(int fødselsmåned)                                        //the reason why the metod is in here, is becouse we easyly can 
        {                                                                             //get the _fødselsmåned.
            if (fødselsmåned == 12 || fødselsmåned == 1 || fødselsmåned == 2)         //and also becouse its some logik that is specifik for a 
            {                                                                         //student
               return ("Vinter");
            }
            if (fødselsmåned == 3 || fødselsmåned == 4 || fødselsmåned == 5)
            {
                return ("forår");
            }
            if (fødselsmåned == 6 || fødselsmåned == 7 || fødselsmåned == 8)
            {
                return ("sommer");
            }
            if (fødselsmåned == 9 || fødselsmåned == 10 || fødselsmåned == 11)
            {
                return ("Efterår");
            }
            return "Måneden eksitere ikke";
        }


        public override string ToString()
        {
            return Navn;
        }
    }
}
