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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedieningForm));
            this.tabB_volledig = new System.Windows.Forms.TabControl();
            this.tabB_Bestellen1 = new System.Windows.Forms.TabPage();
            this.btn_bevestig_Bestelling = new System.Windows.Forms.Button();
            this.btn_returnOverzicht = new System.Windows.Forms.Button();
            this.listB_producten = new System.Windows.Forms.ListBox();
            this.listview_producten = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip_bestelling = new System.Windows.Forms.MenuStrip();
            this.lunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabB_TafelOverzicht = new System.Windows.Forms.TabPage();
            this.btn_Tafel10 = new System.Windows.Forms.Button();
            this.btn_Tafel9 = new System.Windows.Forms.Button();
            this.btn_Tafel8 = new System.Windows.Forms.Button();
            this.btn_Tafel7 = new System.Windows.Forms.Button();
            this.btn_Tafel6 = new System.Windows.Forms.Button();
            this.btn_Tafel5 = new System.Windows.Forms.Button();
            this.btn_Tafel4 = new System.Windows.Forms.Button();
            this.btn_Tafel3 = new System.Windows.Forms.Button();
            this.btn_Tafel2 = new System.Windows.Forms.Button();
            this.btn_Tafel1 = new System.Windows.Forms.Button();
            this.btn_Loguit = new System.Windows.Forms.Button();
            this.lbl_IngelogdeMedewerker = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabB_volledig.SuspendLayout();
            this.tabB_Bestellen1.SuspendLayout();
            this.menuStrip_bestelling.SuspendLayout();
            this.tabB_TafelOverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabB_volledig
            // 
            this.tabB_volledig.Controls.Add(this.tabB_Bestellen1);
            this.tabB_volledig.Controls.Add(this.tabB_TafelOverzicht);
            this.tabB_volledig.Location = new System.Drawing.Point(2, 3);
            this.tabB_volledig.Name = "tabB_volledig";
            this.tabB_volledig.SelectedIndex = 0;
            this.tabB_volledig.Size = new System.Drawing.Size(515, 590);
            this.tabB_volledig.TabIndex = 0;
            // 
            // tabB_Bestellen1
            // 
            this.tabB_Bestellen1.Controls.Add(this.btn_bevestig_Bestelling);
            this.tabB_Bestellen1.Controls.Add(this.btn_returnOverzicht);
            this.tabB_Bestellen1.Controls.Add(this.listB_producten);
            this.tabB_Bestellen1.Controls.Add(this.listview_producten);
            this.tabB_Bestellen1.Controls.Add(this.menuStrip_bestelling);
            this.tabB_Bestellen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabB_Bestellen1.Location = new System.Drawing.Point(4, 22);
            this.tabB_Bestellen1.Name = "tabB_Bestellen1";
            this.tabB_Bestellen1.Padding = new System.Windows.Forms.Padding(3);
            this.tabB_Bestellen1.Size = new System.Drawing.Size(507, 564);
            this.tabB_Bestellen1.TabIndex = 0;
            this.tabB_Bestellen1.Text = "Bestellen";
            this.tabB_Bestellen1.UseVisualStyleBackColor = true;
            // 
            // btn_bevestig_Bestelling
            // 
            this.btn_bevestig_Bestelling.Location = new System.Drawing.Point(386, 498);
            this.btn_bevestig_Bestelling.Name = "btn_bevestig_Bestelling";
            this.btn_bevestig_Bestelling.Size = new System.Drawing.Size(117, 33);
            this.btn_bevestig_Bestelling.TabIndex = 9;
            this.btn_bevestig_Bestelling.Text = "Bevestig";
            this.btn_bevestig_Bestelling.UseVisualStyleBackColor = true;
            this.btn_bevestig_Bestelling.Click += new System.EventHandler(this.btn_bevestig_Bestelling_Click);
            // 
            // btn_returnOverzicht
            // 
            this.btn_returnOverzicht.Location = new System.Drawing.Point(386, 30);
            this.btn_returnOverzicht.Name = "btn_returnOverzicht";
            this.btn_returnOverzicht.Size = new System.Drawing.Size(117, 32);
            this.btn_returnOverzicht.TabIndex = 8;
            this.btn_returnOverzicht.Text = "TafelOverzicht";
            this.btn_returnOverzicht.UseVisualStyleBackColor = true;
            this.btn_returnOverzicht.Click += new System.EventHandler(this.btn_returnOverzicht_Click);
            // 
            // listB_producten
            // 
            this.listB_producten.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.listB_producten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listB_producten.FormattingEnabled = true;
            this.listB_producten.ItemHeight = 16;
            this.listB_producten.Location = new System.Drawing.Point(3, 68);
            this.listB_producten.Name = "listB_producten";
            this.listB_producten.Size = new System.Drawing.Size(500, 196);
            this.listB_producten.TabIndex = 7;
            this.listB_producten.UseWaitCursor = true;
            this.listB_producten.SelectedIndexChanged += new System.EventHandler(this.listB_producten_SelectedIndexChanged);
            // 
            // listview_producten
            // 
            this.listview_producten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listview_producten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview_producten.Location = new System.Drawing.Point(3, 285);
            this.listview_producten.Name = "listview_producten";
            this.listview_producten.Size = new System.Drawing.Size(500, 191);
            this.listview_producten.TabIndex = 5;
            this.listview_producten.UseCompatibleStateImageBehavior = false;
            this.listview_producten.View = System.Windows.Forms.View.Details;
            this.listview_producten.SelectedIndexChanged += new System.EventHandler(this.listview_producten_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gekozen producten";
            this.columnHeader1.Width = 395;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 100;
            // 
            // menuStrip_bestelling
            // 
            this.menuStrip_bestelling.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lunchToolStripMenuItem,
            this.dinnerToolStripMenuItem,
            this.drankToolStripMenuItem});
            this.menuStrip_bestelling.Location = new System.Drawing.Point(3, 3);
            this.menuStrip_bestelling.Name = "menuStrip_bestelling";
            this.menuStrip_bestelling.Size = new System.Drawing.Size(501, 24);
            this.menuStrip_bestelling.TabIndex = 3;
            this.menuStrip_bestelling.Text = "menuStrip1";
            // 
            // lunchToolStripMenuItem
            // 
            this.lunchToolStripMenuItem.Name = "lunchToolStripMenuItem";
            this.lunchToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.lunchToolStripMenuItem.Text = "Lunch";
            this.lunchToolStripMenuItem.Click += new System.EventHandler(this.lunchToolStripMenuItem_Click_1);
            // 
            // dinnerToolStripMenuItem
            // 
            this.dinnerToolStripMenuItem.Name = "dinnerToolStripMenuItem";
            this.dinnerToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.dinnerToolStripMenuItem.Text = "Dinner";
            this.dinnerToolStripMenuItem.Click += new System.EventHandler(this.dinnerToolStripMenuItem_Click_1);
            // 
            // drankToolStripMenuItem
            // 
            this.drankToolStripMenuItem.Name = "drankToolStripMenuItem";
            this.drankToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.drankToolStripMenuItem.Text = "Drank";
            this.drankToolStripMenuItem.Click += new System.EventHandler(this.drankToolStripMenuItem_Click_1);
            // 
            // tabB_TafelOverzicht
            // 
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel10);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel9);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel8);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel7);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel6);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel5);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel4);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel3);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel2);
            this.tabB_TafelOverzicht.Controls.Add(this.btn_Tafel1);
            this.tabB_TafelOverzicht.Location = new System.Drawing.Point(4, 22);
            this.tabB_TafelOverzicht.Name = "tabB_TafelOverzicht";
            this.tabB_TafelOverzicht.Padding = new System.Windows.Forms.Padding(3);
            this.tabB_TafelOverzicht.Size = new System.Drawing.Size(507, 564);
            this.tabB_TafelOverzicht.TabIndex = 1;
            this.tabB_TafelOverzicht.Text = "TafelOverzicht";
            this.tabB_TafelOverzicht.UseVisualStyleBackColor = true;
            // 
            // btn_Tafel10
            // 
            this.btn_Tafel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel10.BackgroundImage")));
            this.btn_Tafel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel10.Location = new System.Drawing.Point(260, 426);
            this.btn_Tafel10.Name = "btn_Tafel10";
            this.btn_Tafel10.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel10.TabIndex = 20;
            this.btn_Tafel10.Tag = "tafel10";
            this.btn_Tafel10.Text = "10";
            this.btn_Tafel10.UseVisualStyleBackColor = true;
            this.btn_Tafel10.MouseHover += new System.EventHandler(this.btn_Tafel10_MouseHover);
            // 
            // btn_Tafel9
            // 
            this.btn_Tafel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel9.BackgroundImage")));
            this.btn_Tafel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel9.Location = new System.Drawing.Point(45, 426);
            this.btn_Tafel9.Name = "btn_Tafel9";
            this.btn_Tafel9.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel9.TabIndex = 19;
            this.btn_Tafel9.Tag = "tafel9";
            this.btn_Tafel9.Text = "9";
            this.btn_Tafel9.UseVisualStyleBackColor = true;
            this.btn_Tafel9.MouseHover += new System.EventHandler(this.btn_Tafel9_MouseHover);
            // 
            // btn_Tafel8
            // 
            this.btn_Tafel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel8.BackgroundImage")));
            this.btn_Tafel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel8.Location = new System.Drawing.Point(260, 324);
            this.btn_Tafel8.Name = "btn_Tafel8";
            this.btn_Tafel8.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel8.TabIndex = 18;
            this.btn_Tafel8.Tag = "tafel8";
            this.btn_Tafel8.Text = "8";
            this.btn_Tafel8.UseVisualStyleBackColor = true;
            this.btn_Tafel8.MouseHover += new System.EventHandler(this.btn_Tafel8_MouseHover);
            // 
            // btn_Tafel7
            // 
            this.btn_Tafel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel7.BackgroundImage")));
            this.btn_Tafel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel7.Location = new System.Drawing.Point(45, 324);
            this.btn_Tafel7.Name = "btn_Tafel7";
            this.btn_Tafel7.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel7.TabIndex = 17;
            this.btn_Tafel7.Tag = "tafel7";
            this.btn_Tafel7.Text = "7";
            this.btn_Tafel7.UseVisualStyleBackColor = true;
            this.btn_Tafel7.MouseHover += new System.EventHandler(this.btn_Tafel7_MouseHover);
            // 
            // btn_Tafel6
            // 
            this.btn_Tafel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel6.BackgroundImage")));
            this.btn_Tafel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel6.Location = new System.Drawing.Point(260, 222);
            this.btn_Tafel6.Name = "btn_Tafel6";
            this.btn_Tafel6.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel6.TabIndex = 16;
            this.btn_Tafel6.Tag = "tafel6";
            this.btn_Tafel6.Text = "6";
            this.btn_Tafel6.UseVisualStyleBackColor = true;
            this.btn_Tafel6.MouseHover += new System.EventHandler(this.btn_Tafel6_MouseHover);
            // 
            // btn_Tafel5
            // 
            this.btn_Tafel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel5.BackgroundImage")));
            this.btn_Tafel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel5.Location = new System.Drawing.Point(45, 222);
            this.btn_Tafel5.Name = "btn_Tafel5";
            this.btn_Tafel5.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel5.TabIndex = 15;
            this.btn_Tafel5.Tag = "tafel5";
            this.btn_Tafel5.Text = "5";
            this.btn_Tafel5.UseVisualStyleBackColor = true;
            this.btn_Tafel5.MouseHover += new System.EventHandler(this.btn_Tafel5_MouseHover);
            // 
            // btn_Tafel4
            // 
            this.btn_Tafel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel4.BackgroundImage")));
            this.btn_Tafel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel4.Location = new System.Drawing.Point(260, 120);
            this.btn_Tafel4.Name = "btn_Tafel4";
            this.btn_Tafel4.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel4.TabIndex = 14;
            this.btn_Tafel4.Tag = "tafel4";
            this.btn_Tafel4.Text = "4";
            this.btn_Tafel4.UseVisualStyleBackColor = true;
            this.btn_Tafel4.MouseHover += new System.EventHandler(this.btn_Tafel4_MouseHover);
            // 
            // btn_Tafel3
            // 
            this.btn_Tafel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel3.BackgroundImage")));
            this.btn_Tafel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel3.Location = new System.Drawing.Point(45, 120);
            this.btn_Tafel3.Name = "btn_Tafel3";
            this.btn_Tafel3.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel3.TabIndex = 13;
            this.btn_Tafel3.Tag = "tafel3";
            this.btn_Tafel3.Text = "3";
            this.btn_Tafel3.UseVisualStyleBackColor = true;
            this.btn_Tafel3.MouseHover += new System.EventHandler(this.btn_Tafel3_MouseHover);
            // 
            // btn_Tafel2
            // 
            this.btn_Tafel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Tafel2.BackgroundImage")));
            this.btn_Tafel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel2.Location = new System.Drawing.Point(260, 18);
            this.btn_Tafel2.Name = "btn_Tafel2";
            this.btn_Tafel2.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel2.TabIndex = 12;
            this.btn_Tafel2.Tag = "tafel2";
            this.btn_Tafel2.Text = "2";
            this.btn_Tafel2.UseVisualStyleBackColor = true;
            this.btn_Tafel2.MouseEnter += new System.EventHandler(this.btn_Tafel2_MouseEnter);
            this.btn_Tafel2.MouseHover += new System.EventHandler(this.btn_Tafel2_MouseHover);
            // 
            // btn_Tafel1
            // 
            this.btn_Tafel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tafel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Tafel1.Location = new System.Drawing.Point(45, 18);
            this.btn_Tafel1.Name = "btn_Tafel1";
            this.btn_Tafel1.Size = new System.Drawing.Size(105, 96);
            this.btn_Tafel1.TabIndex = 11;
            this.btn_Tafel1.Tag = "tafel1";
            this.btn_Tafel1.Text = "1";
            this.btn_Tafel1.UseVisualStyleBackColor = true;
            this.btn_Tafel1.Click += new System.EventHandler(this.btn_Tafel1_Click);
            this.btn_Tafel1.MouseEnter += new System.EventHandler(this.btn_Tafel1_MouseEnter);
            this.btn_Tafel1.MouseHover += new System.EventHandler(this.btn_Tafel1_MouseHover);
            // 
            // btn_Loguit
            // 
            this.btn_Loguit.Location = new System.Drawing.Point(2, 595);
            this.btn_Loguit.Name = "btn_Loguit";
            this.btn_Loguit.Size = new System.Drawing.Size(75, 23);
            this.btn_Loguit.TabIndex = 1;
            this.btn_Loguit.Text = "Log uit";
            this.btn_Loguit.UseVisualStyleBackColor = true;
            this.btn_Loguit.Click += new System.EventHandler(this.btn_Loguit_Click);
            // 
            // lbl_IngelogdeMedewerker
            // 
            this.lbl_IngelogdeMedewerker.AutoSize = true;
            this.lbl_IngelogdeMedewerker.Location = new System.Drawing.Point(417, 604);
            this.lbl_IngelogdeMedewerker.Name = "lbl_IngelogdeMedewerker";
            this.lbl_IngelogdeMedewerker.Size = new System.Drawing.Size(0, 13);
            this.lbl_IngelogdeMedewerker.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 25);
            this.panel1.TabIndex = 3;
            // 
            // BedieningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_IngelogdeMedewerker);
            this.Controls.Add(this.btn_Loguit);
            this.Controls.Add(this.tabB_volledig);
            this.Name = "BedieningForm";
            this.Text = "BedieningForm";
            this.tabB_volledig.ResumeLayout(false);
            this.tabB_Bestellen1.ResumeLayout(false);
            this.tabB_Bestellen1.PerformLayout();
            this.menuStrip_bestelling.ResumeLayout(false);
            this.menuStrip_bestelling.PerformLayout();
            this.tabB_TafelOverzicht.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabB_volledig;
        private System.Windows.Forms.TabPage tabB_Bestellen1;
        private System.Windows.Forms.TabPage tabB_TafelOverzicht;
        private System.Windows.Forms.Button btn_Tafel1;
        private System.Windows.Forms.Button btn_Tafel2;
        private System.Windows.Forms.Button btn_Tafel3;
        private System.Windows.Forms.Button btn_Tafel4;
        private System.Windows.Forms.Button btn_Tafel5;
        private System.Windows.Forms.Button btn_Tafel6;
        private System.Windows.Forms.Button btn_Tafel7;
        private System.Windows.Forms.Button btn_Tafel8;
        private System.Windows.Forms.Button btn_Tafel9;
        private System.Windows.Forms.Button btn_Tafel10;
        private System.Windows.Forms.MenuStrip menuStrip_bestelling;
        private System.Windows.Forms.ToolStripMenuItem lunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drankToolStripMenuItem;
        private System.Windows.Forms.ListView listview_producten;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox listB_producten;
        private System.Windows.Forms.Button btn_returnOverzicht;
        private System.Windows.Forms.Button btn_bevestig_Bestelling;
        private System.Windows.Forms.Button btn_Loguit;
        private System.Windows.Forms.Label lbl_IngelogdeMedewerker;
        private System.Windows.Forms.Panel panel1;
    }
}