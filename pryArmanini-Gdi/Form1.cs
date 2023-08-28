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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox basePapel = new PictureBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            //lienzo con picture
            //crear en memoria para utilizar = instanciar


            basePapel.BackColor = Color.Red;
            basePapel.Location = new Point(125, 125);
            basePapel.Size = new Size(250, 250);

            Controls.Add(basePapel);
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            //espacio para dibujar
            Graphics papel;

            papel = basePapel.CreateGraphics();
            Pen lapiz = new Pen(Color.White);
            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
            papel.DrawRectangle(lapiz, 10, 75, 100, 100);

        }
    }
}
