namespace ProyectoArkanoid.Vista
{
    partial class GameControls
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // picPaddle
            // 
            this.picPaddle.BackColor = System.Drawing.Color.Transparent;
            this.picPaddle.Location = new System.Drawing.Point(27, 366);
            this.picPaddle.Name = "picPaddle";
            this.picPaddle.Size = new System.Drawing.Size(200, 40);
            this.picPaddle.TabIndex = 0;
            this.picPaddle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Click);
            // 
            // GameControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoArkanoid.Properties.Resources.Fondo_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.picPaddle);
            this.Name = "GameControls";
            this.Size = new System.Drawing.Size(705, 458);
            this.Load += new System.EventHandler(this.GameControls_Load);
            this.VisibleChanged += new System.EventHandler(this.GameControls_VisibleChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameControls_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameControls_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picPaddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaddle;
        private System.Windows.Forms.Timer timer1;
    }
}
