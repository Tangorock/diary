using System;

namespace DiarOOP
{
    internal class Udalost
    {
        public string NazevUdalosti { get; set; }
        public string PopisUdalosti { get; set; }
        public DateTime Zacatek { get; set; }
        public int DelkaUdalosti { get; set; }
        public PrioritaEnum Priorita { get; set; }
        public bool Celodenni { get; set; }
        public bool Splneno { get; set; }
        public bool Smazano { get; set; }

        public enum PrioritaEnum
        {
            nizka,
            stredni,
            vysoka
        }

        // konstruktor bez parametrů
        public Udalost()
        {
            NazevUdalosti = "Nová událost";
            PopisUdalosti = "Popis události...";
            Zacatek = DateTime.Today;
            Priorita = PrioritaEnum.nizka;
            Celodenni = false;
            Splneno = false;
            Smazano = false;
        }

        // konstruktor s dvěma parametry
        public Udalost(string nazevUdalosti, DateTime zacatek)
        {
            NazevUdalosti = nazevUdalosti;
            PopisUdalosti = "Popis události...";
            Zacatek = zacatek;
            DelkaUdalosti = 60;
            Priorita = PrioritaEnum.nizka;
            Celodenni = false;
            Splneno = false;
            Smazano = false;
        }

        // konstruktor se všemi parametry
        public Udalost(string nazevUdalosti, string popisUdalosti, DateTime zacatek, int delkaUdalosti, PrioritaEnum priorita, bool celodenni)
        {
            NazevUdalosti = nazevUdalosti;
            PopisUdalosti = popisUdalosti;
            Zacatek = zacatek;
            DelkaUdalosti = delkaUdalosti;
            Priorita = priorita;
            Celodenni = celodenni;
            Splneno = false;
            Smazano = false;
        }

        public void SmazatUdalost(Udalost udalost)
        {
            if (!udalost.Smazano) udalost.Smazano = true;
        }

        public void SplnitUdalost(Udalost udalost)
        {
            if (!udalost.Splneno) udalost.Splneno = true;
        }

        public void ZrusitSmazani(Udalost udalost)
        {
            if (udalost.Smazano) udalost.Smazano = false;
        }

        public void ZrusitSplneni(Udalost udalost)
        {
            if (udalost.Splneno) udalost.Splneno = false;
        }
    }
}
