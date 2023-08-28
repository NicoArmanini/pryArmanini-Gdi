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

        private void frmTeclas_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void frmTeclas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //picNave.Left = true;
            }

            if (e.Button == MouseButtons.Right)
            {
                picNave.Location = new Point(e.X, e.Y);
            }
        }
    }
}
