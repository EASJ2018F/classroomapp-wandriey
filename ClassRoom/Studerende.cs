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

    }
}
