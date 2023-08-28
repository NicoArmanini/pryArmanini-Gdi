namespace pryArmanini_Gdi
{
    partial class frmTeclas
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
            this.picPelota = new System.Windows.Forms.PictureBox();
            this.picNave = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.contenedor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // picPelota
            // 
            this.picPelota.BackColor = System.Drawing.Color.Salmon;
            this.picPelota.Location = new System.Drawing.Point(326, 243);
            this.picPelota.Name = "picPelota";
            this.picPelota.Size = new System.Drawing.Size(38, 31);
            this.picPelota.TabIndex = 7;
            this.picPelota.TabStop = false;
            // 
            // picNave
            // 
            this.picNave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picNave.Location = new System.Drawing.Point(303, 335);
            this.picNave.Name = "picNave";
            this.picNave.Size = new System.Drawing.Size(92, 29);
            this.picNave.TabIndex = 6;
            this.picNave.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(311, 370);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(79, 23);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(12, 30);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(678, 375);
            this.contenedor.TabIndex = 5;
            this.contenedor.TabStop = false;
            // 
            // frmTeclas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 435);
            this.Controls.Add(this.picPelota);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.contenedor);
            this.Name = "frmTeclas";
            this.Text = "frmTeclas";
            this.MouseCaptureChanged += new System.EventHandler(this.frmTeclas_MouseCaptureChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTeclas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPelota;
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.PictureBox contenedor;
    }
}