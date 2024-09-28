namespace Projeto_Loop_e_Arrays
{
    partial class frm_contagem
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
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_contagem2 = new System.Windows.Forms.ListBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_contagem1 = new System.Windows.Forms.ListBox();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_voltar.Location = new System.Drawing.Point(657, 33);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 33);
            this.btn_voltar.TabIndex = 60;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(349, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Contagem 2";
            // 
            // lst_contagem2
            // 
            this.lst_contagem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_contagem2.FormattingEnabled = true;
            this.lst_contagem2.ItemHeight = 20;
            this.lst_contagem2.Location = new System.Drawing.Point(353, 117);
            this.lst_contagem2.Name = "lst_contagem2";
            this.lst_contagem2.Size = new System.Drawing.Size(199, 264);
            this.lst_contagem2.TabIndex = 58;
            // 
            // txt_numero2
            // 
            this.txt_numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero2.Location = new System.Drawing.Point(493, 85);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(58, 26);
            this.txt_numero2.TabIndex = 57;
            this.txt_numero2.TextChanged += new System.EventHandler(this.txt_numero2_TextChanged);
            this.txt_numero2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Digite um número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(93, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Contagem 1";
            // 
            // lst_contagem1
            // 
            this.lst_contagem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_contagem1.FormattingEnabled = true;
            this.lst_contagem1.ItemHeight = 20;
            this.lst_contagem1.Location = new System.Drawing.Point(96, 117);
            this.lst_contagem1.Name = "lst_contagem1";
            this.lst_contagem1.Size = new System.Drawing.Size(199, 264);
            this.lst_contagem1.TabIndex = 54;
            // 
            // txt_numero1
            // 
            this.txt_numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero1.Location = new System.Drawing.Point(237, 85);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(58, 26);
            this.txt_numero1.TabIndex = 53;
            this.txt_numero1.TextChanged += new System.EventHandler(this.txt_numero1_TextChanged);
            this.txt_numero1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Digite um número:";
            // 
            // frm_contagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lst_contagem2);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_contagem1);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.label1);
            this.Name = "frm_contagem";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_contagem2;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_contagem1;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.Label label1;
    }
}