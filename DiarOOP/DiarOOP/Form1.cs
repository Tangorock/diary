using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DiarOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // list dnů (počet dnů záleží na měsíci)
        List<Den> dny = new List<Den>();

        // pomocná proměnná pro sledování v jákém dni je událost
        public int den = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            button_editovatUdalost.Visible = false;
            button_zrusitSplneniSmazani.Visible = false;
            listBox_udalosti.Visible = true;
            listBox_splneneUdalosti.Visible = false;
            listBox_smazaneUdalosti.Visible = false;

            // vytvoří se list dnů pro aktuální měsíc
            for (int i = 0; i < DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                dny.Add(new Den(DateTime.Today.AddDays(DateTime.Today.Day + i)));
            }
        }

        private void button_novaUdalost_Click(object sender, EventArgs e)
        {
            VytvoritUdalost vytvoritUdalostForm = new VytvoritUdalost();
            vytvoritUdalostForm.ShowDialog();

            // vytvori se nova udalost
            Udalost udalost = new Udalost(vytvoritUdalostForm.nazevUdalosti, vytvoritUdalostForm.popisUdalosti, vytvoritUdalostForm.zacatek, vytvoritUdalostForm.delkaUdalosti, (Udalost.PrioritaEnum)vytvoritUdalostForm.priorita, vytvoritUdalostForm.celodenni);

            // udalost se prida do určitého dne
            dny[vytvoritUdalostForm.zacatek.Day].PridatUdalost(udalost);
            den = vytvoritUdalostForm.zacatek.Day;

            // zapsat udalost do listu 
            listBox_udalosti.Items.Add(udalost);

            // zobrazit Název události v listboxu
            listBox_udalosti.DisplayMember = "NazevUdalosti";
        }

        // práce s UDÁLOSTMA
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button_editovatUdalost.Visible = true;
            button_zrusitSplneniSmazani.Visible = false;
            button_splnitUdalost.Visible = true;
            button_smazatUdalost.Visible = true;

            // nachází se událost v listboxu
            if (listBox_udalosti.SelectedIndex >= 0)
            {
                for (int i = 0; i < dny.Count; i++)
                {
                    // existují ve dne udlosti
                    if (dny[i].Udalosti.Count != 0)
                    {
                        for (int j = 0; j < dny[i].Udalosti.Count; j++)
                        {
                            // událost v listboxu odpovídá události ve dni
                            if (listBox_udalosti.Items[listBox_udalosti.SelectedIndex] == dny[i].Udalosti[j])
                            {
                                den = dny[i].Udalosti[j].Zacatek.Day;

                                Udalost udalost = dny[den].Udalosti[j];

                                // zobrazit informace o události
                                label_nazevUdalosti.Text = udalost.NazevUdalosti;
                                textBox_popisUdalosti.Text = udalost.PopisUdalosti;
                                label_delkaUdalosti.Text = $"Délka události: {udalost.DelkaUdalosti} minut";
                                label_celodenni.Text = udalost.Celodenni ? "Celodenní - ANO" : "Celodenní - NE";

                                // zobrazit zda je událost celodenní
                                if (udalost.Celodenni) label_delkaUdalosti.Visible = false;
                                else label_delkaUdalosti.Visible = true;

                                // zobrazit prioritu události (barvičky)
                                switch (udalost.Priorita)
                                {
                                    case Udalost.PrioritaEnum.nizka:
                                        label_nazevUdalosti.BackColor = Color.Green;
                                        break;
                                    case Udalost.PrioritaEnum.stredni:
                                        label_nazevUdalosti.BackColor = Color.Orange;
                                        break;
                                    case Udalost.PrioritaEnum.vysoka:
                                        label_nazevUdalosti.BackColor = Color.Red;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            else return;
        }

        // práce se SMAZANÝMA UDÁLOSTMA
        private void listBox_smazaneUdalosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button_zrusitSplneniSmazani.Visible = true;
            button_splnitUdalost.Visible = false;
            button_smazatUdalost.Visible = false;

            // nachází se událost v listboxu
            if (listBox_smazaneUdalosti.SelectedIndex >= 0)
            {
                for (int i = 0; i < dny.Count; i++)
                {
                    // existují ve dne udlosti
                    if (dny[i].SmazaneUdalosti.Count != 0)
                    {
                        for (int j = 0; j < dny[i].SmazaneUdalosti.Count; j++)
                        {
                            // událost v listboxu odpovídá události ve dni
                            if (listBox_smazaneUdalosti.Items[listBox_smazaneUdalosti.SelectedIndex] == dny[i].SmazaneUdalosti[j])
                            {
                                den = dny[i].SmazaneUdalosti[j].Zacatek.Day;

                                Udalost udalost = dny[den].SmazaneUdalosti[j];

                                // zobrazit informace o události
                                label_nazevUdalosti.Text = udalost.NazevUdalosti;
                                textBox_popisUdalosti.Text = udalost.PopisUdalosti;
                                label_delkaUdalosti.Text = $"Délka události: {udalost.DelkaUdalosti} minut";
                                label_celodenni.Text = udalost.Celodenni ? "Celodenní - ANO" : "Celodenní - NE";

                                // zobrazit zda je událost celodenní
                                if (udalost.Celodenni) label_delkaUdalosti.Visible = false;
                                else label_delkaUdalosti.Visible = true;

                                // zobrazit prioritu události (barvičky)
                                switch (udalost.Priorita)
                                {
                                    case Udalost.PrioritaEnum.nizka:
                                        label_nazevUdalosti.BackColor = Color.Green;
                                        break;
                                    case Udalost.PrioritaEnum.stredni:
                                        label_nazevUdalosti.BackColor = Color.Orange;
                                        break;
                                    case Udalost.PrioritaEnum.vysoka:
                                        label_nazevUdalosti.BackColor = Color.Red;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            else return;
        }

        // práce s SPLNĚNÝMA UDÁLOSTMA
        private void listBox_splneneUdalosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button_zrusitSplneniSmazani.Visible = true;
            button_splnitUdalost.Visible = false;
            button_smazatUdalost.Visible = false;

            // nachází se událost v listboxu
            if (listBox_splneneUdalosti.SelectedIndex >= 0)
            {
                for (int i = 0; i < dny.Count; i++)
                {
                    // existují ve dne udlosti
                    if (dny[i].SplneneUdalosti.Count != 0)
                    {
                        // událost v listboxu odpovídá události ve dni
                        for (int j = 0; j < dny[i].SplneneUdalosti.Count; j++)
                        {
                            if (listBox_splneneUdalosti.Items[listBox_splneneUdalosti.SelectedIndex] == dny[i].SplneneUdalosti[j])
                            {
                                den = dny[i].SplneneUdalosti[j].Zacatek.Day;

                                Udalost udalost = dny[den].SplneneUdalosti[j];

                                // zobrazit informace o události
                                label_nazevUdalosti.Text = udalost.NazevUdalosti;
                                textBox_popisUdalosti.Text = udalost.PopisUdalosti;
                                label_delkaUdalosti.Text = $"Délka události: {udalost.DelkaUdalosti} minut";
                                label_celodenni.Text = udalost.Celodenni ? "Celodenní - ANO" : "Celodenní - NE";

                                // zobrazit zda je událost celodenní
                                if (udalost.Celodenni) label_delkaUdalosti.Visible = false;
                                else label_delkaUdalosti.Visible = true;

                                // zobrazit prioritu události (barvičky)
                                switch (udalost.Priorita)
                                {
                                    case Udalost.PrioritaEnum.nizka:
                                        label_nazevUdalosti.BackColor = Color.Green;
                                        break;
                                    case Udalost.PrioritaEnum.stredni:
                                        label_nazevUdalosti.BackColor = Color.Orange;
                                        break;
                                    case Udalost.PrioritaEnum.vysoka:
                                        label_nazevUdalosti.BackColor = Color.Red;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            else return;
        }

        // splnit událost
        private void button_splnitUdalost_Click(object sender, EventArgs e)
        {
            // nachází se událost v listboxu
            if (listBox_udalosti.SelectedIndex >= 0)
            {
                // přiřadit do Uálosti "udalost" specifickou událost, na kterou jsme klikli v listboxu
                Udalost udalost = (Udalost)listBox_udalosti.Items[listBox_udalosti.SelectedIndex];

                // označit událost jako splněnou
                udalost.SplnitUdalost(udalost);

                // odstranit událost z listboxu
                listBox_udalosti.Items.Remove(udalost);
                dny[udalost.Zacatek.Day].Udalosti.Remove(udalost);

                // přidat událost do splněných událostí
                listBox_splneneUdalosti.Items.Add(udalost);
                dny[udalost.Zacatek.Day].PridatSplnenouUdalost(udalost);

                // zobrazit Název události v listboxu
                listBox_splneneUdalosti.DisplayMember = "NazevUdalosti";
            }
            else return;
        }

        // smazat událost (událost není splněná, ale smazaná)
        private void button_smazatUdalost_Click(object sender, EventArgs e)
        {
            // nachází se událost v listboxu
            if (listBox_udalosti.SelectedIndex >= 0)
            {
                // přiřadit do Uálosti "udalost" specifickou událost, na kterou jsme klikli v listboxu
                Udalost udalost = (Udalost)listBox_udalosti.Items[listBox_udalosti.SelectedIndex];

                // označit událost jako smazanou
                udalost.SmazatUdalost(udalost);

                // odstranit událost z listboxu
                listBox_udalosti.Items.Remove(udalost);
                dny[udalost.Zacatek.Day].Udalosti.Remove(udalost);

                // přidat událost do smazaných událostí
                listBox_smazaneUdalosti.Items.Add(udalost);
                dny[udalost.Zacatek.Day].PridatSmazanouUdalost(udalost);

                // zobrazit Název události v listboxu
                listBox_smazaneUdalosti.DisplayMember = "NazevUdalosti";
            }
            else return;
        }

        // zobrazit splněné události
        private void button_splneno_Click(object sender, EventArgs e)
        {
            listBox_udalosti.Visible = false;
            listBox_splneneUdalosti.Visible = true;
            listBox_smazaneUdalosti.Visible = false;
            button_editovatUdalost.Visible = false;
            button_zrusitSplneniSmazani.Visible = true;
            button_splnitUdalost.Visible = false;
            button_smazatUdalost.Visible = false;

            button_splneno.BackColor = Color.DarkSlateGray;
            button_smazano.BackColor = Color.FromArgb(225, 225, 225);
            button_udalostiNesplnene.BackColor = Color.FromArgb(225, 225, 225);
        }

        // zobrazit smazané události
        private void button_smazano_Click(object sender, EventArgs e)
        {
            listBox_udalosti.Visible = false;
            listBox_splneneUdalosti.Visible = false;
            listBox_smazaneUdalosti.Visible = true;
            button_editovatUdalost.Visible = false;
            button_zrusitSplneniSmazani.Visible = true;
            button_splnitUdalost.Visible = false;
            button_smazatUdalost.Visible = false;

            button_smazano.BackColor = Color.DarkSlateGray;
            button_splneno.BackColor = Color.FromArgb(225, 225, 225);
            button_udalostiNesplnene.BackColor = Color.FromArgb(225, 225, 225);
        }

        // zobrazit nesplněné/nesmazané události
        private void button_udalostiNesplnene_Click(object sender, EventArgs e)
        {
            listBox_udalosti.Visible = true;
            listBox_splneneUdalosti.Visible = false;
            listBox_smazaneUdalosti.Visible = false;
            button_editovatUdalost.Visible = true;
            button_zrusitSplneniSmazani.Visible = false;
            button_splnitUdalost.Visible = true;
            button_smazatUdalost.Visible = true;

            button_udalostiNesplnene.BackColor = Color.DarkSlateGray;
            button_splneno.BackColor = Color.FromArgb(225, 225, 225);
            button_smazano.BackColor = Color.FromArgb(225, 225, 225);
        }

        // editace události
        private void button_editovatUdalost_Click(object sender, EventArgs e)
        {
            EditovatUdalost editovatUdalostForm = new EditovatUdalost();

            // nachází se událost v listboxu
            if (listBox_udalosti.SelectedIndex >= 0)
            {
                for (int i = 0; i < dny.Count; i++)
                {
                    // existují ve dne udlosti
                    if (dny[i].Udalosti.Count != 0)
                    {
                        for (int j = 0; j < dny[i].Udalosti.Count; j++)
                        {
                            // událost v listboxu odpovídá události ve dni
                            if (listBox_udalosti.Items[listBox_udalosti.SelectedIndex] == dny[i].Udalosti[j])
                            {
                                den = dny[i].Udalosti[j].Zacatek.Day;

                                Udalost udalost = dny[den].Udalosti[j];

                                // přiřadit data do formu EditovatUdalost.cs pro editaci události
                                editovatUdalostForm.nazevUdalosti = udalost.NazevUdalosti;
                                editovatUdalostForm.popisUdalosti = udalost.PopisUdalosti;
                                editovatUdalostForm.zacatek = udalost.Zacatek;
                                editovatUdalostForm.delkaUdalosti = udalost.DelkaUdalosti;
                                editovatUdalostForm.priorita = (int)udalost.Priorita;
                                editovatUdalostForm.celodenni = udalost.Celodenni;

                                // otevřít form EditovatUdalost.cs
                                editovatUdalostForm.ShowDialog();

                                // změnit událost s daty z formu EditovatUdalost.cs                                                                               
                                udalost.NazevUdalosti = editovatUdalostForm.nazevUdalosti;
                                udalost.PopisUdalosti = editovatUdalostForm.popisUdalosti;
                                udalost.Zacatek = editovatUdalostForm.zacatek;
                                udalost.DelkaUdalosti = editovatUdalostForm.delkaUdalosti;
                                udalost.Priorita = (Udalost.PrioritaEnum)editovatUdalostForm.priorita;
                                udalost.Celodenni = editovatUdalostForm.celodenni;

                                // ošetření vstupů pro název události a popis události
                                if (udalost.NazevUdalosti == "") udalost.NazevUdalosti = "Název události";
                                if (udalost.PopisUdalosti == "") udalost.PopisUdalosti = "Popis události...";

                                // zobrazit informace o události
                                label_nazevUdalosti.Text = udalost.NazevUdalosti;
                                textBox_popisUdalosti.Text = udalost.PopisUdalosti;
                                label_delkaUdalosti.Text = $"Délka události: {udalost.DelkaUdalosti} minut";
                                label_celodenni.Text = udalost.Celodenni ? "Celodenní - ANO" : "Celodenní - NE";

                                // zobrazit zda je událost celodenní
                                if (udalost.Celodenni) label_delkaUdalosti.Visible = false;
                                else label_delkaUdalosti.Visible = true;

                                // zobrazit prioritu události (barvičky)
                                switch (udalost.Priorita)
                                {
                                    case Udalost.PrioritaEnum.nizka:
                                        label_nazevUdalosti.BackColor = Color.Green;
                                        break;
                                    case Udalost.PrioritaEnum.stredni:
                                        label_nazevUdalosti.BackColor = Color.Orange;
                                        break;
                                    case Udalost.PrioritaEnum.vysoka:
                                        label_nazevUdalosti.BackColor = Color.Red;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            else return;
        }

        // obnovení smazané nebo splněné události
        private void button_zrusitSplneniSmazani_Click(object sender, EventArgs e)
        {
            int mode = 0;
            if (listBox_smazaneUdalosti.Visible == true) mode = 1;
            else if (listBox_splneneUdalosti.Visible == true) mode = 2;

            switch (mode)
            {
                // zrušit SMAZÁNÍ události
                case 1:
                    // nachází se událost v listboxu
                    if (listBox_smazaneUdalosti.SelectedIndex >= 0)
                    {
                        // přiřadit do Uálosti "udalost" specifickou událost, na kterou jsme klikli v listboxu
                        Udalost udalost = (Udalost)listBox_smazaneUdalosti.Items[listBox_smazaneUdalosti.SelectedIndex];

                        // zrušit smazání události
                        udalost.ZrusitSmazani(udalost);

                        // odstranit událost z listboxu
                        listBox_smazaneUdalosti.Items.Remove(udalost);
                        dny[udalost.Zacatek.Day].SmazaneUdalosti.Remove(udalost);

                        // přidat událost do událostí (NESMAZANÉ)
                        listBox_udalosti.Items.Add(udalost);
                        dny[udalost.Zacatek.Day].PridatUdalost(udalost);

                        // zobrazit Název události v listboxu
                        listBox_udalosti.DisplayMember = "NazevUdalosti";
                    }
                    else return;
                    break;

                // zrušit SPLNĚNÍ události
                case 2:
                    // nachází se událost v listboxu
                    if (listBox_splneneUdalosti.SelectedIndex >= 0)
                    {
                        // přiřadit do Uálosti "udalost" specifickou událost, na kterou jsme klikli v listboxu
                        Udalost udalost = (Udalost)listBox_splneneUdalosti.Items[listBox_splneneUdalosti.SelectedIndex];

                        // zrušit splnení události
                        udalost.ZrusitSplneni(udalost);

                        // odstranit událost z listboxu
                        listBox_splneneUdalosti.Items.Remove(udalost);
                        dny[udalost.Zacatek.Day].SplneneUdalosti.Remove(udalost);

                        // přidat událost do událostí (NESMAZANÉ)
                        listBox_udalosti.Items.Add(udalost);
                        dny[udalost.Zacatek.Day].PridatUdalost(udalost);

                        // zobrazit Název události v listboxu
                        listBox_udalosti.DisplayMember = "NazevUdalosti";
                    }
                    else return;
                    break;
            }
        }
    }
}
