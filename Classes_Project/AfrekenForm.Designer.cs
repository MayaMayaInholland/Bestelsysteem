namespace Classes_Project
{
    partial class AfrekenForm
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_contant_betalen = new System.Windows.Forms.Button();
            this.btn_pin_betalen = new System.Windows.Forms.Button();
            this.btn_credit_betalen = new System.Windows.Forms.Button();
            this.lbl_opmerking = new System.Windows.Forms.Label();
            this.txt_opmerking = new System.Windows.Forms.TextBox();
            this.txt_fooi = new System.Windows.Forms.TextBox();
            this.lbl_fooi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(397, 28);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(55, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 198);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_contant_betalen
            // 
            this.btn_contant_betalen.Location = new System.Drawing.Point(65, 383);
            this.btn_contant_betalen.Name = "btn_contant_betalen";
            this.btn_contant_betalen.Size = new System.Drawing.Size(75, 23);
            this.btn_contant_betalen.TabIndex = 2;
            this.btn_contant_betalen.Text = "Contant";
            this.btn_contant_betalen.UseVisualStyleBackColor = true;
            // 
            // btn_pin_betalen
            // 
            this.btn_pin_betalen.Location = new System.Drawing.Point(210, 383);
            this.btn_pin_betalen.Name = "btn_pin_betalen";
            this.btn_pin_betalen.Size = new System.Drawing.Size(75, 23);
            this.btn_pin_betalen.TabIndex = 3;
            this.btn_pin_betalen.Text = "Pin";
            this.btn_pin_betalen.UseVisualStyleBackColor = true;
            // 
            // btn_credit_betalen
            // 
            this.btn_credit_betalen.Location = new System.Drawing.Point(340, 383);
            this.btn_credit_betalen.Name = "btn_credit_betalen";
            this.btn_credit_betalen.Size = new System.Drawing.Size(75, 23);
            this.btn_credit_betalen.TabIndex = 4;
            this.btn_credit_betalen.Text = "Creditcard";
            this.btn_credit_betalen.UseVisualStyleBackColor = true;
            // 
            // lbl_opmerking
            // 
            this.lbl_opmerking.AutoSize = true;
            this.lbl_opmerking.Location = new System.Drawing.Point(31, 316);
            this.lbl_opmerking.Name = "lbl_opmerking";
            this.lbl_opmerking.Size = new System.Drawing.Size(61, 13);
            this.lbl_opmerking.TabIndex = 5;
            this.lbl_opmerking.Text = "Opmerking:";
            // 
            // txt_opmerking
            // 
            this.txt_opmerking.Location = new System.Drawing.Point(122, 316);
            this.txt_opmerking.Name = "txt_opmerking";
            this.txt_opmerking.Size = new System.Drawing.Size(100, 20);
            this.txt_opmerking.TabIndex = 6;
            // 
            // txt_fooi
            // 
            this.txt_fooi.Location = new System.Drawing.Point(340, 316);
            this.txt_fooi.Name = "txt_fooi";
            this.txt_fooi.Size = new System.Drawing.Size(100, 20);
            this.txt_fooi.TabIndex = 8;
            // 
            // lbl_fooi
            // 
            this.lbl_fooi.AutoSize = true;
            this.lbl_fooi.Location = new System.Drawing.Point(265, 319);
            this.lbl_fooi.Name = "lbl_fooi";
            this.lbl_fooi.Size = new System.Drawing.Size(30, 13);
            this.lbl_fooi.TabIndex = 7;
            this.lbl_fooi.Text = "Fooi:";
            // 
            // AfrekenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.txt_fooi);
            this.Controls.Add(this.lbl_fooi);
            this.Controls.Add(this.txt_opmerking);
            this.Controls.Add(this.lbl_opmerking);
            this.Controls.Add(this.btn_credit_betalen);
            this.Controls.Add(this.btn_pin_betalen);
            this.Controls.Add(this.btn_contant_betalen);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_exit);
            this.Name = "AfrekenForm";
            this.Text = "AfrekenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_contant_betalen;
        private System.Windows.Forms.Button btn_pin_betalen;
        private System.Windows.Forms.Button btn_credit_betalen;
        private System.Windows.Forms.Label lbl_opmerking;
        private System.Windows.Forms.TextBox txt_opmerking;
        private System.Windows.Forms.TextBox txt_fooi;
        private System.Windows.Forms.Label lbl_fooi;
    }
}