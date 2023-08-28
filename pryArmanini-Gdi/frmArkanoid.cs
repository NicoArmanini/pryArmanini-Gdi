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
    public partial class frmArkanoid : Form
    {
        public frmArkanoid()
        {
            InitializeComponent();
        }
        private void frmArkanoid_Load(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            btnJugar.Hide();
            temporizador.Enabled = true;
            Pelota.Enabled = true;
        }

        Random aleatorio = new Random();
        int ejeX = 0;

        private void temporizador_Tick(object sender, EventArgs e)
        {
            ejeX = aleatorio.Next(0,612);
            picNave.Location = new Point(ejeX, 308);

        }

        int ejeY = 0;
        private void Pelota_Tick(object sender, EventArgs e)
        {
            ejeY = aleatorio.Next(112, 312);
            picPelota.Location = new Point(ejeX, ejeY);
        }
    }
}
