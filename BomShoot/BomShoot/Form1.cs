using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BomShoot
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMed;
        WindowsMediaPlayer shootMed;
        WindowsMediaPlayer explosion;
        WindowsMediaPlayer talo;

        PictureBox[] enemybullet;
        int ebulletspeed;

        PictureBox[] enemy;
        int enemySpeed;

        PictureBox[] stars;
        int backgroundspeed;

        int playerSpeed;
        Random rnd;

        PictureBox[] bullets;
        int bulletSpeed;
        bool pause;
        bool gameIsOver;
        int score;
        int difficulty;
        int level;

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            difficulty = 9;
            level = 1;

            backgroundspeed = 4;
            playerSpeed = 4;
            bulletSpeed = 20;
            enemySpeed = 4;
            ebulletspeed = 4;

            bullets = new PictureBox[3];
            Image bullet = Image.FromFile(@"assets\munition.png");
            Image enemy1 = Image.FromFile("assets\\1.png");
            Image enemy2 = Image.FromFile("assets\\2.png");
            Image boss1 = Image.FromFile("assets\\3.png");
            Image boss2 = Image.FromFile("assets\\4.png");

            enemy = new PictureBox[10];

            for (int i = 0; i < enemy.Length; i++)
            {
                enemy[i] = new PictureBox();
                enemy[i].Size = new Size(40, 40);
                enemy[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemy[i].BorderStyle = BorderStyle.None;
                enemy[i].Visible = false;
                this.Controls.Add(enemy[i]);
                enemy[i].Location = new Point((i + 1) * 50, -50);


            }
            enemy[0].Image = boss1;
            enemy[1].Image = enemy1;
            enemy[2].Image = enemy2;
            enemy[3].Image = boss2;
            enemy[4].Image = enemy1;
            enemy[5].Image = boss1;
            enemy[6].Image = boss2;

            for (int i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].Size = new Size(8, 8);
                bullets[i].Image = bullet;
                bullets[i].SizeMode = PictureBoxSizeMode.Zoom;
                bullets[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(bullets[i]);
            }

            gameMed = new WindowsMediaPlayer();
            shootMed = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();
            talo = new WindowsMediaPlayer();

            gameMed.URL = "audio\\BG.wav";
            shootMed.URL = "audio\\pew final.wav";
            explosion.URL = "audio\\BOOM.wav";
            talo.URL = "audio\\talo.wav";

            gameMed.settings.setMode("loop", true);
            gameMed.settings.volume = 25;
            shootMed.settings.volume = 10;
            explosion.settings.volume = 15;
            talo.settings.volume = 0;



            stars = new PictureBox[10];
            rnd = new Random();

            enemybullet = new PictureBox[10];
            for (int i = 0; i < enemybullet.Length; i++)
            {
                enemybullet[i] = new PictureBox();
                enemybullet[i].Size = new Size(2, 25);
                enemybullet[i].Visible = false;
                enemybullet[i].BackColor = Color.OrangeRed;
                int x = rnd.Next(0, 10);
                enemybullet[i].Location = new Point(enemy[x].Location.X, enemy[x].Location.Y - 20);
                this.Controls.Add(enemybullet[i]);
            }

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }

            gameMed.controls.play();
        }


        private void BGtimer_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = stars[i].Height;
                }
            }
        }

        private void Leftmove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }

        }

        private void Rightmove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Right < 450)
            {
                Player.Left += playerSpeed;
            }
        }

        private void Upmove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }

        }

        private void Downmove_Tick_1(object sender, EventArgs e)
        {
            if (Player.Top < 300)
            {
                Player.Top += playerSpeed;
            }

        }

        private void BulleT_Tick_1(object sender, EventArgs e)
        {
            shootMed.controls.play();
            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i].Top > 0)
                {
                    bullets[i].Visible = true;
                    bullets[i].Top -= bulletSpeed;

                    collision();
                }
                else
                {
                    bullets[i].Visible = false;
                    bullets[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }

        }

        private void Enemytimer_Tick_1(object sender, EventArgs e)
        {
            moveEnemy(enemy, enemySpeed);
        }

        private void moveEnemy(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        private void collision()
        {
            for (int i = 0; i < enemy.Length; i++)
            {
                if (bullets[0].Bounds.IntersectsWith(enemy[i].Bounds) || bullets[1].Bounds.IntersectsWith(enemy[i].Bounds) || bullets[2].Bounds.IntersectsWith(enemy[i].Bounds))
                {
                    explosion.controls.play();
                    score += 1;
                    label1.Text = (score < 10) ? "0" + score.ToString() : score.ToString();

                    if (score % 30 == 0)
                    {
                        level += 1;
                        label3.Text = (level < 10) ? "0" + level.ToString() : level.ToString();
                        if (enemySpeed <= 10 && ebulletspeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemySpeed++;
                            ebulletspeed++;
                        }
                        if (level == 10)
                        {
                            GOver("GOOD JOB!");
                        }
                    }

                    enemy[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Player.Bounds.IntersectsWith(enemy[i].Bounds))
                {
                    talo.settings.volume = 100;
                    talo.controls.play();
                    Player.Visible = false;
                    GOver("GAME OVER");
                }
            }

        }
        private void GOver(String str)
        {
            label2.Text = str;
            label2.Location = new Point(120, 120);
            label2.Visible = true;
            Rplay.Visible = true;
            Exit.Visible = true;
            gameMed.controls.stop();
            stoptime();
        }
        private void stoptime()
        {
            BGtimer.Stop();
            Enemytimer.Stop();
            BulleT.Stop();
            eBulleT.Stop();
        }
        private void starttime()
        {
            BGtimer.Start();
            Enemytimer.Start();
            BulleT.Start();
            eBulleT.Start();
        }

        private void eBulleT_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < enemybullet.Length - difficulty; i++)
            {
                if (enemybullet[i].Top < this.Height)
                {
                    enemybullet[i].Visible = true;
                    enemybullet[i].Top += ebulletspeed;
                    CollwithBullet();
                }
                else
                {
                    enemybullet[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemybullet[i].Location = new Point(enemy[x].Location.X + 20, enemy[x].Location.Y + 30);
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    Rightmove.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    Leftmove.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    Upmove.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    Downmove.Start();
                }
            }

        }


        private void CollwithBullet()
        {
            for (int i = 0; i < enemybullet.Length; i++)
            {
                if (enemybullet[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemybullet[i].Visible = false;
                    talo.settings.volume = 100;
                    talo.controls.play();
                    Player.Visible = false;
                    GOver("Game Over");
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Rightmove.Stop();
            }
            if (e.KeyCode == Keys.Left)
            {
                Leftmove.Stop();
            }
            if (e.KeyCode == Keys.Up)
            {
                Upmove.Stop();
            }
            if (e.KeyCode == Keys.Down)
            {
                Downmove.Stop();
            }

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (pause)
                    {
                        starttime();
                        label2.Visible = false;
                        gameMed.controls.play();
                        pause = false;
                    }
                    else
                    {
                        label2.Location = new Point(this.Width / 2 - 120, 150);
                        label2.Text = "Paused";
                        label2.Visible = true;
                        gameMed.controls.pause();
                        stoptime();
                        pause = true;
                    }
                }
            }
        }

        private void Rplay_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


    }
}