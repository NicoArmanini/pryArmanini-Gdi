namespace pryArmanini_Gdi
{
    partial class frmArkanoid
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
            this.btnJugar = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.PictureBox();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.picNave = new System.Windows.Forms.PictureBox();
            this.Pelota = new System.Windows.Forms.Timer(this.components);
            this.picPelota = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(300, 343);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(79, 23);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(1, 3);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(678, 375);
            this.contenedor.TabIndex = 1;
            this.contenedor.TabStop = false;
            // 
            // temporizador
            // 
            this.temporizador.Interval = 300;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picNave.Location = new System.Drawing.Point(292, 308);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(92, 29);
            this.picNave.TabIndex = 2;
            this.picNave.TabStop = false;
            // 
            // Pelota
            // 
            this.Pelota.Interval = 200;
            this.Pelota.Tick += new System.EventHandler(this.Pelota_Tick);
            // 
            // picPelota
            // 
            this.picPelota.BackColor = System.Drawing.Color.Salmon;
            this.picPelota.Location = new System.Drawing.Point(315, 216);
            this.picPelota.Name = "picPelota";
            this.picPelota.Size = new System.Drawing.Size(38, 31);
            this.picPelota.TabIndex = 3;
            this.picPelota.TabStop = false;
            // 
            // frmArkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 382);
            this.Controls.Add(this.picPelota);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.contenedor);
            this.Name = "frmArkanoid";
            this.Text = "frmArkanoid";
            this.Load += new System.EventHandler(this.frmArkanoid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.Timer temporizador;
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.Timer Pelota;
        private System.Windows.Forms.PictureBox picPelota;
    }
}