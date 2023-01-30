namespace DiarOOP
{
    partial class EditovatUdalost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_delkaUdalosti = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_celodenni = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_prioritaVysoka = new System.Windows.Forms.RadioButton();
            this.radioButton_prioritaStredni = new System.Windows.Forms.RadioButton();
            this.radioButton_prioritaNizka = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox_popisUdalosti = new System.Windows.Forms.TextBox();
            this.textBox_nazevUdalosti = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_delkaUdalosti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Délka Události (minuty)";
            // 
            // numericUpDown_delkaUdalosti
            // 
            this.numericUpDown_delkaUdalosti.Location = new System.Drawing.Point(18, 257);
            this.numericUpDown_delkaUdalosti.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numericUpDown_delkaUdalosti.Name = "numericUpDown_delkaUdalosti";
            this.numericUpDown_delkaUdalosti.Size = new System.Drawing.Size(146, 20);
            this.numericUpDown_delkaUdalosti.TabIndex = 26;
            this.numericUpDown_delkaUdalosti.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Editovat Událost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Začátek Události";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Popis Události";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Název Události";
            // 
            // checkBox_celodenni
            // 
            this.checkBox_celodenni.AutoSize = true;
            this.checkBox_celodenni.Location = new System.Drawing.Point(22, 393);
            this.checkBox_celodenni.Name = "checkBox_celodenni";
            this.checkBox_celodenni.Size = new System.Drawing.Size(75, 17);
            this.checkBox_celodenni.TabIndex = 20;
            this.checkBox_celodenni.Text = "Celodenní";
            this.checkBox_celodenni.UseVisualStyleBackColor = true;
            this.checkBox_celodenni.CheckedChanged += new System.EventHandler(this.checkBox_celodenni_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton_prioritaVysoka);
            this.groupBox1.Controls.Add(this.radioButton_prioritaStredni);
            this.groupBox1.Controls.Add(this.radioButton_prioritaNizka);
            this.groupBox1.Location = new System.Drawing.Point(15, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 94);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Priorita Události";
            // 
            // radioButton_prioritaVysoka
            // 
            this.radioButton_prioritaVysoka.AutoSize = true;
            this.radioButton_prioritaVysoka.Location = new System.Drawing.Point(7, 66);
            this.radioButton_prioritaVysoka.Name = "radioButton_prioritaVysoka";
            this.radioButton_prioritaVysoka.Size = new System.Drawing.Size(95, 17);
            this.radioButton_prioritaVysoka.TabIndex = 2;
            this.radioButton_prioritaVysoka.Text = "Vysoká Priorita";
            this.radioButton_prioritaVysoka.UseVisualStyleBackColor = true;
            // 
            // radioButton_prioritaStredni
            // 
            this.radioButton_prioritaStredni.AutoSize = true;
            this.radioButton_prioritaStredni.Location = new System.Drawing.Point(7, 43);
            this.radioButton_prioritaStredni.Name = "radioButton_prioritaStredni";
            this.radioButton_prioritaStredni.Size = new System.Drawing.Size(96, 17);
            this.radioButton_prioritaStredni.TabIndex = 1;
            this.radioButton_prioritaStredni.Text = "Střední Priorita";
            this.radioButton_prioritaStredni.UseVisualStyleBackColor = true;
            // 
            // radioButton_prioritaNizka
            // 
            this.radioButton_prioritaNizka.AutoSize = true;
            this.radioButton_prioritaNizka.Checked = true;
            this.radioButton_prioritaNizka.Location = new System.Drawing.Point(7, 19);
            this.radioButton_prioritaNizka.Name = "radioButton_prioritaNizka";
            this.radioButton_prioritaNizka.Size = new System.Drawing.Size(89, 17);
            this.radioButton_prioritaNizka.TabIndex = 0;
            this.radioButton_prioritaNizka.TabStop = true;
            this.radioButton_prioritaNizka.Text = "Nízká Priorita";
            this.radioButton_prioritaNizka.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(15, 70);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 18;
            // 
            // textBox_popisUdalosti
            // 
            this.textBox_popisUdalosti.Location = new System.Drawing.Point(194, 27);
            this.textBox_popisUdalosti.Multiline = true;
            this.textBox_popisUdalosti.Name = "textBox_popisUdalosti";
            this.textBox_popisUdalosti.Size = new System.Drawing.Size(150, 365);
            this.textBox_popisUdalosti.TabIndex = 17;
            this.textBox_popisUdalosti.Text = "Popis události...";
            // 
            // textBox_nazevUdalosti
            // 
            this.textBox_nazevUdalosti.Location = new System.Drawing.Point(15, 25);
            this.textBox_nazevUdalosti.Name = "textBox_nazevUdalosti";
            this.textBox_nazevUdalosti.Size = new System.Drawing.Size(150, 20);
            this.textBox_nazevUdalosti.TabIndex = 16;
            this.textBox_nazevUdalosti.Text = "Název události";
            // 
            // EditovatUdalost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 457);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_delkaUdalosti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_celodenni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox_popisUdalosti);
            this.Controls.Add(this.textBox_nazevUdalosti);
            this.Name = "EditovatUdalost";
            this.Text = "EditovatUdalost";
            this.Load += new System.EventHandler(this.EditovatUdalost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_delkaUdalosti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_delkaUdalosti;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_celodenni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_prioritaVysoka;
        private System.Windows.Forms.RadioButton radioButton_prioritaStredni;
        private System.Windows.Forms.RadioButton radioButton_prioritaNizka;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox_popisUdalosti;
        private System.Windows.Forms.TextBox textBox_nazevUdalosti;
    }
}