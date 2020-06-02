namespace ProyectoArkanoid.Vista
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picPaddle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picTop = new System.Windows.Forms.PictureBox();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAlien = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.ball;
            this.picBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBall.Location = new System.Drawing.Point(392, 233);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(22, 19);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Transparent;
            this.picPaddle.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.paddle;
            this.picPaddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPaddle.Location = new System.Drawing.Point(3, 3);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(190, 40);
            this.picPaddle.TabIndex = 1;
            this.picPaddle.TabStop = false;
            this.picPaddle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picPaddle_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.picTop.Location = new System.Drawing.Point(0, 0);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(848, 42);
            this.picTop.TabIndex = 2;
            this.picTop.TabStop = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLives.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLives.Location = new System.Drawing.Point(123, 9);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(82, 21);
            this.lblLives.TabIndex = 3;
            this.lblLives.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblScore.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Location = new System.Drawing.Point(617, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 21);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("ArcadeClassic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(534, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score: ";
            // 
            // picAlien
            // 
            this.picAlien.BackColor = System.Drawing.Color.Transparent;
            this.picAlien.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Alien1;
            this.picAlien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAlien.Location = new System.Drawing.Point(27, 56);
            this.picAlien.Name = "picAlien";
            this.picAlien.Size = new System.Drawing.Size(53, 53);
            this.picAlien.TabIndex = 4;
            this.picAlien.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.picPaddle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 427);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 52);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Fondo_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picAlien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.picBall);
            this.DoubleBuffered = true;
            this.Name = "FrmGame";
            this.Text = "Juego";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmGame_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAlien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}