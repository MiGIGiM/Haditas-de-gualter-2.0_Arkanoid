namespace ProyectoArkanoid.Vista
{
    partial class MainControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLeaderboards = new System.Windows.Forms.Button();
            this.btnGoOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Fondo_05;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnGoOut, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLeaderboards, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlay, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.LogoArka;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Font = new System.Drawing.Font("ArcadeClassic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(245, 147);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(240, 53);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "JUGAR";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnLeaderboards
            // 
            this.btnLeaderboards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeaderboards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeaderboards.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLeaderboards.FlatAppearance.BorderSize = 0;
            this.btnLeaderboards.Font = new System.Drawing.Font("ArcadeClassic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboards.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeaderboards.Location = new System.Drawing.Point(245, 263);
            this.btnLeaderboards.Name = "btnLeaderboards";
            this.btnLeaderboards.Size = new System.Drawing.Size(240, 53);
            this.btnLeaderboards.TabIndex = 2;
            this.btnLeaderboards.Text = "LEADERBOARDS";
            this.btnLeaderboards.UseVisualStyleBackColor = false;
            // 
            // btnGoOut
            // 
            this.btnGoOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoOut.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGoOut.FlatAppearance.BorderSize = 0;
            this.btnGoOut.Font = new System.Drawing.Font("ArcadeClassic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoOut.Location = new System.Drawing.Point(245, 379);
            this.btnGoOut.Name = "btnGoOut";
            this.btnGoOut.Size = new System.Drawing.Size(240, 53);
            this.btnGoOut.TabIndex = 3;
            this.btnGoOut.Text = "SALIR";
            this.btnGoOut.UseVisualStyleBackColor = false;
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(730, 464);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnGoOut;
        private System.Windows.Forms.Button btnLeaderboards;
    }
}
