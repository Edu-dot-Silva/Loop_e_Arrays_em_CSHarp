namespace Projeto_Loop_e_Arrays
{
    partial class Frm_Tela2
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Rad_Contagens = new System.Windows.Forms.RadioButton();
            this.Rad_Exemplos = new System.Windows.Forms.RadioButton();
            this.rad_Vetores = new System.Windows.Forms.RadioButton();
            this.rad_Arrays = new System.Windows.Forms.RadioButton();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.rad_Atividades = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(267, 101);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(266, 25);
            this.Lbl_Titulo.TabIndex = 5;
            this.Lbl_Titulo.Text = "Estruturas de Repetição";
            // 
            // Rad_Contagens
            // 
            this.Rad_Contagens.AutoSize = true;
            this.Rad_Contagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rad_Contagens.Location = new System.Drawing.Point(317, 236);
            this.Rad_Contagens.Name = "Rad_Contagens";
            this.Rad_Contagens.Size = new System.Drawing.Size(105, 24);
            this.Rad_Contagens.TabIndex = 4;
            this.Rad_Contagens.Text = "Contagens";
            this.Rad_Contagens.UseVisualStyleBackColor = true;
            this.Rad_Contagens.CheckedChanged += new System.EventHandler(this.Rad_Contagens_CheckedChanged);
            // 
            // Rad_Exemplos
            // 
            this.Rad_Exemplos.AutoSize = true;
            this.Rad_Exemplos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rad_Exemplos.Location = new System.Drawing.Point(317, 173);
            this.Rad_Exemplos.Name = "Rad_Exemplos";
            this.Rad_Exemplos.Size = new System.Drawing.Size(96, 24);
            this.Rad_Exemplos.TabIndex = 3;
            this.Rad_Exemplos.Text = "Exemplos";
            this.Rad_Exemplos.UseVisualStyleBackColor = true;
            this.Rad_Exemplos.CheckedChanged += new System.EventHandler(this.Rad_Exemplos_CheckedChanged);
            // 
            // rad_Vetores
            // 
            this.rad_Vetores.AutoSize = true;
            this.rad_Vetores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rad_Vetores.Location = new System.Drawing.Point(317, 297);
            this.rad_Vetores.Name = "rad_Vetores";
            this.rad_Vetores.Size = new System.Drawing.Size(83, 24);
            this.rad_Vetores.TabIndex = 6;
            this.rad_Vetores.Text = "Vetores";
            this.rad_Vetores.UseVisualStyleBackColor = true;
            this.rad_Vetores.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_Arrays
            // 
            this.rad_Arrays.AutoSize = true;
            this.rad_Arrays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rad_Arrays.Location = new System.Drawing.Point(317, 357);
            this.rad_Arrays.Name = "rad_Arrays";
            this.rad_Arrays.Size = new System.Drawing.Size(72, 24);
            this.rad_Arrays.TabIndex = 7;
            this.rad_Arrays.Text = "Arrays";
            this.rad_Arrays.UseVisualStyleBackColor = true;
            this.rad_Arrays.CheckedChanged += new System.EventHandler(this.rad_Arrays_CheckedChanged);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(654, 402);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 8;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // rad_Atividades
            // 
            this.rad_Atividades.AutoSize = true;
            this.rad_Atividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rad_Atividades.Location = new System.Drawing.Point(317, 400);
            this.rad_Atividades.Name = "rad_Atividades";
            this.rad_Atividades.Size = new System.Drawing.Size(100, 24);
            this.rad_Atividades.TabIndex = 9;
            this.rad_Atividades.Text = "Atividades";
            this.rad_Atividades.UseVisualStyleBackColor = true;
            this.rad_Atividades.CheckedChanged += new System.EventHandler(this.rad_Atividades_CheckedChanged);
            // 
            // Frm_Tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rad_Atividades);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.rad_Arrays);
            this.Controls.Add(this.rad_Vetores);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Rad_Contagens);
            this.Controls.Add(this.Rad_Exemplos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Tela2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela 2";
            this.Load += new System.EventHandler(this.Frm_Tela2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.RadioButton Rad_Contagens;
        private System.Windows.Forms.RadioButton Rad_Exemplos;
        private System.Windows.Forms.RadioButton rad_Vetores;
        private System.Windows.Forms.RadioButton rad_Arrays;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.RadioButton rad_Atividades;
    }
}