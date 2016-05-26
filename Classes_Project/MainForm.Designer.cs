namespace Classes_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_Bestellen = new System.Windows.Forms.TabPage();
            this.Drankbtn = new System.Windows.Forms.RadioButton();
            this.Etenbtn = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Afrekenen = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tab_TafelOverzicht = new System.Windows.Forms.TabPage();
            this.btn_Tafel1 = new System.Windows.Forms.Button();
            this.tab_Keuken = new System.Windows.Forms.TabPage();
            this.tab_Bar = new System.Windows.Forms.TabPage();
            this.tab_medewerkerOverzicht = new System.Windows.Forms.TabPage();
            this.tab_Rekening = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_Bestellen.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_TafelOverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Bestellen);
            this.tabControl.Controls.Add(this.tab_TafelOverzicht);
            this.tabControl.Controls.Add(this.tab_Keuken);
            this.tabControl.Controls.Add(this.tab_Bar);
            this.tabControl.Controls.Add(this.tab_medewerkerOverzicht);
            this.tabControl.Controls.Add(this.tab_Rekening);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(621, 690);
            this.tabControl.TabIndex = 0;
            // 
            // tab_Bestellen
            // 
            this.tab_Bestellen.Controls.Add(this.Drankbtn);
            this.tab_Bestellen.Controls.Add(this.Etenbtn);
            this.tab_Bestellen.Controls.Add(this.tabControl1);
            this.tab_Bestellen.Controls.Add(this.btn_Afrekenen);
            this.tab_Bestellen.Controls.Add(this.btn_Status);
            this.tab_Bestellen.Controls.Add(this.comboBox1);
            this.tab_Bestellen.Controls.Add(this.listView1);
            this.tab_Bestellen.Location = new System.Drawing.Point(4, 22);
            this.tab_Bestellen.Name = "tab_Bestellen";
            this.tab_Bestellen.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Bestellen.Size = new System.Drawing.Size(613, 664);
            this.tab_Bestellen.TabIndex = 0;
            this.tab_Bestellen.Text = "Bestelling";
            this.tab_Bestellen.UseVisualStyleBackColor = true;
            // 
            // Drankbtn
            // 
            this.Drankbtn.AutoSize = true;
            this.Drankbtn.Location = new System.Drawing.Point(82, 172);
            this.Drankbtn.Name = "Drankbtn";
            this.Drankbtn.Size = new System.Drawing.Size(54, 17);
            this.Drankbtn.TabIndex = 6;
            this.Drankbtn.TabStop = true;
            this.Drankbtn.Text = "Drank";
            this.Drankbtn.UseVisualStyleBackColor = true;
            // 
            // Etenbtn
            // 
            this.Etenbtn.AutoSize = true;
            this.Etenbtn.Location = new System.Drawing.Point(29, 172);
            this.Etenbtn.Name = "Etenbtn";
            this.Etenbtn.Size = new System.Drawing.Size(47, 17);
            this.Etenbtn.TabIndex = 5;
            this.Etenbtn.TabStop = true;
            this.Etenbtn.Text = "Eten";
            this.Etenbtn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(6, 207);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 195);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(365, 169);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(365, 169);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Afrekenen
            // 
            this.btn_Afrekenen.Location = new System.Drawing.Point(245, 4);
            this.btn_Afrekenen.Name = "btn_Afrekenen";
            this.btn_Afrekenen.Size = new System.Drawing.Size(75, 23);
            this.btn_Afrekenen.TabIndex = 3;
            this.btn_Afrekenen.Text = "Afrekenen";
            this.btn_Afrekenen.UseVisualStyleBackColor = true;
            this.btn_Afrekenen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.Location = new System.Drawing.Point(151, 4);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(75, 23);
            this.btn_Status.TabIndex = 2;
            this.btn_Status.Text = "Bezet";
            this.btn_Status.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 131);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tab_TafelOverzicht
            // 
            this.tab_TafelOverzicht.Controls.Add(this.button9);
            this.tab_TafelOverzicht.Controls.Add(this.button8);
            this.tab_TafelOverzicht.Controls.Add(this.button7);
            this.tab_TafelOverzicht.Controls.Add(this.button6);
            this.tab_TafelOverzicht.Controls.Add(this.button5);
            this.tab_TafelOverzicht.Controls.Add(this.button4);
            this.tab_TafelOverzicht.Controls.Add(this.button3);
            this.tab_TafelOverzicht.Controls.Add(this.button2);
            this.tab_TafelOverzicht.Controls.Add(this.button1);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel1);
            this.tab_TafelOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tab_TafelOverzicht.Name = "tab_TafelOverzicht";
            this.tab_TafelOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TafelOverzicht.Size = new System.Drawing.Size(613, 664);
            this.tab_TafelOverzicht.TabIndex = 1;
            this.tab_TafelOverzicht.Text = "Tafel Overzicht";
            this.tab_TafelOverzicht.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel1
            // 
            this.btn_Tafel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel1.BackgroundImage")));
            this.btn_Tafel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel1.Location = new System.Drawing.Point(72, 49);
            this.btn_Tafel1.Name = "btn_Tafel1";
            this.btn_Tafel1.Size = new System.Drawing.Size(104, 98);
            this.btn_Tafel1.TabIndex = 10;
            this.btn_Tafel1.Text = "1";
            this.btn_Tafel1.UseVisualStyleBackColor = true;
            this.btn_Tafel1.Click += new System.EventHandler(this.btn_Tafel1_Click);
            // 
            // tab_Keuken
            // 
            this.tab_Keuken.Location = new System.Drawing.Point(4, 22);
            this.tab_Keuken.Name = "tab_Keuken";
            this.tab_Keuken.Size = new System.Drawing.Size(613, 664);
            this.tab_Keuken.TabIndex = 2;
            this.tab_Keuken.Text = "Keuken";
            this.tab_Keuken.UseVisualStyleBackColor = true;
            // 
            // tab_Bar
            // 
            this.tab_Bar.Location = new System.Drawing.Point(4, 22);
            this.tab_Bar.Name = "tab_Bar";
            this.tab_Bar.Size = new System.Drawing.Size(613, 664);
            this.tab_Bar.TabIndex = 3;
            this.tab_Bar.Text = "Bar";
            this.tab_Bar.UseVisualStyleBackColor = true;
            // 
            // tab_medewerkerOverzicht
            // 
            this.tab_medewerkerOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tab_medewerkerOverzicht.Name = "tab_medewerkerOverzicht";
            this.tab_medewerkerOverzicht.Size = new System.Drawing.Size(613, 664);
            this.tab_medewerkerOverzicht.TabIndex = 4;
            this.tab_medewerkerOverzicht.Text = "Mederwerker Overzicht";
            this.tab_medewerkerOverzicht.UseVisualStyleBackColor = true;
            // 
            // tab_Rekening
            // 
            this.tab_Rekening.Location = new System.Drawing.Point(4, 22);
            this.tab_Rekening.Name = "tab_Rekening";
            this.tab_Rekening.Size = new System.Drawing.Size(613, 664);
            this.tab_Rekening.TabIndex = 5;
            this.tab_Rekening.Text = "Rekening";
            this.tab_Rekening.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(398, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 98);
            this.button1.TabIndex = 11;
            this.button1.Text = "2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(72, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 98);
            this.button2.TabIndex = 12;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(398, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 98);
            this.button3.TabIndex = 13;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(72, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 98);
            this.button4.TabIndex = 14;
            this.button4.Text = "5";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(398, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 98);
            this.button5.TabIndex = 15;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(72, 419);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 98);
            this.button6.TabIndex = 16;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(398, 419);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 98);
            this.button7.TabIndex = 17;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(72, 547);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(104, 98);
            this.button8.TabIndex = 18;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(398, 547);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 98);
            this.button9.TabIndex = 19;
            this.button9.Text = "10";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 741);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tab_Bestellen.ResumeLayout(false);
            this.tab_Bestellen.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_TafelOverzicht.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Bestellen;
        private System.Windows.Forms.TabPage tab_TafelOverzicht;
        private System.Windows.Forms.RadioButton Drankbtn;
        private System.Windows.Forms.RadioButton Etenbtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Afrekenen;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tab_Keuken;
        private System.Windows.Forms.TabPage tab_Bar;
        private System.Windows.Forms.TabPage tab_medewerkerOverzicht;
        private System.Windows.Forms.TabPage tab_Rekening;
        private System.Windows.Forms.Button btn_Tafel1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}