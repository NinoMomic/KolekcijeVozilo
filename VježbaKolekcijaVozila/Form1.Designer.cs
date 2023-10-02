namespace VježbaKolekcijaVozila
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
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtBoxBrojKotaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxGodinaProizvodnje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.txtBoxIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(68, 52);
            this.txtBoxModel.Multiline = true;
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(105, 40);
            this.txtBoxModel.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 125);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 40);
            this.textBox2.TabIndex = 1;
            // 
            // txtBoxBrojKotaca
            // 
            this.txtBoxBrojKotaca.Location = new System.Drawing.Point(68, 203);
            this.txtBoxBrojKotaca.Multiline = true;
            this.txtBoxBrojKotaca.Name = "txtBoxBrojKotaca";
            this.txtBoxBrojKotaca.Size = new System.Drawing.Size(105, 40);
            this.txtBoxBrojKotaca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // txtBoxGodinaProizvodnje
            // 
            this.txtBoxGodinaProizvodnje.AutoSize = true;
            this.txtBoxGodinaProizvodnje.Location = new System.Drawing.Point(68, 109);
            this.txtBoxGodinaProizvodnje.Name = "txtBoxGodinaProizvodnje";
            this.txtBoxGodinaProizvodnje.Size = new System.Drawing.Size(98, 13);
            this.txtBoxGodinaProizvodnje.TabIndex = 4;
            this.txtBoxGodinaProizvodnje.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj kotača";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(300, 52);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(105, 40);
            this.btnUnos.TabIndex = 6;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(300, 125);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(105, 40);
            this.btnObradi.TabIndex = 7;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.btnObradi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(300, 203);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(105, 40);
            this.btnIspisi.TabIndex = 8;
            this.btnIspisi.Text = "Ispiši";
            this.btnIspisi.UseVisualStyleBackColor = true;
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.Location = new System.Drawing.Point(517, 106);
            this.txtBoxIspis.Multiline = true;
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(233, 94);
            this.txtBoxIspis.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 319);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxGodinaProizvodnje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxBrojKotaca);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBoxModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtBoxBrojKotaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtBoxGodinaProizvodnje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.TextBox txtBoxIspis;
    }
}

