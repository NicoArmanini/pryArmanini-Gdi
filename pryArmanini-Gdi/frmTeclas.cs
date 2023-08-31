using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmanini_Gdi
{
    public partial class frmTeclas : Form
    {
        public frmTeclas()
        {
            InitializeComponent();
        }

        public int speed = 20;
        
        private void frmTeclas_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void frmTeclas_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void frmTeclas_KeyDown(object sender, KeyEventArgs e)
        {
            //es para mover la nave de derecha a izquierda

            if (e.KeyCode == Keys.Left)
            {
                if (picNave.Left > 0)
                {
                    picNave.Left -= speed;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (picNave.Right > 0)
                {
                    picNave.Left += speed;
                }
            }


            //para sacar un picture de la nave hacia arriba

        }
        int ejeX = 0;
        int ejeY = 0;
        private void pelota_Tick(object sender, EventArgs e)
        {

            ejeX = picBala.Location.X;
            ejeY = picBala.Location.Y;

            picBala.Location = picNave.Location;
            picBala.Location = new Point(ejeX, ejeY -5);
           
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            picBala.Location = picNave.Location;
            picBala.Show();
            btnJugar.Location = new Point(1000, 0);
            Enabled = false;
            pelota.Enabled = true;
        }

        private void frmTeclas_Load(object sender, EventArgs e)
        {
            picBala.Hide();
        }
    }
}
