namespace DiarOOP
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label_celodenni = new System.Windows.Forms.Label();
            this.label_delkaUdalosti = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_popisUdalosti = new System.Windows.Forms.TextBox();
            this.label_nazevUdalosti = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_smazaneUdalosti = new System.Windows.Forms.ListBox();
            this.listBox_splneneUdalosti = new System.Windows.Forms.ListBox();
            this.listBox_udalosti = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_udalostiNesplnene = new System.Windows.Forms.Button();
            this.button_smazano = new System.Windows.Forms.Button();
            this.button_splneno = new System.Windows.Forms.Button();
            this.button_novaUdalost = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_editovatUdalost = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_zrusitSplneniSmazani = new System.Windows.Forms.Button();
            this.button_splnitUdalost = new System.Windows.Forms.Button();
            this.button_smazatUdalost = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label_nazevUdalosti);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(600, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label_celodenni);
            this.groupBox6.Controls.Add(this.label_delkaUdalosti);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 382);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(194, 65);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // label_celodenni
            // 
            this.label_celodenni.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_celodenni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_celodenni.Location = new System.Drawing.Point(2, 43);
            this.label_celodenni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_celodenni.Name = "label_celodenni";
            this.label_celodenni.Size = new System.Drawing.Size(190, 23);
            this.label_celodenni.TabIndex = 1;
            this.label_celodenni.Text = "Celodenní -";
            // 
            // label_delkaUdalosti
            // 
            this.label_delkaUdalosti.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_delkaUdalosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delkaUdalosti.Location = new System.Drawing.Point(2, 15);
            this.label_delkaUdalosti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_delkaUdalosti.Name = "label_delkaUdalosti";
            this.label_delkaUdalosti.Size = new System.Drawing.Size(190, 28);
            this.label_delkaUdalosti.TabIndex = 0;
            this.label_delkaUdalosti.Text = "Délka události: ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_popisUdalosti);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 68);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(194, 379);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // textBox_popisUdalosti
            // 
            this.textBox_popisUdalosti.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_popisUdalosti.Location = new System.Drawing.Point(2, 15);
            this.textBox_popisUdalosti.Multiline = true;
            this.textBox_popisUdalosti.Name = "textBox_popisUdalosti";
            this.textBox_popisUdalosti.ReadOnly = true;
            this.textBox_popisUdalosti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_popisUdalosti.Size = new System.Drawing.Size(190, 301);
            this.textBox_popisUdalosti.TabIndex = 1;
            this.textBox_popisUdalosti.Text = "Popis události...";
            // 
            // label_nazevUdalosti
            // 
            this.label_nazevUdalosti.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_nazevUdalosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nazevUdalosti.Location = new System.Drawing.Point(3, 16);
            this.label_nazevUdalosti.Name = "label_nazevUdalosti";
            this.label_nazevUdalosti.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label_nazevUdalosti.Size = new System.Drawing.Size(194, 52);
            this.label_nazevUdalosti.TabIndex = 0;
            this.label_nazevUdalosti.Text = "NazevUdalosti";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_smazaneUdalosti);
            this.groupBox3.Controls.Add(this.listBox_splneneUdalosti);
            this.groupBox3.Controls.Add(this.listBox_udalosti);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(115, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 450);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // listBox_smazaneUdalosti
            // 
            this.listBox_smazaneUdalosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_smazaneUdalosti.FormattingEnabled = true;
            this.listBox_smazaneUdalosti.Location = new System.Drawing.Point(3, 16);
            this.listBox_smazaneUdalosti.Name = "listBox_smazaneUdalosti";
            this.listBox_smazaneUdalosti.Size = new System.Drawing.Size(479, 431);
            this.listBox_smazaneUdalosti.TabIndex = 2;
            this.listBox_smazaneUdalosti.SelectedIndexChanged += new System.EventHandler(this.listBox_smazaneUdalosti_SelectedIndexChanged);
            // 
            // listBox_splneneUdalosti
            // 
            this.listBox_splneneUdalosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_splneneUdalosti.FormattingEnabled = true;
            this.listBox_splneneUdalosti.Location = new System.Drawing.Point(3, 16);
            this.listBox_splneneUdalosti.Name = "listBox_splneneUdalosti";
            this.listBox_splneneUdalosti.Size = new System.Drawing.Size(479, 431);
            this.listBox_splneneUdalosti.TabIndex = 1;
            this.listBox_splneneUdalosti.SelectedIndexChanged += new System.EventHandler(this.listBox_splneneUdalosti_SelectedIndexChanged);
            // 
            // listBox_udalosti
            // 
            this.listBox_udalosti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_udalosti.FormattingEnabled = true;
            this.listBox_udalosti.Location = new System.Drawing.Point(3, 16);
            this.listBox_udalosti.Name = "listBox_udalosti";
            this.listBox_udalosti.Size = new System.Drawing.Size(479, 431);
            this.listBox_udalosti.TabIndex = 0;
            this.listBox_udalosti.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.button_udalostiNesplnene, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_smazano, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_splneno, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 317);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(109, 130);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button_udalostiNesplnene
            // 
            this.button_udalostiNesplnene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_udalostiNesplnene.Location = new System.Drawing.Point(3, 89);
            this.button_udalostiNesplnene.Name = "button_udalostiNesplnene";
            this.button_udalostiNesplnene.Size = new System.Drawing.Size(103, 38);
            this.button_udalostiNesplnene.TabIndex = 3;
            this.button_udalostiNesplnene.Text = "Události";
            this.button_udalostiNesplnene.UseVisualStyleBackColor = true;
            this.button_udalostiNesplnene.Click += new System.EventHandler(this.button_udalostiNesplnene_Click);
            // 
            // button_smazano
            // 
            this.button_smazano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_smazano.Location = new System.Drawing.Point(3, 46);
            this.button_smazano.Name = "button_smazano";
            this.button_smazano.Size = new System.Drawing.Size(103, 37);
            this.button_smazano.TabIndex = 1;
            this.button_smazano.Text = "Smazané";
            this.button_smazano.UseVisualStyleBackColor = true;
            this.button_smazano.Click += new System.EventHandler(this.button_smazano_Click);
            // 
            // button_splneno
            // 
            this.button_splneno.Location = new System.Drawing.Point(3, 3);
            this.button_splneno.Name = "button_splneno";
            this.button_splneno.Size = new System.Drawing.Size(103, 36);
            this.button_splneno.TabIndex = 2;
            this.button_splneno.Text = "Splněné";
            this.button_splneno.UseVisualStyleBackColor = true;
            this.button_splneno.Click += new System.EventHandler(this.button_splneno_Click);
            // 
            // button_novaUdalost
            // 
            this.button_novaUdalost.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_novaUdalost.Location = new System.Drawing.Point(3, 16);
            this.button_novaUdalost.Name = "button_novaUdalost";
            this.button_novaUdalost.Size = new System.Drawing.Size(109, 26);
            this.button_novaUdalost.TabIndex = 3;
            this.button_novaUdalost.Text = "Nová Událost";
            this.button_novaUdalost.UseVisualStyleBackColor = true;
            this.button_novaUdalost.Click += new System.EventHandler(this.button_novaUdalost_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_editovatUdalost);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button_novaUdalost);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_editovatUdalost
            // 
            this.button_editovatUdalost.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_editovatUdalost.Location = new System.Drawing.Point(3, 42);
            this.button_editovatUdalost.Name = "button_editovatUdalost";
            this.button_editovatUdalost.Size = new System.Drawing.Size(109, 26);
            this.button_editovatUdalost.TabIndex = 4;
            this.button_editovatUdalost.Text = "Editovat Událost";
            this.button_editovatUdalost.UseVisualStyleBackColor = true;
            this.button_editovatUdalost.Click += new System.EventHandler(this.button_editovatUdalost_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_zrusitSplneniSmazani);
            this.groupBox4.Controls.Add(this.button_splnitUdalost);
            this.groupBox4.Controls.Add(this.button_smazatUdalost);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 133);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // button_zrusitSplneniSmazani
            // 
            this.button_zrusitSplneniSmazani.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_zrusitSplneniSmazani.Location = new System.Drawing.Point(3, 83);
            this.button_zrusitSplneniSmazani.Name = "button_zrusitSplneniSmazani";
            this.button_zrusitSplneniSmazani.Size = new System.Drawing.Size(103, 47);
            this.button_zrusitSplneniSmazani.TabIndex = 2;
            this.button_zrusitSplneniSmazani.Text = "Zrušit Splnění/Smazání";
            this.button_zrusitSplneniSmazani.UseVisualStyleBackColor = true;
            this.button_zrusitSplneniSmazani.Click += new System.EventHandler(this.button_zrusitSplneniSmazani_Click);
            // 
            // button_splnitUdalost
            // 
            this.button_splnitUdalost.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_splnitUdalost.Location = new System.Drawing.Point(3, 51);
            this.button_splnitUdalost.Name = "button_splnitUdalost";
            this.button_splnitUdalost.Size = new System.Drawing.Size(103, 32);
            this.button_splnitUdalost.TabIndex = 1;
            this.button_splnitUdalost.Text = "Splněno";
            this.button_splnitUdalost.UseVisualStyleBackColor = true;
            this.button_splnitUdalost.Click += new System.EventHandler(this.button_splnitUdalost_Click);
            // 
            // button_smazatUdalost
            // 
            this.button_smazatUdalost.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_smazatUdalost.Location = new System.Drawing.Point(3, 16);
            this.button_smazatUdalost.Name = "button_smazatUdalost";
            this.button_smazatUdalost.Size = new System.Drawing.Size(103, 35);
            this.button_smazatUdalost.TabIndex = 0;
            this.button_smazatUdalost.Text = "Smazat";
            this.button_smazatUdalost.UseVisualStyleBackColor = true;
            this.button_smazatUdalost.Click += new System.EventHandler(this.button_smazatUdalost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_nazevUdalosti;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_popisUdalosti;
        private System.Windows.Forms.ListBox listBox_udalosti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_smazano;
        private System.Windows.Forms.Button button_splneno;
        private System.Windows.Forms.Button button_novaUdalost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_splnitUdalost;
        private System.Windows.Forms.Button button_smazatUdalost;
        private System.Windows.Forms.Button button_udalostiNesplnene;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_celodenni;
        private System.Windows.Forms.Label label_delkaUdalosti;
        private System.Windows.Forms.ListBox listBox_smazaneUdalosti;
        private System.Windows.Forms.ListBox listBox_splneneUdalosti;
        private System.Windows.Forms.Button button_editovatUdalost;
        private System.Windows.Forms.Button button_zrusitSplneniSmazani;
    }
}

