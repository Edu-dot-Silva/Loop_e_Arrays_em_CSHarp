namespace Projeto_Loop_e_Arrays
{
    partial class Frm_Abertura
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Abertura));
            this.Wmp_Video = new AxWMPLib.AxWindowsMediaPlayer();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Video)).BeginInit();
            this.SuspendLayout();
            // 
            // Wmp_Video
            // 
            this.Wmp_Video.Enabled = true;
            this.Wmp_Video.Location = new System.Drawing.Point(2, 67);
            this.Wmp_Video.Name = "Wmp_Video";
            this.Wmp_Video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wmp_Video.OcxState")));
            this.Wmp_Video.Size = new System.Drawing.Size(693, 382);
            this.Wmp_Video.TabIndex = 0;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Titulo.Location = new System.Drawing.Point(185, 29);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(309, 25);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "PROJETO LOOP E ARRAYS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 14000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 442);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Wmp_Video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura";
            this.Load += new System.EventHandler(this.Frm_Abertura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Wmp_Video;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Timer timer1;
    }
}

