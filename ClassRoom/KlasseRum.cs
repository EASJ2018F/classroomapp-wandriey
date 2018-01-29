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
                
        }

        public string _KasseNavn { get { return  _KasseNavn; } set { _KasseNavn = value; } }
        public List<Studerende> Klasseliste { get { return _klasseliste; } set { _klasseliste= value; } }
        public DateTime SemesterStart { get { return _semesterStart; } set { _semesterStart = value; } }
    }
}
