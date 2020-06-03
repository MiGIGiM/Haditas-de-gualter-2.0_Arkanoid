namespace ProyectoArkanoid.Vista
{
    partial class GameControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableTTop = new System.Windows.Forms.TableLayoutPanel();
            this.picAlien = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableTTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).BeginInit();
            this.SuspendLayout();
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Transparent;
            this.picPaddle.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.paddle;
            this.picPaddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPaddle.Location = new System.Drawing.Point(141, 364);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(162, 30);
            this.picPaddle.TabIndex = 0;
            this.picPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.ball;
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBall.Location = new System.Drawing.Point(110, 221);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(22, 19);
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblScore.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Location = new System.Drawing.Point(472, 14);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 21);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "label1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(389, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score: ";
            // 
            // lblLives
            // 
            this.lblLives.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLives.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLives.Location = new System.Drawing.Point(107, 14);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(82, 21);
            this.lblLives.TabIndex = 3;
            this.lblLives.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Vida_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(74, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 38);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tableTTop
            // 
            this.tableTTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableTTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableTTop.ColumnCount = 5;
            this.tableTTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableTTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableTTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableTTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableTTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableTTop.Controls.Add(this.lblScore, 4, 0);
            this.tableTTop.Controls.Add(this.label3, 3, 0);
            this.tableTTop.Controls.Add(this.lblLives, 1, 0);
            this.tableTTop.Controls.Add(this.pictureBox2, 0, 0);
            this.tableTTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableTTop.Location = new System.Drawing.Point(0, 0);
            this.tableTTop.Name = "tableTTop";
            this.tableTTop.RowCount = 1;
            this.tableTTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTTop.Size = new System.Drawing.Size(629, 50);
            this.tableTTop.TabIndex = 6;
            // 
            // picAlien
            // 
            this.picAlien.BackColor = System.Drawing.Color.Transparent;
            this.picAlien.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Alien1;
            this.picAlien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAlien.Location = new System.Drawing.Point(3, 56);
            this.picAlien.Name = "picAlien";
            this.picAlien.Size = new System.Drawing.Size(53, 53);
            this.picAlien.TabIndex = 7;
            this.picAlien.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Fondo_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.picAlien);
            this.Controls.Add(this.tableTTop);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picPaddle);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(629, 405);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameControl_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableTTop.ResumeLayout(false);
            this.tableTTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableTTop;
        private System.Windows.Forms.PictureBox picAlien;
        private System.Windows.Forms.Timer timer1;
    }
}
