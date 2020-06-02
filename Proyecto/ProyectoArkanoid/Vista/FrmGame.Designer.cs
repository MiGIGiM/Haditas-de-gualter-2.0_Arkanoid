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
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
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
            this.picPaddle.Location = new System.Drawing.Point(321, 439);
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
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Fondo_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 491);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.picPaddle);
            this.Controls.Add(this.picBall);
            this.Name = "FrmGame";
            this.Text = "Juego";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmGame_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picTop;
    }
}