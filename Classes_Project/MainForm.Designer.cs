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
            this.cmb_menuCategorie = new System.Windows.Forms.ComboBox();
            this.btn_drank = new System.Windows.Forms.RadioButton();
            this.btn_eten = new System.Windows.Forms.RadioButton();
            this.tab_Gerechten_Drank = new System.Windows.Forms.TabControl();
            this.Lunch_VoorGerecht = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Voorgerecht_steak = new System.Windows.Forms.Button();
            this.Lunch_HoofdGerecht = new System.Windows.Forms.TabPage();
            this.Lunch_NaGerecht = new System.Windows.Forms.TabPage();
            this.diner_VoorGerecht = new System.Windows.Forms.TabPage();
            this.diner_HoofdGerecht = new System.Windows.Forms.TabPage();
            this.diner_NaGerecht = new System.Windows.Forms.TabPage();
            this.tab_Bier = new System.Windows.Forms.TabPage();
            this.tab_Wijn = new System.Windows.Forms.TabPage();
            this.tab_Gedestileerd = new System.Windows.Forms.TabPage();
            this.tab_KoffieThee = new System.Windows.Forms.TabPage();
            this.btn_Afrekenen = new System.Windows.Forms.Button();
            this.btn_StatusT = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tab_TafelOverzicht = new System.Windows.Forms.TabPage();
            this.btn_Tafel1 = new System.Windows.Forms.Button();
            this.tab_Keuken = new System.Windows.Forms.TabPage();
            this.tab_Bar = new System.Windows.Forms.TabPage();
            this.tab_medewerkerOverzicht = new System.Windows.Forms.TabPage();
            this.tab_Rekening = new System.Windows.Forms.TabPage();
            this.btn_Tafel2 = new System.Windows.Forms.Button();
            this.btn_Tafel3 = new System.Windows.Forms.Button();
            this.btn_Tafel4 = new System.Windows.Forms.Button();
            this.btn_Tafel5 = new System.Windows.Forms.Button();
            this.btn_Tafel6 = new System.Windows.Forms.Button();
            this.btn_Tafel7 = new System.Windows.Forms.Button();
            this.btn_Tafel8 = new System.Windows.Forms.Button();
            this.btn_Tafel9 = new System.Windows.Forms.Button();
            this.btn_Tafel10 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_Bestellen.SuspendLayout();
            this.tab_Gerechten_Drank.SuspendLayout();
            this.Lunch_VoorGerecht.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(598, 635);
            this.tabControl.TabIndex = 0;
            // 
            // tab_Bestellen
            // 
            this.tab_Bestellen.Controls.Add(this.cmb_menuCategorie);
            this.tab_Bestellen.Controls.Add(this.btn_drank);
            this.tab_Bestellen.Controls.Add(this.btn_eten);
            this.tab_Bestellen.Controls.Add(this.tab_Gerechten_Drank);
            this.tab_Bestellen.Controls.Add(this.btn_Afrekenen);
            this.tab_Bestellen.Controls.Add(this.btn_StatusT);
            this.tab_Bestellen.Controls.Add(this.listView1);
            this.tab_Bestellen.Location = new System.Drawing.Point(4, 22);
            this.tab_Bestellen.Name = "tab_Bestellen";
            this.tab_Bestellen.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Bestellen.Size = new System.Drawing.Size(385, 408);
            this.tab_Bestellen.TabIndex = 0;
            this.tab_Bestellen.Text = "Bestelling";
            this.tab_Bestellen.UseVisualStyleBackColor = true;
            // 
            // cmb_menuCategorie
            // 
            this.cmb_menuCategorie.FormattingEnabled = true;
            this.cmb_menuCategorie.Items.AddRange(new object[] {
            "Lunch",
            "Diner"});
            this.cmb_menuCategorie.Location = new System.Drawing.Point(6, 6);
            this.cmb_menuCategorie.Name = "cmb_menuCategorie";
            this.cmb_menuCategorie.Size = new System.Drawing.Size(121, 21);
            this.cmb_menuCategorie.TabIndex = 7;
            this.cmb_menuCategorie.SelectedIndexChanged += new System.EventHandler(this.cmb_menuCategorie_SelectedIndexChanged);
            // 
            // btn_drank
            // 
            this.btn_drank.AutoSize = true;
            this.btn_drank.Location = new System.Drawing.Point(82, 172);
            this.btn_drank.Name = "btn_drank";
            this.btn_drank.Size = new System.Drawing.Size(54, 17);
            this.btn_drank.TabIndex = 6;
            this.btn_drank.TabStop = true;
            this.btn_drank.Text = "Drank";
            this.btn_drank.UseVisualStyleBackColor = true;
            // 
            // btn_eten
            // 
            this.btn_eten.AutoSize = true;
            this.btn_eten.Location = new System.Drawing.Point(29, 172);
            this.btn_eten.Name = "btn_eten";
            this.btn_eten.Size = new System.Drawing.Size(47, 17);
            this.btn_eten.TabIndex = 5;
            this.btn_eten.TabStop = true;
            this.btn_eten.Text = "Eten";
            this.btn_eten.UseVisualStyleBackColor = true;
            // 
            // tab_Gerechten_Drank
            // 
            this.tab_Gerechten_Drank.Controls.Add(this.Lunch_VoorGerecht);
            this.tab_Gerechten_Drank.Controls.Add(this.Lunch_HoofdGerecht);
            this.tab_Gerechten_Drank.Controls.Add(this.Lunch_NaGerecht);
            this.tab_Gerechten_Drank.Controls.Add(this.diner_VoorGerecht);
            this.tab_Gerechten_Drank.Controls.Add(this.diner_HoofdGerecht);
            this.tab_Gerechten_Drank.Controls.Add(this.diner_NaGerecht);
            this.tab_Gerechten_Drank.Controls.Add(this.tab_Bier);
            this.tab_Gerechten_Drank.Controls.Add(this.tab_Wijn);
            this.tab_Gerechten_Drank.Controls.Add(this.tab_Gedestileerd);
            this.tab_Gerechten_Drank.Controls.Add(this.tab_KoffieThee);
            this.tab_Gerechten_Drank.Location = new System.Drawing.Point(6, 207);
            this.tab_Gerechten_Drank.Name = "tab_Gerechten_Drank";
            this.tab_Gerechten_Drank.SelectedIndex = 0;
            this.tab_Gerechten_Drank.Size = new System.Drawing.Size(373, 195);
            this.tab_Gerechten_Drank.TabIndex = 4;
            // 
            // Lunch_VoorGerecht
            // 
            this.Lunch_VoorGerecht.Controls.Add(this.button4);
            this.Lunch_VoorGerecht.Controls.Add(this.button2);
            this.Lunch_VoorGerecht.Controls.Add(this.Voorgerecht_steak);
            this.Lunch_VoorGerecht.Location = new System.Drawing.Point(4, 22);
            this.Lunch_VoorGerecht.Name = "Lunch_VoorGerecht";
            this.Lunch_VoorGerecht.Padding = new System.Windows.Forms.Padding(3);
            this.Lunch_VoorGerecht.Size = new System.Drawing.Size(365, 169);
            this.Lunch_VoorGerecht.TabIndex = 0;
            this.Lunch_VoorGerecht.Text = "VoorGerecht";
            this.Lunch_VoorGerecht.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(353, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "..";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(353, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "..";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Voorgerecht_steak
            // 
            this.Voorgerecht_steak.Location = new System.Drawing.Point(6, 26);
            this.Voorgerecht_steak.Name = "Voorgerecht_steak";
            this.Voorgerecht_steak.Size = new System.Drawing.Size(353, 23);
            this.Voorgerecht_steak.TabIndex = 8;
            this.Voorgerecht_steak.Text = "Steak\ttartaar\tmet\ttruffelmayonaisse";
            this.Voorgerecht_steak.UseVisualStyleBackColor = true;
            // 
            // Lunch_HoofdGerecht
            // 
            this.Lunch_HoofdGerecht.Location = new System.Drawing.Point(4, 22);
            this.Lunch_HoofdGerecht.Name = "Lunch_HoofdGerecht";
            this.Lunch_HoofdGerecht.Padding = new System.Windows.Forms.Padding(3);
            this.Lunch_HoofdGerecht.Size = new System.Drawing.Size(365, 169);
            this.Lunch_HoofdGerecht.TabIndex = 1;
            this.Lunch_HoofdGerecht.Text = "HoofdGerecht";
            this.Lunch_HoofdGerecht.UseVisualStyleBackColor = true;
            // 
            // Lunch_NaGerecht
            // 
            this.Lunch_NaGerecht.Location = new System.Drawing.Point(4, 22);
            this.Lunch_NaGerecht.Name = "Lunch_NaGerecht";
            this.Lunch_NaGerecht.Padding = new System.Windows.Forms.Padding(3);
            this.Lunch_NaGerecht.Size = new System.Drawing.Size(365, 169);
            this.Lunch_NaGerecht.TabIndex = 2;
            this.Lunch_NaGerecht.Text = "Nagerecht";
            this.Lunch_NaGerecht.UseVisualStyleBackColor = true;
            // 
            // diner_VoorGerecht
            // 
            this.diner_VoorGerecht.Location = new System.Drawing.Point(4, 22);
            this.diner_VoorGerecht.Name = "diner_VoorGerecht";
            this.diner_VoorGerecht.Size = new System.Drawing.Size(365, 169);
            this.diner_VoorGerecht.TabIndex = 3;
            this.diner_VoorGerecht.Text = "D_Voorgerecht";
            this.diner_VoorGerecht.UseVisualStyleBackColor = true;
            // 
            // diner_HoofdGerecht
            // 
            this.diner_HoofdGerecht.Location = new System.Drawing.Point(4, 22);
            this.diner_HoofdGerecht.Name = "diner_HoofdGerecht";
            this.diner_HoofdGerecht.Size = new System.Drawing.Size(365, 169);
            this.diner_HoofdGerecht.TabIndex = 4;
            this.diner_HoofdGerecht.Text = "D_Hoofdgerecht";
            this.diner_HoofdGerecht.UseVisualStyleBackColor = true;
            // 
            // diner_NaGerecht
            // 
            this.diner_NaGerecht.Location = new System.Drawing.Point(4, 22);
            this.diner_NaGerecht.Name = "diner_NaGerecht";
            this.diner_NaGerecht.Size = new System.Drawing.Size(365, 169);
            this.diner_NaGerecht.TabIndex = 5;
            this.diner_NaGerecht.Text = "D_NaGerecht";
            this.diner_NaGerecht.UseVisualStyleBackColor = true;
            // 
            // tab_Bier
            // 
            this.tab_Bier.Location = new System.Drawing.Point(4, 22);
            this.tab_Bier.Name = "tab_Bier";
            this.tab_Bier.Size = new System.Drawing.Size(365, 169);
            this.tab_Bier.TabIndex = 6;
            this.tab_Bier.Text = "Bier";
            this.tab_Bier.UseVisualStyleBackColor = true;
            // 
            // tab_Wijn
            // 
            this.tab_Wijn.Location = new System.Drawing.Point(4, 22);
            this.tab_Wijn.Name = "tab_Wijn";
            this.tab_Wijn.Size = new System.Drawing.Size(365, 169);
            this.tab_Wijn.TabIndex = 7;
            this.tab_Wijn.Text = "Wijn";
            this.tab_Wijn.UseVisualStyleBackColor = true;
            // 
            // tab_Gedestileerd
            // 
            this.tab_Gedestileerd.Location = new System.Drawing.Point(4, 22);
            this.tab_Gedestileerd.Name = "tab_Gedestileerd";
            this.tab_Gedestileerd.Size = new System.Drawing.Size(365, 169);
            this.tab_Gedestileerd.TabIndex = 8;
            this.tab_Gedestileerd.Text = "Gedestileerd";
            this.tab_Gedestileerd.UseVisualStyleBackColor = true;
            // 
            // tab_KoffieThee
            // 
            this.tab_KoffieThee.Location = new System.Drawing.Point(4, 22);
            this.tab_KoffieThee.Name = "tab_KoffieThee";
            this.tab_KoffieThee.Size = new System.Drawing.Size(365, 169);
            this.tab_KoffieThee.TabIndex = 9;
            this.tab_KoffieThee.Text = "Coffie/Thee";
            this.tab_KoffieThee.UseVisualStyleBackColor = true;
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
            // btn_StatusT
            // 
            this.btn_StatusT.Location = new System.Drawing.Point(151, 4);
            this.btn_StatusT.Name = "btn_StatusT";
            this.btn_StatusT.Size = new System.Drawing.Size(75, 23);
            this.btn_StatusT.TabIndex = 2;
            this.btn_StatusT.Text = "Bezet";
            this.btn_StatusT.UseVisualStyleBackColor = true;
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
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel10);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel9);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel8);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel7);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel6);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel5);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel4);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel3);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel2);
            this.tab_TafelOverzicht.Controls.Add(this.btn_Tafel1);
            this.tab_TafelOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tab_TafelOverzicht.Name = "tab_TafelOverzicht";
            this.tab_TafelOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TafelOverzicht.Size = new System.Drawing.Size(590, 609);
            this.tab_TafelOverzicht.TabIndex = 1;
            this.tab_TafelOverzicht.Text = "Tafel Overzicht";
            this.tab_TafelOverzicht.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel1
            // 
            this.btn_Tafel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel1.BackgroundImage")));
            this.btn_Tafel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel1.Location = new System.Drawing.Point(79, 49);
            this.btn_Tafel1.Name = "btn_Tafel1";
            this.btn_Tafel1.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel1.TabIndex = 10;
            this.btn_Tafel1.Text = "1";
            this.btn_Tafel1.UseVisualStyleBackColor = true;
            this.btn_Tafel1.Click += new System.EventHandler(this.btn_Tafel1_Click);
            // 
            // tab_Keuken
            // 
            this.tab_Keuken.Location = new System.Drawing.Point(4, 22);
            this.tab_Keuken.Name = "tab_Keuken";
            this.tab_Keuken.Size = new System.Drawing.Size(385, 408);
            this.tab_Keuken.TabIndex = 2;
            this.tab_Keuken.Text = "Keuken";
            this.tab_Keuken.UseVisualStyleBackColor = true;
            // 
            // tab_Bar
            // 
            this.tab_Bar.Location = new System.Drawing.Point(4, 22);
            this.tab_Bar.Name = "tab_Bar";
            this.tab_Bar.Size = new System.Drawing.Size(385, 408);
            this.tab_Bar.TabIndex = 3;
            this.tab_Bar.Text = "Bar";
            this.tab_Bar.UseVisualStyleBackColor = true;
            // 
            // tab_medewerkerOverzicht
            // 
            this.tab_medewerkerOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tab_medewerkerOverzicht.Name = "tab_medewerkerOverzicht";
            this.tab_medewerkerOverzicht.Size = new System.Drawing.Size(385, 408);
            this.tab_medewerkerOverzicht.TabIndex = 4;
            this.tab_medewerkerOverzicht.Text = "Mederwerker Overzicht";
            this.tab_medewerkerOverzicht.UseVisualStyleBackColor = true;
            // 
            // tab_Rekening
            // 
            this.tab_Rekening.Location = new System.Drawing.Point(4, 22);
            this.tab_Rekening.Name = "tab_Rekening";
            this.tab_Rekening.Size = new System.Drawing.Size(385, 408);
            this.tab_Rekening.TabIndex = 5;
            this.tab_Rekening.Text = "Rekening";
            this.tab_Rekening.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel2
            // 
            this.btn_Tafel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel2.BackgroundImage")));
            this.btn_Tafel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel2.Location = new System.Drawing.Point(402, 49);
            this.btn_Tafel2.Name = "btn_Tafel2";
            this.btn_Tafel2.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel2.TabIndex = 11;
            this.btn_Tafel2.Text = "2";
            this.btn_Tafel2.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel3
            // 
            this.btn_Tafel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel3.BackgroundImage")));
            this.btn_Tafel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel3.Location = new System.Drawing.Point(79, 151);
            this.btn_Tafel3.Name = "btn_Tafel3";
            this.btn_Tafel3.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel3.TabIndex = 12;
            this.btn_Tafel3.Text = "3";
            this.btn_Tafel3.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel4
            // 
            this.btn_Tafel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel4.BackgroundImage")));
            this.btn_Tafel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel4.Location = new System.Drawing.Point(402, 151);
            this.btn_Tafel4.Name = "btn_Tafel4";
            this.btn_Tafel4.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel4.TabIndex = 13;
            this.btn_Tafel4.Text = "4";
            this.btn_Tafel4.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel5
            // 
            this.btn_Tafel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel5.BackgroundImage")));
            this.btn_Tafel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel5.Location = new System.Drawing.Point(79, 253);
            this.btn_Tafel5.Name = "btn_Tafel5";
            this.btn_Tafel5.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel5.TabIndex = 14;
            this.btn_Tafel5.Text = "5";
            this.btn_Tafel5.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel6
            // 
            this.btn_Tafel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel6.BackgroundImage")));
            this.btn_Tafel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel6.Location = new System.Drawing.Point(402, 253);
            this.btn_Tafel6.Name = "btn_Tafel6";
            this.btn_Tafel6.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel6.TabIndex = 15;
            this.btn_Tafel6.Text = "6";
            this.btn_Tafel6.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel7
            // 
            this.btn_Tafel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel7.BackgroundImage")));
            this.btn_Tafel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel7.Location = new System.Drawing.Point(79, 355);
            this.btn_Tafel7.Name = "btn_Tafel7";
            this.btn_Tafel7.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel7.TabIndex = 16;
            this.btn_Tafel7.Text = "7";
            this.btn_Tafel7.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel8
            // 
            this.btn_Tafel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel8.BackgroundImage")));
            this.btn_Tafel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel8.Location = new System.Drawing.Point(402, 355);
            this.btn_Tafel8.Name = "btn_Tafel8";
            this.btn_Tafel8.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel8.TabIndex = 17;
            this.btn_Tafel8.Text = "8";
            this.btn_Tafel8.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel9
            // 
            this.btn_Tafel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel9.BackgroundImage")));
            this.btn_Tafel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel9.Location = new System.Drawing.Point(79, 457);
            this.btn_Tafel9.Name = "btn_Tafel9";
            this.btn_Tafel9.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel9.TabIndex = 18;
            this.btn_Tafel9.Text = "9";
            this.btn_Tafel9.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel10
            // 
            this.btn_Tafel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel10.BackgroundImage")));
            this.btn_Tafel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel10.Location = new System.Drawing.Point(402, 457);
            this.btn_Tafel10.Name = "btn_Tafel10";
            this.btn_Tafel10.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel10.TabIndex = 19;
            this.btn_Tafel10.Text = "10";
            this.btn_Tafel10.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 659);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tab_Bestellen.ResumeLayout(false);
            this.tab_Bestellen.PerformLayout();
            this.tab_Gerechten_Drank.ResumeLayout(false);
            this.Lunch_VoorGerecht.ResumeLayout(false);
            this.tab_TafelOverzicht.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_Bestellen;
        private System.Windows.Forms.TabPage tab_TafelOverzicht;
        private System.Windows.Forms.RadioButton btn_drank;
        private System.Windows.Forms.RadioButton btn_eten;
        private System.Windows.Forms.TabControl tab_Gerechten_Drank;
        private System.Windows.Forms.TabPage Lunch_VoorGerecht;
        private System.Windows.Forms.TabPage Lunch_HoofdGerecht;
        private System.Windows.Forms.Button btn_Afrekenen;
        private System.Windows.Forms.Button btn_StatusT;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tab_Keuken;
        private System.Windows.Forms.TabPage tab_Bar;
        private System.Windows.Forms.TabPage tab_medewerkerOverzicht;
        private System.Windows.Forms.TabPage tab_Rekening;
        private System.Windows.Forms.Button btn_Tafel1;
        private System.Windows.Forms.ComboBox cmb_menuCategorie;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Voorgerecht_steak;
        private System.Windows.Forms.TabPage Lunch_NaGerecht;
        private System.Windows.Forms.TabPage diner_VoorGerecht;
        private System.Windows.Forms.TabPage diner_HoofdGerecht;
        private System.Windows.Forms.TabPage diner_NaGerecht;
        private System.Windows.Forms.TabPage tab_Bier;
        private System.Windows.Forms.TabPage tab_Wijn;
        private System.Windows.Forms.TabPage tab_Gedestileerd;
        private System.Windows.Forms.TabPage tab_KoffieThee;
        private System.Windows.Forms.Button btn_Tafel10;
        private System.Windows.Forms.Button btn_Tafel9;
        private System.Windows.Forms.Button btn_Tafel8;
        private System.Windows.Forms.Button btn_Tafel7;
        private System.Windows.Forms.Button btn_Tafel6;
        private System.Windows.Forms.Button btn_Tafel5;
        private System.Windows.Forms.Button btn_Tafel4;
        private System.Windows.Forms.Button btn_Tafel3;
        private System.Windows.Forms.Button btn_Tafel2;
    }
}