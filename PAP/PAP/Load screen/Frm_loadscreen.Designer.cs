
namespace PAP
{
    partial class Frm_loadscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_loadscreen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.imagem_loadscreen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_loadscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(9, 267);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(501, 40);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // imagem_loadscreen
            // 
            this.imagem_loadscreen.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.imagem_loadscreen.Image = ((System.Drawing.Image)(resources.GetObject("imagem_loadscreen.Image")));
            this.imagem_loadscreen.Location = new System.Drawing.Point(12, 12);
            this.imagem_loadscreen.Name = "imagem_loadscreen";
            this.imagem_loadscreen.Size = new System.Drawing.Size(500, 249);
            this.imagem_loadscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imagem_loadscreen.TabIndex = 1;
            this.imagem_loadscreen.TabStop = false;
            this.imagem_loadscreen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_loadscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 315);
            this.Controls.Add(this.imagem_loadscreen);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_loadscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_loadscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_loadscreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox imagem_loadscreen;
        private System.Windows.Forms.Timer timer1;
    }
}

