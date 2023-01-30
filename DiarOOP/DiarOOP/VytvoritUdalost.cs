using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiarOOP
{
    public partial class VytvoritUdalost : Form
    {
        public VytvoritUdalost()
        {
            InitializeComponent();
        }

        public string nazevUdalosti;
        public string popisUdalosti;
        public DateTime zacatek;
        public int delkaUdalosti;
        public int priorita;
        public bool celodenni;

        public void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_prioritaNizka.Checked) priorita = (int)Udalost.PrioritaEnum.nizka;
            else if (radioButton_prioritaStredni.Checked) priorita = (int)Udalost.PrioritaEnum.stredni;
            else priorita = (int)Udalost.PrioritaEnum.vysoka;

            nazevUdalosti = textBox_nazevUdalosti.Text;
            popisUdalosti = textBox_popisUdalosti.Text;
            zacatek = monthCalendar1.SelectionStart;
            delkaUdalosti = (int)numericUpDown_delkaUdalosti.Value;
            celodenni = checkBox_celodenni.Checked;

            // ošetření vstupů pro název události a popis události
            if (nazevUdalosti == "") nazevUdalosti = "Název události";
            if (popisUdalosti == "") popisUdalosti = "Popis události...";

            this.Close();
        }

        private void checkBox_celodenni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_celodenni.Checked)
            {
                numericUpDown_delkaUdalosti.Visible = false;
                label5.Visible = false;
            }
            else
            {
                numericUpDown_delkaUdalosti.Visible = true;
                label5.Visible = true;
            }
        }
    }
}