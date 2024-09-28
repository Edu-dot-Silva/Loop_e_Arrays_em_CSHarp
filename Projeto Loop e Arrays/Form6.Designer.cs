namespace Projeto_Loop_e_Arrays
{
    partial class frm_matriz
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
            this.lbl_matriz = new System.Windows.Forms.Label();
            this.lbl_Bidmensional = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.lbl_matriz1 = new System.Windows.Forms.Label();
            this.lbl_matriz2 = new System.Windows.Forms.Label();
            this.lst_matriz1 = new System.Windows.Forms.ListBox();
            this.lst_matriz2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_matriz
            // 
            this.lbl_matriz.AutoSize = true;
            this.lbl_matriz.Location = new System.Drawing.Point(244, 32);
            this.lbl_matriz.Name = "lbl_matriz";
            this.lbl_matriz.Size = new System.Drawing.Size(46, 13);
            this.lbl_matriz.TabIndex = 0;
            this.lbl_matriz.Text = "Matrizes";
            // 
            // lbl_Bidmensional
            // 
            this.lbl_Bidmensional.AutoSize = true;
            this.lbl_Bidmensional.Location = new System.Drawing.Point(244, 63);
            this.lbl_Bidmensional.Name = "lbl_Bidmensional";
            this.lbl_Bidmensional.Size = new System.Drawing.Size(73, 13);
            this.lbl_Bidmensional.TabIndex = 1;
            this.lbl_Bidmensional.Text = "BiDimensional";
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(611, 32);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // lbl_matriz1
            // 
            this.lbl_matriz1.AutoSize = true;
            this.lbl_matriz1.Location = new System.Drawing.Point(192, 129);
            this.lbl_matriz1.Name = "lbl_matriz1";
            this.lbl_matriz1.Size = new System.Drawing.Size(44, 13);
            this.lbl_matriz1.TabIndex = 3;
            this.lbl_matriz1.Text = "Matriz 1";
            // 
            // lbl_matriz2
            // 
            this.lbl_matriz2.AutoSize = true;
            this.lbl_matriz2.Location = new System.Drawing.Point(485, 129);
            this.lbl_matriz2.Name = "lbl_matriz2";
            this.lbl_matriz2.Size = new System.Drawing.Size(44, 13);
            this.lbl_matriz2.TabIndex = 4;
            this.lbl_matriz2.Text = "Matriz 2";
            // 
            // lst_matriz1
            // 
            this.lst_matriz1.FormattingEnabled = true;
            this.lst_matriz1.Location = new System.Drawing.Point(139, 169);
            this.lst_matriz1.Name = "lst_matriz1";
            this.lst_matriz1.Size = new System.Drawing.Size(178, 212);
            this.lst_matriz1.TabIndex = 5;
            // 
            // lst_matriz2
            // 
            this.lst_matriz2.FormattingEnabled = true;
            this.lst_matriz2.Location = new System.Drawing.Point(414, 169);
            this.lst_matriz2.Name = "lst_matriz2";
            this.lst_matriz2.Size = new System.Drawing.Size(178, 212);
            this.lst_matriz2.TabIndex = 6;
            // 
            // frm_matriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_matriz2);
            this.Controls.Add(this.lst_matriz1);
            this.Controls.Add(this.lbl_matriz2);
            this.Controls.Add(this.lbl_matriz1);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.lbl_Bidmensional);
            this.Controls.Add(this.lbl_matriz);
            this.Name = "frm_matriz";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_matriz;
        private System.Windows.Forms.Label lbl_Bidmensional;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Label lbl_matriz1;
        private System.Windows.Forms.Label lbl_matriz2;
        private System.Windows.Forms.ListBox lst_matriz1;
        private System.Windows.Forms.ListBox lst_matriz2;
    }
}