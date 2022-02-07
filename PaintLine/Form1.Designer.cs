namespace PaintLine
{
    partial class Form1
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
            this.boxImage = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.picSelectRectangleRound = new System.Windows.Forms.PictureBox();
            this.picSelectCircle = new System.Windows.Forms.PictureBox();
            this.picSelectRectangle = new System.Windows.Forms.PictureBox();
            this.picSelectLine = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlColorSelected = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectRectangleRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boxImage
            // 
            this.boxImage.BackColor = System.Drawing.Color.White;
            this.boxImage.Location = new System.Drawing.Point(6, 122);
            this.boxImage.Name = "boxImage";
            this.boxImage.Size = new System.Drawing.Size(874, 577);
            this.boxImage.TabIndex = 1;
            this.boxImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.boxImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.boxImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.picSelectRectangleRound);
            this.pnlTitle.Controls.Add(this.picSelectCircle);
            this.pnlTitle.Controls.Add(this.picSelectRectangle);
            this.pnlTitle.Controls.Add(this.picSelectLine);
            this.pnlTitle.Controls.Add(this.pictureBox2);
            this.pnlTitle.Controls.Add(this.pnlColorSelected);
            this.pnlTitle.Controls.Add(this.pictureBox1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1459, 116);
            this.pnlTitle.TabIndex = 8;
            // 
            // picSelectRectangleRound
            // 
            this.picSelectRectangleRound.Image = global::PaintLine.Properties.Resources.no_selected_rectangle_round;
            this.picSelectRectangleRound.Location = new System.Drawing.Point(513, 32);
            this.picSelectRectangleRound.Name = "picSelectRectangleRound";
            this.picSelectRectangleRound.Size = new System.Drawing.Size(20, 20);
            this.picSelectRectangleRound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSelectRectangleRound.TabIndex = 11;
            this.picSelectRectangleRound.TabStop = false;
            this.picSelectRectangleRound.Click += new System.EventHandler(this.picSelectRectangleRound_Click);
            // 
            // picSelectCircle
            // 
            this.picSelectCircle.Image = global::PaintLine.Properties.Resources.no_selected_circle;
            this.picSelectCircle.Location = new System.Drawing.Point(475, 32);
            this.picSelectCircle.Name = "picSelectCircle";
            this.picSelectCircle.Size = new System.Drawing.Size(20, 20);
            this.picSelectCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSelectCircle.TabIndex = 12;
            this.picSelectCircle.TabStop = false;
            this.picSelectCircle.Click += new System.EventHandler(this.picSelectCircle_Click);
            // 
            // picSelectRectangle
            // 
            this.picSelectRectangle.Image = global::PaintLine.Properties.Resources.no_selected_rectangle;
            this.picSelectRectangle.Location = new System.Drawing.Point(494, 32);
            this.picSelectRectangle.Name = "picSelectRectangle";
            this.picSelectRectangle.Size = new System.Drawing.Size(20, 20);
            this.picSelectRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSelectRectangle.TabIndex = 11;
            this.picSelectRectangle.TabStop = false;
            this.picSelectRectangle.Click += new System.EventHandler(this.picSelectRectangle_Click);
            // 
            // picSelectLine
            // 
            this.picSelectLine.BackColor = System.Drawing.Color.Transparent;
            this.picSelectLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSelectLine.Image = global::PaintLine.Properties.Resources.no_selected_line;
            this.picSelectLine.Location = new System.Drawing.Point(434, 32);
            this.picSelectLine.Name = "picSelectLine";
            this.picSelectLine.Size = new System.Drawing.Size(20, 20);
            this.picSelectLine.TabIndex = 10;
            this.picSelectLine.TabStop = false;
            this.picSelectLine.Click += new System.EventHandler(this.picSelectLine_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::PaintLine.Properties.Resources.title_paint_right;
            this.pictureBox2.Location = new System.Drawing.Point(1239, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pnlColorSelected
            // 
            this.pnlColorSelected.Location = new System.Drawing.Point(787, 33);
            this.pnlColorSelected.Name = "pnlColorSelected";
            this.pnlColorSelected.Size = new System.Drawing.Size(28, 28);
            this.pnlColorSelected.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PaintLine.Properties.Resources.title_paint2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1250, 116);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PaintLine.Properties.Resources.back_paint;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1459, 746);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.boxImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectRectangleRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelectLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxImage;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlColorSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picSelectLine;
        private System.Windows.Forms.PictureBox picSelectRectangle;
        private System.Windows.Forms.PictureBox picSelectCircle;
        private System.Windows.Forms.PictureBox picSelectRectangleRound;
    }
}

