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
    public partial class frmPruebaChatGpt : Form
    {
        private PictureBox playerPictureBox;
        private PictureBox targetPictureBox;
        private Timer gameTimer;
        private List<PictureBox> projectiles;
        public frmPruebaChatGpt()
        {
            InitializeComponent();
            InitializePlayer();
            InitializeProjectile();
            InitializeTarget();
            InitializeGameTimer();
        }
        
        private void InitializePlayer()
        {
            playerPictureBox = new PictureBox
            {
                Size = new Size(100, 20),
                Location = new Point((ClientSize.Width - 100) / 2, ClientSize.Height - 40),
                BackColor = Color.Blue
            };

            Controls.Add(playerPictureBox);
        }

        private void InitializeProjectile()
        {
            projectiles = new List<PictureBox>();
        }

        private void InitializeTarget()
        {
            targetPictureBox = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point((ClientSize.Width - 50) / 2, 10),
                BackColor = Color.Green
            };

            Controls.Add(targetPictureBox);
        }

        private void InitializeGameTimer()
        {
            gameTimer = new Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            MoveProjectile();
            CheckCollision();
        }

        private void MoveProjectile()
        {

            foreach (PictureBox projectile in projectiles)
            {
                if (projectile.Visible)
                {
                    if (projectile.Top > 0)
                    {
                        projectile.Top -= 5;
                    }
                    else
                    {
                        projectile.Visible = false;
                    }
                }
            }
        }


        private void CheckCollision()
        {
            foreach (PictureBox projectile in projectiles)
            {
                if (projectile.Bounds.IntersectsWith(targetPictureBox.Bounds))
                {
                    Controls.Remove(targetPictureBox);
                    Controls.Remove(projectile);

                    GenerateTarget();
                    projectile.Visible = false;
                }
            }
        }
        Random aleatorio = new Random();
        int ejeX = 0;
        private void GenerateTarget()
        {
            ejeX = aleatorio.Next(0, 612);

            targetPictureBox = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(ejeX, 20),
                BackColor = Color.Green
            };

            Controls.Add(targetPictureBox);
        }


        private void frmPruebaChatGpt_Load(object sender, EventArgs e)
        {

        }
        private void CreateProjectile()
        {
            PictureBox projectilePictureBox = new PictureBox
            {
                Size = new Size(20, 20),
                BackColor = Color.Red,
                Visible = true
            };

            projectilePictureBox.Left = playerPictureBox.Left + (playerPictureBox.Width - projectilePictureBox.Width) / 2;
            projectilePictureBox.Top = playerPictureBox.Top - projectilePictureBox.Height;

            projectiles.Add(projectilePictureBox);
            Controls.Add(projectilePictureBox);
        }

        public int speed = 20;
        private void frmPruebaChatGpt_KeyDown(object sender, KeyEventArgs e)
        {
            int leftBound = 0;
            int rightBound = ClientSize.Width - playerPictureBox.Width; // Limitar a la posición máxima del lado derecho

            if (e.KeyCode == Keys.Left && playerPictureBox.Left > leftBound)
            {
                if (playerPictureBox.Left > 0)
                {
                    playerPictureBox.Left -= speed;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (playerPictureBox.Right > 0 && playerPictureBox.Left < rightBound)
                {
                    playerPictureBox.Left += speed;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                CreateProjectile();
            }
        }

        private void frmPruebaChatGpt_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
