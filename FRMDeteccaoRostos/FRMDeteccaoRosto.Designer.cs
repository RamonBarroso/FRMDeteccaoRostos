namespace FRMDeteccaoRostos
{
    partial class FRMDeteccaoRosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDeteccaoRosto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.iniciarWebCamToolStripMenuItem,
            this.pararWebCamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // iniciarWebCamToolStripMenuItem
            // 
            this.iniciarWebCamToolStripMenuItem.Name = "iniciarWebCamToolStripMenuItem";
            this.iniciarWebCamToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.iniciarWebCamToolStripMenuItem.Text = "Iniciar WebCam";
            this.iniciarWebCamToolStripMenuItem.Click += new System.EventHandler(this.iniciarWebCamToolStripMenuItem_Click);
            // 
            // pararWebCamToolStripMenuItem
            // 
            this.pararWebCamToolStripMenuItem.Name = "pararWebCamToolStripMenuItem";
            this.pararWebCamToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.pararWebCamToolStripMenuItem.Text = "Parar WebCam";
            this.pararWebCamToolStripMenuItem.Click += new System.EventHandler(this.pararWebCamToolStripMenuItem_Click);
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 33);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(800, 417);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // FRMDeteccaoRosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = global::FRMDeteccaoRostos.Properties.Resources._1150652;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMDeteccaoRosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detecção de Rostos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ToolStripMenuItem iniciarWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararWebCamToolStripMenuItem;
    }
}

