namespace KolekcijeVozilaXML
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
            this.txtBoxGodine = new System.Windows.Forms.TextBox();
            this.txtBoxBrojKotaca = new System.Windows.Forms.TextBox();
            this.txtBoxIspis = new System.Windows.Forms.TextBox();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(219, 55);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxModel.TabIndex = 0;
            // 
            // txtBoxGodine
            // 
            this.txtBoxGodine.Location = new System.Drawing.Point(219, 110);
            this.txtBoxGodine.Name = "txtBoxGodine";
            this.txtBoxGodine.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGodine.TabIndex = 1;
            // 
            // txtBoxBrojKotaca
            // 
            this.txtBoxBrojKotaca.Location = new System.Drawing.Point(219, 172);
            this.txtBoxBrojKotaca.Name = "txtBoxBrojKotaca";
            this.txtBoxBrojKotaca.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBrojKotaca.TabIndex = 2;
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.Location = new System.Drawing.Point(401, 55);
            this.txtBoxIspis.Multiline = true;
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(197, 144);
            this.txtBoxIspis.TabIndex = 3;
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(219, 224);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(100, 48);
            this.btnObrada.TabIndex = 4;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(335, 224);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(82, 48);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(444, 224);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(103, 48);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Godina proizvodnje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Broj kotaca:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.txtBoxBrojKotaca);
            this.Controls.Add(this.txtBoxGodine);
            this.Controls.Add(this.txtBoxModel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxModel;
        private System.Windows.Forms.TextBox txtBoxGodine;
        private System.Windows.Forms.TextBox txtBoxBrojKotaca;
        private System.Windows.Forms.TextBox txtBoxIspis;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

