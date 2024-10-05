namespace Projeto_Loop_e_Arrays
{
    partial class frm_lacos
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
            this.lbl_vetores = new System.Windows.Forms.Label();
            this.lbl_dia_da_semana = new System.Windows.Forms.Label();
            this.lbl_vet_sem_laco = new System.Windows.Forms.Label();
            this.lbl_vet_com_laco = new System.Windows.Forms.Label();
            this.lst_vet_sem_laco = new System.Windows.Forms.ListBox();
            this.lst_vet_com_laco = new System.Windows.Forms.ListBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_vetores
            // 
            this.lbl_vetores.AutoSize = true;
            this.lbl_vetores.Location = new System.Drawing.Point(371, 35);
            this.lbl_vetores.Name = "lbl_vetores";
            this.lbl_vetores.Size = new System.Drawing.Size(43, 13);
            this.lbl_vetores.TabIndex = 0;
            this.lbl_vetores.Text = "Vetores";
            // 
            // lbl_dia_da_semana
            // 
            this.lbl_dia_da_semana.AutoSize = true;
            this.lbl_dia_da_semana.Location = new System.Drawing.Point(350, 65);
            this.lbl_dia_da_semana.Name = "lbl_dia_da_semana";
            this.lbl_dia_da_semana.Size = new System.Drawing.Size(86, 13);
            this.lbl_dia_da_semana.TabIndex = 1;
            this.lbl_dia_da_semana.Text = "DIas da Semana";
            // 
            // lbl_vet_sem_laco
            // 
            this.lbl_vet_sem_laco.AutoSize = true;
            this.lbl_vet_sem_laco.Location = new System.Drawing.Point(218, 103);
            this.lbl_vet_sem_laco.Name = "lbl_vet_sem_laco";
            this.lbl_vet_sem_laco.Size = new System.Drawing.Size(98, 13);
            this.lbl_vet_sem_laco.TabIndex = 2;
            this.lbl_vet_sem_laco.Text = "Vetor 5 - Sem Laço";
            // 
            // lbl_vet_com_laco
            // 
            this.lbl_vet_com_laco.AutoSize = true;
            this.lbl_vet_com_laco.Location = new System.Drawing.Point(496, 103);
            this.lbl_vet_com_laco.Name = "lbl_vet_com_laco";
            this.lbl_vet_com_laco.Size = new System.Drawing.Size(98, 13);
            this.lbl_vet_com_laco.TabIndex = 3;
            this.lbl_vet_com_laco.Text = "Vetor 5 - Com Laço";
            this.lbl_vet_com_laco.Click += new System.EventHandler(this.lbl_vet_com_laco_Click);
            // 
            // lst_vet_sem_laco
            // 
            this.lst_vet_sem_laco.FormattingEnabled = true;
            this.lst_vet_sem_laco.Location = new System.Drawing.Point(196, 128);
            this.lst_vet_sem_laco.Name = "lst_vet_sem_laco";
            this.lst_vet_sem_laco.Size = new System.Drawing.Size(177, 251);
            this.lst_vet_sem_laco.TabIndex = 4;
            // 
            // lst_vet_com_laco
            // 
            this.lst_vet_com_laco.FormattingEnabled = true;
            this.lst_vet_com_laco.Location = new System.Drawing.Point(474, 128);
            this.lst_vet_com_laco.Name = "lst_vet_com_laco";
            this.lst_vet_com_laco.Size = new System.Drawing.Size(177, 251);
            this.lst_vet_com_laco.TabIndex = 5;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(713, 415);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 6;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_lacos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.lst_vet_com_laco);
            this.Controls.Add(this.lst_vet_sem_laco);
            this.Controls.Add(this.lbl_vet_com_laco);
            this.Controls.Add(this.lbl_vet_sem_laco);
            this.Controls.Add(this.lbl_dia_da_semana);
            this.Controls.Add(this.lbl_vetores);
            this.Name = "frm_lacos";
            this.Text = "Vetor 5 - Com Laço";
            this.Load += new System.EventHandler(this.frm_lacos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_vetores;
        private System.Windows.Forms.Label lbl_dia_da_semana;
        private System.Windows.Forms.Label lbl_vet_sem_laco;
        private System.Windows.Forms.Label lbl_vet_com_laco;
        private System.Windows.Forms.ListBox lst_vet_sem_laco;
        private System.Windows.Forms.ListBox lst_vet_com_laco;
        private System.Windows.Forms.Button btn_voltar;
    }
}