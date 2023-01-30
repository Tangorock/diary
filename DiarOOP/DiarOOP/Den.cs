using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarOOP
{
    internal class Den
    {
        public List<Udalost> Udalosti = new List<Udalost>();
        public List<Udalost> SplneneUdalosti = new List<Udalost>();
        public List<Udalost> SmazaneUdalosti = new List<Udalost>();

        public DateTime Datum { get; set; }

        public Den()
        {
            Datum = DateTime.Now;
        }

        public Den(DateTime datum)
        {
            Datum = datum;
        }

        public void PridatUdalost(Udalost udalost)
        {
            Udalosti.Add(udalost);
        }

        public void PridatSplnenouUdalost(Udalost udalost)
        {
            SplneneUdalosti.Add(udalost);
        }

        public void PridatSmazanouUdalost(Udalost udalost)
        {
            SmazaneUdalosti.Add(udalost);
        }
    }
}
