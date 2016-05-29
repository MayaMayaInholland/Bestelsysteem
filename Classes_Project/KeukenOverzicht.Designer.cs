namespace Classes_Project
{
    partial class KeukenOverzicht
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
            this.label42 = new System.Windows.Forms.Label();
            this.Overzichtbar = new System.Windows.Forms.TabControl();
            this.BarNu = new System.Windows.Forms.TabPage();
            this.Geschiedenis = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.Overzichtbar.SuspendLayout();
            this.Geschiedenis.SuspendLayout();
            this.SuspendLayout();
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(4, 10);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(148, 44);
            this.label42.TabIndex = 104;
            this.label42.Text = "Keuken";
            // 
            // Overzichtbar
            // 
            this.Overzichtbar.Controls.Add(this.BarNu);
            this.Overzichtbar.Controls.Add(this.Geschiedenis);
            this.Overzichtbar.Location = new System.Drawing.Point(12, 60);
            this.Overzichtbar.Name = "Overzichtbar";
            this.Overzichtbar.SelectedIndex = 0;
            this.Overzichtbar.Size = new System.Drawing.Size(929, 704);
            this.Overzichtbar.TabIndex = 103;
            // 
            // BarNu
            // 
            this.BarNu.AutoScroll = true;
            this.BarNu.Location = new System.Drawing.Point(4, 22);
            this.BarNu.Name = "BarNu";
            this.BarNu.Padding = new System.Windows.Forms.Padding(3);
            this.BarNu.Size = new System.Drawing.Size(921, 678);
            this.BarNu.TabIndex = 0;
            this.BarNu.Text = "Nu";
            this.BarNu.UseVisualStyleBackColor = true;
            // 
            // Geschiedenis
            // 
            this.Geschiedenis.AutoScroll = true;
            this.Geschiedenis.Controls.Add(this.label23);
            this.Geschiedenis.Location = new System.Drawing.Point(4, 22);
            this.Geschiedenis.Name = "Geschiedenis";
            this.Geschiedenis.Padding = new System.Windows.Forms.Padding(3);
            this.Geschiedenis.Size = new System.Drawing.Size(921, 678);
            this.Geschiedenis.TabIndex = 2;
            this.Geschiedenis.Text = "Geschiedenis";
            this.Geschiedenis.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(93, 1030);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 70;
            this.label23.Text = "label23";
            // 
            // KeukenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 741);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.Overzichtbar);
            this.Name = "KeukenOverzicht";
            this.Text = "KeukenOverzicht";
            this.Overzichtbar.ResumeLayout(false);
            this.Geschiedenis.ResumeLayout(false);
            this.Geschiedenis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TabControl Overzichtbar;
        private System.Windows.Forms.TabPage BarNu;
        private System.Windows.Forms.TabPage Geschiedenis;
        private System.Windows.Forms.Label label23;
    }
}