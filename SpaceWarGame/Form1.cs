using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWarGame
{
    public partial class Form1 : Form
    {
        int FormHeight = 700, FormWidth = 500;

        // oyuncu koordinat
        int Player_X = 200, Player_Y = 400;
        int PlayerSpeed_Horizontal = 0, PlayerSpeed_Vertical = 0;
        int point;
        List<PictureBox> Bullets = new List<PictureBox>();
        int BulletSpeed = 10;
        List<PictureBox> Enemys = new List<PictureBox>();
        int EnemySpeed = 2;
        Random rnd = new Random();
        private Bitmap Image;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = FormHeight;
            this.Width = FormWidth;

            // objeleri galaxy içine aldık.
            label_Point.Parent = pictureBox_Galaxy;
            pictureBox_PlayerShip.Parent = pictureBox_Galaxy;
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int speed = 3;
            switch (e.KeyCode)
            {
                case Keys.Left: PlayerSpeed_Horizontal -= speed; break;
                case Keys.Right: PlayerSpeed_Horizontal += speed; break;
                case Keys.Up: PlayerSpeed_Vertical -= speed; break;
                case Keys.Down: PlayerSpeed_Vertical += speed; break;
                case Keys.Enter:
                    point = 0;
                    timer_Player.Start();
                    timer_BulletThrow.Start();
                    timer_EnemyCreate.Start();
                    timer_ShootEnemy.Start();
                    timer_BulletControl.Start();
                    break;
                case Keys.Space:
                    BulletCreat();
                    break;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: PlayerSpeed_Horizontal = 0; break;
                case Keys.Right: PlayerSpeed_Horizontal = 0; break;
                case Keys.Up: PlayerSpeed_Vertical = 0; break;
                case Keys.Down: PlayerSpeed_Vertical = 0; break;
            }
        }

        private void timer_BulletThrow_Tick(object sender, EventArgs e)
        {
            BulletThrow();
        }

        private void timer_Player_Tick(object sender, EventArgs e)
        {
            Player_X += PlayerSpeed_Horizontal; 
            Player_Y += PlayerSpeed_Vertical;
            pictureBox_PlayerShip.Location = new Point(Player_X, Player_Y);
        }

        // Mermi oluşturuyoruz.
        public void BulletCreat()
        {
            PictureBox Bullet = new PictureBox();


              Bullet.Size = new Size(55, 25);
           
             Bullet.SizeMode = PictureBoxSizeMode.StretchImage;
             Bullet.Image = Properties.Resources.bullet;
             Bullet.BackColor = Color.Transparent;

            int BulletLocX = pictureBox_PlayerShip.Left + pictureBox_PlayerShip.Width / 2 - 5;
            int BulletLocY = pictureBox_PlayerShip.Top - 1;
            Bullet.Location = new Point(BulletLocX, BulletLocY);
            Controls.Add(Bullet);
            Bullet.Parent = pictureBox_Galaxy;
            Bullet.BringToFront(); // galaxy resminin üstüne çıkardık.
            Bullets.Add(Bullet);
        }

        private void timer_ShootEnemy_Tick(object sender, EventArgs e)
        {
            ShootEnemy();
        }

        private void timer_EnemyCreate_Tick(object sender, EventArgs e)
        {
            EnemyCreate();
        }

        private void timer_BulletControl_Tick(object sender, EventArgs e)
        {
            for (int b = 0; b < Bullets.Count; b++)
            {
                for (int s = 0; s < Enemys.Count; s++)
                {
                    try
                    {
                        if (Bullets[b].Bounds.IntersectsWith(Enemys[s].Bounds))
                        {
                            point += 1;
                            label_Point.Text = "PUAN = " + point.ToString();
                            pictureBox_Galaxy.Controls.Remove(Bullets[b]);
                            Bullets.Remove(Bullets[b]);
                            pictureBox_Galaxy.Controls.Remove(Enemys[s]);
                            Enemys.Remove(Enemys[s]);

                            // ram temizleme
                            GC.Collect(); // çöp toplayıcı
                            GC.WaitForPendingFinalizers();// çöp yok et 
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        return;
                    }
                    
                }
            }
        }

        public void BulletThrow()
        {
            for (int i = 0; i < Bullets.Count; i++)
            {
                Bullets[i].Top -= BulletSpeed;
            }
        }

        public void EnemyCreate()
        {
            int Locations = rnd.Next(0, FormWidth - 50);
            PictureBox Enemy = new PictureBox();
            Enemy.Size = new Size(100, 80);
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            Enemy.Image = Properties.Resources.EnemyShip;
            Enemy.BackColor = Color.Transparent;
            Enemy.Location = new Point(Locations, 0);
            Enemy.Visible = true;
            Controls.Add(Enemy);
            Enemy.Parent = pictureBox_Galaxy;
            Enemy.BringToFront();
            Enemys.Add(Enemy);
        }

        public void ShootEnemy()
        {
            for (int i = 0; i < Enemys.Count; i++)
            {
                Enemys[i].Top += EnemySpeed;
                if (Enemys[i].Top >= FormHeight-10 || Enemys[i].Bounds.IntersectsWith(pictureBox_PlayerShip.Bounds))
                {
                    GameFinish();
                }
            }
        }

        public void GameFinish()
        {
            timer_Player.Stop();
            timer_BulletThrow.Stop();
            timer_BulletControl.Stop();
            timer_EnemyCreate.Stop();
            timer_ShootEnemy.Stop();

            MessageBox.Show("OYUN BİTTİ...");

        }
    }
    }


