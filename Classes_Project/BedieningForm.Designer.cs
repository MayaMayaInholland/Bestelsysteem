namespace Classes_Project
{
    partial class BedieningForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabB_Bestellen1 = new System.Windows.Forms.TabPage();
            this.tabB_TafelOverzicht = new System.Windows.Forms.TabPage();
            this.cmb_MenuCategorie = new System.Windows.Forms.ComboBox();
            this.btn_StatusTafel = new System.Windows.Forms.Button();
            this.btn_Afrekenen = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.rbtn_eten = new System.Windows.Forms.RadioButton();
            this.rbtn_drank = new System.Windows.Forms.RadioButton();
            this.tab_BestellingSelecteren = new System.Windows.Forms.TabControl();
            this.L_voorgerecht = new System.Windows.Forms.TabPage();
            this.L_Hoofdgerecht = new System.Windows.Forms.TabPage();
            this.L_Nagerecht = new System.Windows.Forms.TabPage();
            this.D_VoorGerecht = new System.Windows.Forms.TabPage();
            this.D_hoofdgerecht = new System.Windows.Forms.TabPage();
            this.D_nagerecht = new System.Windows.Forms.TabPage();
            this.drank_Bier = new System.Windows.Forms.TabPage();
            this.drank_Wijn = new System.Windows.Forms.TabPage();
            this.drank_Gedestileerd = new System.Windows.Forms.TabPage();
            this.drank_KoffieThee = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabB_Bestellen1.SuspendLayout();
            this.tab_BestellingSelecteren.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabB_Bestellen1);
            this.tabControl1.Controls.Add(this.tabB_TafelOverzicht);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabB_Bestellen1
            // 
            this.tabB_Bestellen1.Controls.Add(this.tab_BestellingSelecteren);
            this.tabB_Bestellen1.Controls.Add(this.rbtn_drank);
            this.tabB_Bestellen1.Controls.Add(this.rbtn_eten);
            this.tabB_Bestellen1.Controls.Add(this.listView1);
            this.tabB_Bestellen1.Controls.Add(this.btn_Afrekenen);
            this.tabB_Bestellen1.Controls.Add(this.btn_StatusTafel);
            this.tabB_Bestellen1.Controls.Add(this.cmb_MenuCategorie);
            this.tabB_Bestellen1.Location = new System.Drawing.Point(4, 22);
            this.tabB_Bestellen1.Name = "tabB_Bestellen1";
            this.tabB_Bestellen1.Padding = new System.Windows.Forms.Padding(3);
            this.tabB_Bestellen1.Size = new System.Drawing.Size(371, 417);
            this.tabB_Bestellen1.TabIndex = 0;
            this.tabB_Bestellen1.Text = "Bestellen";
            this.tabB_Bestellen1.UseVisualStyleBackColor = true;
            // 
            // tabB_TafelOverzicht
            // 
            this.tabB_TafelOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tabB_TafelOverzicht.Name = "tabB_TafelOverzicht";
            this.tabB_TafelOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabB_TafelOverzicht.Size = new System.Drawing.Size(371, 417);
            this.tabB_TafelOverzicht.TabIndex = 1;
            this.tabB_TafelOverzicht.Text = "TafelOverzicht";
            this.tabB_TafelOverzicht.UseVisualStyleBackColor = true;
            // 
            // cmb_MenuCategorie
            // 
            this.cmb_MenuCategorie.FormattingEnabled = true;
            this.cmb_MenuCategorie.Location = new System.Drawing.Point(7, 7);
            this.cmb_MenuCategorie.Name = "cmb_MenuCategorie";
            this.cmb_MenuCategorie.Size = new System.Drawing.Size(106, 21);
            this.cmb_MenuCategorie.TabIndex = 0;
            // 
            // btn_StatusTafel
            // 
            this.btn_StatusTafel.Location = new System.Drawing.Point(148, 7);
            this.btn_StatusTafel.Name = "btn_StatusTafel";
            this.btn_StatusTafel.Size = new System.Drawing.Size(75, 23);
            this.btn_StatusTafel.TabIndex = 1;
            this.btn_StatusTafel.Text = "BEZET";
            this.btn_StatusTafel.UseVisualStyleBackColor = true;
            // 
            // btn_Afrekenen
            // 
            this.btn_Afrekenen.Location = new System.Drawing.Point(277, 6);
            this.btn_Afrekenen.Name = "btn_Afrekenen";
            this.btn_Afrekenen.Size = new System.Drawing.Size(87, 23);
            this.btn_Afrekenen.TabIndex = 2;
            this.btn_Afrekenen.Text = "AFREKENEN";
            this.btn_Afrekenen.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 158);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // rbtn_eten
            // 
            this.rbtn_eten.AutoSize = true;
            this.rbtn_eten.Location = new System.Drawing.Point(7, 199);
            this.rbtn_eten.Name = "rbtn_eten";
            this.rbtn_eten.Size = new System.Drawing.Size(47, 17);
            this.rbtn_eten.TabIndex = 4;
            this.rbtn_eten.TabStop = true;
            this.rbtn_eten.Text = "Eten";
            this.rbtn_eten.UseVisualStyleBackColor = true;
            // 
            // rbtn_drank
            // 
            this.rbtn_drank.AutoSize = true;
            this.rbtn_drank.Location = new System.Drawing.Point(61, 199);
            this.rbtn_drank.Name = "rbtn_drank";
            this.rbtn_drank.Size = new System.Drawing.Size(54, 17);
            this.rbtn_drank.TabIndex = 5;
            this.rbtn_drank.TabStop = true;
            this.rbtn_drank.Text = "Drank";
            this.rbtn_drank.UseVisualStyleBackColor = true;
            // 
            // tab_BestellingSelecteren
            // 
            this.tab_BestellingSelecteren.Controls.Add(this.L_voorgerecht);
            this.tab_BestellingSelecteren.Controls.Add(this.L_Hoofdgerecht);
            this.tab_BestellingSelecteren.Controls.Add(this.L_Nagerecht);
            this.tab_BestellingSelecteren.Controls.Add(this.D_VoorGerecht);
            this.tab_BestellingSelecteren.Controls.Add(this.D_hoofdgerecht);
            this.tab_BestellingSelecteren.Controls.Add(this.D_nagerecht);
            this.tab_BestellingSelecteren.Controls.Add(this.drank_Bier);
            this.tab_BestellingSelecteren.Controls.Add(this.drank_Wijn);
            this.tab_BestellingSelecteren.Controls.Add(this.drank_Gedestileerd);
            this.tab_BestellingSelecteren.Controls.Add(this.drank_KoffieThee);
            this.tab_BestellingSelecteren.Location = new System.Drawing.Point(3, 222);
            this.tab_BestellingSelecteren.Name = "tab_BestellingSelecteren";
            this.tab_BestellingSelecteren.SelectedIndex = 0;
            this.tab_BestellingSelecteren.Size = new System.Drawing.Size(365, 192);
            this.tab_BestellingSelecteren.TabIndex = 6;
            // 
            // L_voorgerecht
            // 
            this.L_voorgerecht.Location = new System.Drawing.Point(4, 22);
            this.L_voorgerecht.Name = "L_voorgerecht";
            this.L_voorgerecht.Padding = new System.Windows.Forms.Padding(3);
            this.L_voorgerecht.Size = new System.Drawing.Size(357, 166);
            this.L_voorgerecht.TabIndex = 0;
            this.L_voorgerecht.Text = "Voorgerecht";
            this.L_voorgerecht.UseVisualStyleBackColor = true;
            // 
            // L_Hoofdgerecht
            // 
            this.L_Hoofdgerecht.Location = new System.Drawing.Point(4, 22);
            this.L_Hoofdgerecht.Name = "L_Hoofdgerecht";
            this.L_Hoofdgerecht.Padding = new System.Windows.Forms.Padding(3);
            this.L_Hoofdgerecht.Size = new System.Drawing.Size(357, 166);
            this.L_Hoofdgerecht.TabIndex = 1;
            this.L_Hoofdgerecht.Text = "Hoofdgerecht";
            this.L_Hoofdgerecht.UseVisualStyleBackColor = true;
            // 
            // L_Nagerecht
            // 
            this.L_Nagerecht.Location = new System.Drawing.Point(4, 22);
            this.L_Nagerecht.Name = "L_Nagerecht";
            this.L_Nagerecht.Size = new System.Drawing.Size(357, 166);
            this.L_Nagerecht.TabIndex = 2;
            this.L_Nagerecht.Text = "Nagerecht";
            this.L_Nagerecht.UseVisualStyleBackColor = true;
            // 
            // D_VoorGerecht
            // 
            this.D_VoorGerecht.Location = new System.Drawing.Point(4, 22);
            this.D_VoorGerecht.Name = "D_VoorGerecht";
            this.D_VoorGerecht.Size = new System.Drawing.Size(357, 166);
            this.D_VoorGerecht.TabIndex = 3;
            this.D_VoorGerecht.Text = "Voorgerecht";
            this.D_VoorGerecht.UseVisualStyleBackColor = true;
            // 
            // D_hoofdgerecht
            // 
            this.D_hoofdgerecht.Location = new System.Drawing.Point(4, 22);
            this.D_hoofdgerecht.Name = "D_hoofdgerecht";
            this.D_hoofdgerecht.Size = new System.Drawing.Size(357, 166);
            this.D_hoofdgerecht.TabIndex = 4;
            this.D_hoofdgerecht.Text = "Hoofdgerecht";
            this.D_hoofdgerecht.UseVisualStyleBackColor = true;
            // 
            // D_nagerecht
            // 
            this.D_nagerecht.Location = new System.Drawing.Point(4, 22);
            this.D_nagerecht.Name = "D_nagerecht";
            this.D_nagerecht.Size = new System.Drawing.Size(357, 166);
            this.D_nagerecht.TabIndex = 5;
            this.D_nagerecht.Text = "Nagerecht";
            this.D_nagerecht.UseVisualStyleBackColor = true;
            // 
            // drank_Bier
            // 
            this.drank_Bier.Location = new System.Drawing.Point(4, 22);
            this.drank_Bier.Name = "drank_Bier";
            this.drank_Bier.Size = new System.Drawing.Size(357, 166);
            this.drank_Bier.TabIndex = 6;
            this.drank_Bier.Text = "Bier";
            this.drank_Bier.UseVisualStyleBackColor = true;
            // 
            // drank_Wijn
            // 
            this.drank_Wijn.Location = new System.Drawing.Point(4, 22);
            this.drank_Wijn.Name = "drank_Wijn";
            this.drank_Wijn.Size = new System.Drawing.Size(357, 166);
            this.drank_Wijn.TabIndex = 7;
            this.drank_Wijn.Text = "Wijn";
            this.drank_Wijn.UseVisualStyleBackColor = true;
            // 
            // drank_Gedestileerd
            // 
            this.drank_Gedestileerd.Location = new System.Drawing.Point(4, 22);
            this.drank_Gedestileerd.Name = "drank_Gedestileerd";
            this.drank_Gedestileerd.Size = new System.Drawing.Size(357, 166);
            this.drank_Gedestileerd.TabIndex = 8;
            this.drank_Gedestileerd.Text = "Gedestileerd";
            this.drank_Gedestileerd.UseVisualStyleBackColor = true;
            // 
            // drank_KoffieThee
            // 
            this.drank_KoffieThee.Location = new System.Drawing.Point(4, 22);
            this.drank_KoffieThee.Name = "drank_KoffieThee";
            this.drank_KoffieThee.Size = new System.Drawing.Size(357, 166);
            this.drank_KoffieThee.TabIndex = 9;
            this.drank_KoffieThee.Text = "Koffie/Thee";
            this.drank_KoffieThee.UseVisualStyleBackColor = true;
            // 
            // BedieningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "BedieningForm";
            this.Text = "BedieningForm";
            this.tabControl1.ResumeLayout(false);
            this.tabB_Bestellen1.ResumeLayout(false);
            this.tabB_Bestellen1.PerformLayout();
            this.tab_BestellingSelecteren.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabB_Bestellen1;
        private System.Windows.Forms.TabPage tabB_TafelOverzicht;
        private System.Windows.Forms.ComboBox cmb_MenuCategorie;
        private System.Windows.Forms.Button btn_Afrekenen;
        private System.Windows.Forms.Button btn_StatusTafel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rbtn_eten;
        private System.Windows.Forms.RadioButton rbtn_drank;
        private System.Windows.Forms.TabControl tab_BestellingSelecteren;
        private System.Windows.Forms.TabPage L_voorgerecht;
        private System.Windows.Forms.TabPage L_Hoofdgerecht;
        private System.Windows.Forms.TabPage L_Nagerecht;
        private System.Windows.Forms.TabPage D_VoorGerecht;
        private System.Windows.Forms.TabPage D_hoofdgerecht;
        private System.Windows.Forms.TabPage D_nagerecht;
        private System.Windows.Forms.TabPage drank_Bier;
        private System.Windows.Forms.TabPage drank_Wijn;
        private System.Windows.Forms.TabPage drank_Gedestileerd;
        private System.Windows.Forms.TabPage drank_KoffieThee;
    }
}