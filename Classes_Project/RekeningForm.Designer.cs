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
            this.listR_ViewRekening = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnR_Return = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listR_ViewRekening
            // 
            this.listR_ViewRekening.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listR_ViewRekening.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listR_ViewRekening.Location = new System.Drawing.Point(3, 1);
            this.listR_ViewRekening.Name = "listR_ViewRekening";
            this.listR_ViewRekening.Size = new System.Drawing.Size(508, 325);
            this.listR_ViewRekening.TabIndex = 0;
            this.listR_ViewRekening.UseCompatibleStateImageBehavior = false;
            this.listR_ViewRekening.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naam";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prijs";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Btw";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Aantal";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Totaal";
            this.columnHeader5.Width = 74;
            // 
            // lbl_Opmerkingen
            // 
            this.lbl_Opmerkingen.AutoSize = true;
            this.lbl_Opmerkingen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Opmerkingen.Location = new System.Drawing.Point(12, 343);
            this.lbl_Opmerkingen.Name = "lbl_Opmerkingen";
            this.lbl_Opmerkingen.Size = new System.Drawing.Size(150, 16);
            this.lbl_Opmerkingen.TabIndex = 1;
            this.lbl_Opmerkingen.Text = "Opmerkingen Service:";
            // 
            // lbl_Fooi
            // 
            this.lbl_Fooi.AutoSize = true;
            this.lbl_Fooi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fooi.Location = new System.Drawing.Point(364, 373);
            this.lbl_Fooi.Name = "lbl_Fooi";
            this.lbl_Fooi.Size = new System.Drawing.Size(40, 16);
            this.lbl_Fooi.TabIndex = 2;
            this.lbl_Fooi.Text = "Fooi:";
            // 
            // txt_Opmerkingen
            // 
            this.txt_Opmerkingen.Location = new System.Drawing.Point(15, 372);
            this.txt_Opmerkingen.Multiline = true;
            this.txt_Opmerkingen.Name = "txt_Opmerkingen";
            this.txt_Opmerkingen.Size = new System.Drawing.Size(188, 90);
            this.txt_Opmerkingen.TabIndex = 3;
            // 
            // txt_Fooi
            // 
            this.txt_Fooi.Location = new System.Drawing.Point(410, 372);
            this.txt_Fooi.Name = "txt_Fooi";
            this.txt_Fooi.Size = new System.Drawing.Size(47, 20);
            this.txt_Fooi.TabIndex = 4;
            // 
            // btn_ContantBetalen
            // 
            this.btn_ContantBetalen.Location = new System.Drawing.Point(350, 419);
            this.btn_ContantBetalen.Name = "btn_ContantBetalen";
            this.btn_ContantBetalen.Size = new System.Drawing.Size(107, 43);
            this.btn_ContantBetalen.TabIndex = 5;
            this.btn_ContantBetalen.Text = "Contant";
            this.btn_ContantBetalen.UseVisualStyleBackColor = true;
            this.btn_ContantBetalen.Click += new System.EventHandler(this.btn_ContantBetalen_Click);
            // 
            // btn_PinnenBetalen
            // 
            this.btn_PinnenBetalen.Location = new System.Drawing.Point(350, 482);
            this.btn_PinnenBetalen.Name = "btn_PinnenBetalen";
            this.btn_PinnenBetalen.Size = new System.Drawing.Size(107, 43);
            this.btn_PinnenBetalen.TabIndex = 6;
            this.btn_PinnenBetalen.Text = "Pinnen";
            this.btn_PinnenBetalen.UseVisualStyleBackColor = true;
            this.btn_PinnenBetalen.Click += new System.EventHandler(this.btn_PinnenBetalen_Click);
            // 
            // btn_CreditcardBetalen
            // 
            this.btn_CreditcardBetalen.Location = new System.Drawing.Point(350, 540);
            this.btn_CreditcardBetalen.Name = "btn_CreditcardBetalen";
            this.btn_CreditcardBetalen.Size = new System.Drawing.Size(107, 43);
            this.btn_CreditcardBetalen.TabIndex = 7;
            this.btn_CreditcardBetalen.Text = "CreditCard";
            this.btn_CreditcardBetalen.UseVisualStyleBackColor = true;
            this.btn_CreditcardBetalen.Click += new System.EventHandler(this.btn_CreditcardBetalen_Click);
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
            this.lbl_Toon_Totaal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Toon_Totaal.Location = new System.Drawing.Point(289, 340);
            this.lbl_Toon_Totaal.Name = "lbl_Toon_Totaal";
            this.lbl_Toon_Totaal.Size = new System.Drawing.Size(115, 16);
            this.lbl_Toon_Totaal.TabIndex = 9;
            this.lbl_Toon_Totaal.Text = "Totaal Rekening:";
            // 
            // lbl_Totaal
            // 
            this.lbl_Totaal.AutoSize = true;
            this.lbl_Totaal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Totaal.Location = new System.Drawing.Point(410, 340);
            this.lbl_Totaal.Name = "lbl_Totaal";
            this.lbl_Totaal.Size = new System.Drawing.Size(47, 16);
            this.lbl_Totaal.TabIndex = 10;
            this.lbl_Totaal.Text = "label2";
            // 
            // btnR_Return
            // 
            this.btnR_Return.Location = new System.Drawing.Point(12, 523);
            this.btnR_Return.Name = "btnR_Return";
            this.btnR_Return.Size = new System.Drawing.Size(159, 60);
            this.btnR_Return.TabIndex = 11;
            this.btnR_Return.Text = "GetTheHellOuttaHereButton";
            this.btnR_Return.UseVisualStyleBackColor = true;
            this.btnR_Return.Click += new System.EventHandler(this.btnR_Return_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(238, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(24, 306);
            this.panel1.TabIndex = 12;
            // 
            // RekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnR_Return);
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
            this.Controls.Add(this.listR_ViewRekening);
            this.Name = "RekeningForm";
            this.Text = "RekeningForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listR_ViewRekening;
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnR_Return;
        private System.Windows.Forms.Panel panel1;
    }
}