namespace Classes_Project
{
    partial class RekeningForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbl_Opmerkingen = new System.Windows.Forms.Label();
            this.lbl_Fooi = new System.Windows.Forms.Label();
            this.txt_Opmerkingen = new System.Windows.Forms.TextBox();
            this.txt_Fooi = new System.Windows.Forms.TextBox();
            this.btn_ContantBetalen = new System.Windows.Forms.Button();
            this.btn_PinnenBetalen = new System.Windows.Forms.Button();
            this.btn_CreditcardBetalen = new System.Windows.Forms.Button();
            this.lbl_IngelogdeMedewerker = new System.Windows.Forms.Label();
            this.lbl_Toon_Totaal = new System.Windows.Forms.Label();
            this.lbl_Totaal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(35, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(452, 387);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Opmerkingen
            // 
            this.lbl_Opmerkingen.AutoSize = true;
            this.lbl_Opmerkingen.Location = new System.Drawing.Point(87, 460);
            this.lbl_Opmerkingen.Name = "lbl_Opmerkingen";
            this.lbl_Opmerkingen.Size = new System.Drawing.Size(73, 13);
            this.lbl_Opmerkingen.TabIndex = 1;
            this.lbl_Opmerkingen.Text = "Opmerkingen:";
            // 
            // lbl_Fooi
            // 
            this.lbl_Fooi.AutoSize = true;
            this.lbl_Fooi.Location = new System.Drawing.Point(374, 460);
            this.lbl_Fooi.Name = "lbl_Fooi";
            this.lbl_Fooi.Size = new System.Drawing.Size(30, 13);
            this.lbl_Fooi.TabIndex = 2;
            this.lbl_Fooi.Text = "Fooi:";
            // 
            // txt_Opmerkingen
            // 
            this.txt_Opmerkingen.Location = new System.Drawing.Point(73, 494);
            this.txt_Opmerkingen.Name = "txt_Opmerkingen";
            this.txt_Opmerkingen.Size = new System.Drawing.Size(100, 20);
            this.txt_Opmerkingen.TabIndex = 3;
            // 
            // txt_Fooi
            // 
            this.txt_Fooi.Location = new System.Drawing.Point(338, 493);
            this.txt_Fooi.Name = "txt_Fooi";
            this.txt_Fooi.Size = new System.Drawing.Size(100, 20);
            this.txt_Fooi.TabIndex = 4;
            // 
            // btn_ContantBetalen
            // 
            this.btn_ContantBetalen.Location = new System.Drawing.Point(85, 549);
            this.btn_ContantBetalen.Name = "btn_ContantBetalen";
            this.btn_ContantBetalen.Size = new System.Drawing.Size(75, 23);
            this.btn_ContantBetalen.TabIndex = 5;
            this.btn_ContantBetalen.Text = "Contant";
            this.btn_ContantBetalen.UseVisualStyleBackColor = true;
            // 
            // btn_PinnenBetalen
            // 
            this.btn_PinnenBetalen.Location = new System.Drawing.Point(230, 549);
            this.btn_PinnenBetalen.Name = "btn_PinnenBetalen";
            this.btn_PinnenBetalen.Size = new System.Drawing.Size(75, 23);
            this.btn_PinnenBetalen.TabIndex = 6;
            this.btn_PinnenBetalen.Text = "Pinnen";
            this.btn_PinnenBetalen.UseVisualStyleBackColor = true;
            // 
            // btn_CreditcardBetalen
            // 
            this.btn_CreditcardBetalen.Location = new System.Drawing.Point(351, 549);
            this.btn_CreditcardBetalen.Name = "btn_CreditcardBetalen";
            this.btn_CreditcardBetalen.Size = new System.Drawing.Size(75, 23);
            this.btn_CreditcardBetalen.TabIndex = 7;
            this.btn_CreditcardBetalen.Text = "CreditCard";
            this.btn_CreditcardBetalen.UseVisualStyleBackColor = true;
            // 
            // lbl_IngelogdeMedewerker
            // 
            this.lbl_IngelogdeMedewerker.AutoSize = true;
            this.lbl_IngelogdeMedewerker.Location = new System.Drawing.Point(452, 596);
            this.lbl_IngelogdeMedewerker.Name = "lbl_IngelogdeMedewerker";
            this.lbl_IngelogdeMedewerker.Size = new System.Drawing.Size(35, 13);
            this.lbl_IngelogdeMedewerker.TabIndex = 8;
            this.lbl_IngelogdeMedewerker.Text = "label1";
            // 
            // lbl_Toon_Totaal
            // 
            this.lbl_Toon_Totaal.AutoSize = true;
            this.lbl_Toon_Totaal.Location = new System.Drawing.Point(202, 472);
            this.lbl_Toon_Totaal.Name = "lbl_Toon_Totaal";
            this.lbl_Toon_Totaal.Size = new System.Drawing.Size(40, 13);
            this.lbl_Toon_Totaal.TabIndex = 9;
            this.lbl_Toon_Totaal.Text = "Totaal:";
            // 
            // lbl_Totaal
            // 
            this.lbl_Totaal.AutoSize = true;
            this.lbl_Totaal.Location = new System.Drawing.Point(270, 472);
            this.lbl_Totaal.Name = "lbl_Totaal";
            this.lbl_Totaal.Size = new System.Drawing.Size(35, 13);
            this.lbl_Totaal.TabIndex = 10;
            this.lbl_Totaal.Text = "label2";
            // 
            // RekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 629);
            this.Controls.Add(this.lbl_Totaal);
            this.Controls.Add(this.lbl_Toon_Totaal);
            this.Controls.Add(this.lbl_IngelogdeMedewerker);
            this.Controls.Add(this.btn_CreditcardBetalen);
            this.Controls.Add(this.btn_PinnenBetalen);
            this.Controls.Add(this.btn_ContantBetalen);
            this.Controls.Add(this.txt_Fooi);
            this.Controls.Add(this.txt_Opmerkingen);
            this.Controls.Add(this.lbl_Fooi);
            this.Controls.Add(this.lbl_Opmerkingen);
            this.Controls.Add(this.listView1);
            this.Name = "RekeningForm";
            this.Text = "RekeningForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_Opmerkingen;
        private System.Windows.Forms.Label lbl_Fooi;
        private System.Windows.Forms.TextBox txt_Opmerkingen;
        private System.Windows.Forms.TextBox txt_Fooi;
        private System.Windows.Forms.Button btn_ContantBetalen;
        private System.Windows.Forms.Button btn_PinnenBetalen;
        private System.Windows.Forms.Button btn_CreditcardBetalen;
        private System.Windows.Forms.Label lbl_IngelogdeMedewerker;
        private System.Windows.Forms.Label lbl_Toon_Totaal;
        private System.Windows.Forms.Label lbl_Totaal;
    }
}