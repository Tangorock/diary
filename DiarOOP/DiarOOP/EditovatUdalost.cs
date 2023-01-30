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
    public partial class EditovatUdalost : Form
    {
        public EditovatUdalost()
        {
            InitializeComponent();
        }

        public string nazevUdalosti;
        public string popisUdalosti;
        public DateTime zacatek;
        public int delkaUdalosti;
        public int priorita;
        public bool celodenni;

        // vypsat parametry události do formu
        private void EditovatUdalost_Load(object sender, EventArgs e)
        {
            textBox_nazevUdalosti.Text = nazevUdalosti;
            textBox_popisUdalosti.Text = popisUdalosti;
            monthCalendar1.SelectionStart = zacatek;
            numericUpDown_delkaUdalosti.Value = delkaUdalosti;

            if (priorita == 0) radioButton_prioritaNizka.Checked = true;
            else if (priorita == 1) radioButton_prioritaStredni.Checked = true;
            else radioButton_prioritaVysoka.Checked = true;

            if (celodenni) checkBox_celodenni.Checked = true;
            else checkBox_celodenni.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_prioritaNizka.Checked) priorita = (int)Udalost.PrioritaEnum.nizka;
            else if (radioButton_prioritaStredni.Checked) priorita = (int)Udalost.PrioritaEnum.stredni;
            else priorita = (int)Udalost.PrioritaEnum.vysoka;

            nazevUdalosti = textBox_nazevUdalosti.Text;
            popisUdalosti = textBox_popisUdalosti.Text;
            zacatek = monthCalendar1.SelectionStart;
            delkaUdalosti = (int)numericUpDown_delkaUdalosti.Value;
            celodenni = checkBox_celodenni.Checked;

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
