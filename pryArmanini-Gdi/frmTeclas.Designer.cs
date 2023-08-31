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
            this.components = new System.ComponentModel.Container();
            this.picNave = new System.Windows.Forms.PictureBox();
            this.contenedor = new System.Windows.Forms.PictureBox();
            this.pelota = new System.Windows.Forms.Timer(this.components);
            this.btnJugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picBala = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala)).BeginInit();
            this.SuspendLayout();
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
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(12, 30);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(678, 375);
            this.contenedor.TabIndex = 5;
            this.contenedor.TabStop = false;
            // 
            // pelota
            // 
            this.pelota.Interval = 600;
            this.pelota.Tick += new System.EventHandler(this.pelota_Tick);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(285, 181);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(110, 36);
            this.btnJugar.TabIndex = 8;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox1.Location = new System.Drawing.Point(114, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox2.Location = new System.Drawing.Point(226, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox3.Location = new System.Drawing.Point(346, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox4.Location = new System.Drawing.Point(463, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // picBala
            // 
            this.picBala.BackColor = System.Drawing.Color.Red;
            this.picBala.Location = new System.Drawing.Point(335, 286);
            this.picBala.Name = "picBala";
            this.picBala.Size = new System.Drawing.Size(23, 22);
            this.picBala.TabIndex = 11;
            this.picBala.TabStop = false;
            // 
            // frmTeclas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(702, 435);
            this.Controls.Add(this.picBala);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.picNave);
            this.Controls.Add(this.contenedor);
            this.Name = "frmTeclas";
            this.Text = "frmTeclas";
            this.Load += new System.EventHandler(this.frmTeclas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTeclas_KeyDown);
            this.MouseCaptureChanged += new System.EventHandler(this.frmTeclas_MouseCaptureChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTeclas_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picNave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picNave;
        private System.Windows.Forms.PictureBox contenedor;
        private System.Windows.Forms.Timer pelota;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picBala;
    }
}