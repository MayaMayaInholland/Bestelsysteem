namespace Classes_Project
{
    partial class BarOverzicht
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
            this.Overzichtbar = new System.Windows.Forms.TabControl();
            this.BarNu = new System.Windows.Forms.TabPage();
            this.Geschiedenis = new System.Windows.Forms.TabPage();
            this.kop = new System.Windows.Forms.Label();
            this.btn_Loguit = new System.Windows.Forms.Button();
            this.lbl_IngelogdeMedewerker = new System.Windows.Forms.Label();
            this.Overzichtbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Overzichtbar
            // 
            this.Overzichtbar.Controls.Add(this.BarNu);
            this.Overzichtbar.Controls.Add(this.Geschiedenis);
            this.Overzichtbar.Location = new System.Drawing.Point(12, 58);
            this.Overzichtbar.Name = "Overzichtbar";
            this.Overzichtbar.SelectedIndex = 0;
            this.Overzichtbar.Size = new System.Drawing.Size(929, 500);
            this.Overzichtbar.TabIndex = 0;
            // 
            // BarNu
            // 
            this.BarNu.AutoScroll = true;
            this.BarNu.Location = new System.Drawing.Point(4, 22);
            this.BarNu.Name = "BarNu";
            this.BarNu.Padding = new System.Windows.Forms.Padding(3);
            this.BarNu.Size = new System.Drawing.Size(921, 474);
            this.BarNu.TabIndex = 0;
            this.BarNu.Text = "Nu";
            this.BarNu.UseVisualStyleBackColor = true;
            // 
            // Geschiedenis
            // 
            this.Geschiedenis.AutoScroll = true;
            this.Geschiedenis.Location = new System.Drawing.Point(4, 22);
            this.Geschiedenis.Name = "Geschiedenis";
            this.Geschiedenis.Padding = new System.Windows.Forms.Padding(3);
            this.Geschiedenis.Size = new System.Drawing.Size(921, 474);
            this.Geschiedenis.TabIndex = 2;
            this.Geschiedenis.Text = "Geschiedenis";
            this.Geschiedenis.UseVisualStyleBackColor = true;
            // 
            // kop
            // 
            this.kop.AutoSize = true;
            this.kop.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kop.Location = new System.Drawing.Point(4, 9);
            this.kop.Name = "kop";
            this.kop.Size = new System.Drawing.Size(79, 44);
            this.kop.TabIndex = 102;
            this.kop.Text = "Bar";
            // 
            // btn_Loguit
            // 
            this.btn_Loguit.Location = new System.Drawing.Point(16, 564);
            this.btn_Loguit.Name = "btn_Loguit";
            this.btn_Loguit.Size = new System.Drawing.Size(75, 23);
            this.btn_Loguit.TabIndex = 103;
            this.btn_Loguit.Text = "Log uit";
            this.btn_Loguit.UseVisualStyleBackColor = true;
            this.btn_Loguit.Click += new System.EventHandler(this.btn_Loguit_Click);
            // 
            // lbl_IngelogdeMedewerker
            // 
            this.lbl_IngelogdeMedewerker.AutoSize = true;
            this.lbl_IngelogdeMedewerker.Location = new System.Drawing.Point(863, 569);
            this.lbl_IngelogdeMedewerker.Name = "lbl_IngelogdeMedewerker";
            this.lbl_IngelogdeMedewerker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_IngelogdeMedewerker.Size = new System.Drawing.Size(0, 13);
            this.lbl_IngelogdeMedewerker.TabIndex = 104;
            // 
            // BarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 597);
            this.Controls.Add(this.lbl_IngelogdeMedewerker);
            this.Controls.Add(this.btn_Loguit);
            this.Controls.Add(this.kop);
            this.Controls.Add(this.Overzichtbar);
            this.Name = "BarOverzicht";
            this.Text = "BarOverzicht";
            this.Overzichtbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Overzichtbar;
        private System.Windows.Forms.TabPage BarNu;
        private System.Windows.Forms.TabPage Geschiedenis;
        private System.Windows.Forms.Label kop;
        private System.Windows.Forms.Button btn_Loguit;
        private System.Windows.Forms.Label lbl_IngelogdeMedewerker;
    }
}