using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace игра
{
    public partial class level2 : Form
    {
        List<string> linii;
        int lvleid = 2;
        int ttm;
        string Naame;
        int speed = 500;
        int nap = 1;
        private Image originalImage;
        private List<PictureBox> snakeSegments = new List<PictureBox>();
        private const int segmentSize = 51;
        private bool isGameOver = false;
        private PictureBox food;
        public level2(int kfc, string name)
        {
            InitializeComponent();
            ttm = kfc;
            Naame = name;

            pictureBox1.Image = Properties.Resources.head;
            originalImage = pictureBox1.Image;
            KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
            snakeSegments.Add(pictureBox1);
        }

        private Image RotateImage(Image img, float angle)
        {
            Bitmap rotatedBmp = new Bitmap(img.Width, img.Height);
            rotatedBmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
                g.DrawImage(img, new Point(0, 0));
            }
            return rotatedBmp;
        }
        void move_snake()
        {
            if (isGameOver) return;

            foreach (Control control in Controls)
            {
                if (control is PictureBox pic && pic.Tag?.ToString() == "lava")
                {
                    if (pictureBox1.Bounds.IntersectsWith(pic.Bounds))
                    {
                        GameOver();
                        return;
                    }
                }
            }

            Point headPosition = pictureBox1.Location;

            switch (nap)
            {
                case 1:
                    headPosition.Y -= segmentSize;
                    break;
                case 2:
                    headPosition.Y += segmentSize;
                    break;
                case 3:
                    headPosition.X -= segmentSize;
                    break;
                case 4:
                    headPosition.X += segmentSize;
                    break;
            }

            // Проверка на выход за границы
            if (headPosition.Y < 51 || headPosition.Y >= ClientSize.Height - 51 ||
                headPosition.X < 51 || headPosition.X >= ClientSize.Width - 51)
            {
                GameOver();
                return;
            }

            // столкновение с хвостом
            foreach (var segment in snakeSegments)
            {
                if (segment != pictureBox1 && segment.Location == headPosition)
                {
                    GameOver();
                    return;
                }
            }

            var sk = Properties.Resources.segment;

            for (int j = 0; j < linii.Count; j++)
            {
                string[] parts = linii[j].Split(';');
                if (parts.Length >= 1 && parts[0] == Naame)
                {
                    switch (Convert.ToInt32(parts[6]))
                    {
                        case 0:
                            sk = Properties.Resources.segment;
                            break;
                        case 1:
                            sk = Properties.Resources.rgb;
                            break;
                        case 2:
                            sk = Properties.Resources.rickroll_roll;
                            break;
                        case 3:
                            sk = Properties.Resources.seg2;
                            break;
                        case 4:
                            sk = Properties.Resources.seg3;
                            break;
                        case 5:
                            sk = Properties.Resources.seg4;
                            break;
                    }
                    break;
                }
            }

            // обновляение положения сегментов змейки
            for (int i = snakeSegments.Count - 1; i > 0; i--)
            {
                snakeSegments[i].Location = snakeSegments[i - 1].Location;
                snakeSegments[i].Image = sk;
            }
            pictureBox1.Location = headPosition;

        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool moved = true;

            int newDirection = nap;

            switch (e.KeyChar)
            {
                case (char)119: // w
                case (char)1094: // ц
                    newDirection = 1;
                    break;
                case (char)115: // s
                case (char)1099: // ы
                    newDirection = 2;
                    break;
                case (char)97: // a
                case (char)1092: // ф
                    newDirection = 3;
                    break;
                case (char)100: // d
                case (char)1074: // в
                    newDirection = 4;
                    break;
            }

            if ((nap == 1 && newDirection == 2) || (nap == 2 && newDirection == 1) ||
                (nap == 3 && newDirection == 4) || (nap == 4 && newDirection == 3))
            {
                moved = false;
            }
            else
            {
                nap = newDirection;
            }

            if (moved)
            {
                float angle = 0;
                switch (nap)
                {
                    case 1: angle = 0; break;    // вверх
                    case 2: angle = 180; break;  // вниз
                    case 3: angle = 270; break;  // влево
                    case 4: angle = 90; break;   // вправо
                }

                if (originalImage != null)
                {
                    pictureBox1.Image = RotateImage(originalImage, angle);
                }
            }
        }

        private bool gameOverHandled = false;
        private void GameOver()
        {
            if (gameOverHandled) return;
            gameOverHandled = true;

            bool scoreUpdated = false;

            for (int i = 0; i < linii.Count; i++)
            {
                string[] parts = linii[i].Split(';');
                if (parts.Length >= 1 && parts[0] == Naame)
                {
                    int currentScore = parts.Length >= 3 ? Convert.ToInt32(parts[2]) : 0;

                    string newLine = $"{parts[0]};{parts[1]};{parts[2]};{parts[3]};{parts[4]};{parts[5]};{parts[6]}";
                    linii[i] = newLine;

                    break;
                }
            }


            MessageBox.Show($"Игра окончена!");
            isGameOver = true;
            Hide();
        }

        private void addseg()
        {
            PictureBox newSegment = new PictureBox
            {
                Size = new Size(segmentSize, segmentSize),
                Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y),
                Image = RotateImage(originalImage, 0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Controls.Add(newSegment);
            snakeSegments.Add(newSegment);

            if (snakeSegments.Count % 3 == 0)
            {
                speed = Math.Max(5, speed - 10);
            }
        }
        private void level2_Load(object sender, EventArgs e)
        {
            string filePath = "users.txt";
            List<string> lines = new List<string>();

            if (File.Exists(filePath))
            {
                lines = File.ReadAllLines(filePath).ToList();
            }
            linii = lines;

            StreamReader sr = new StreamReader("settings.txt");
            string line = sr.ReadLine();
            speed = Convert.ToInt32(line);

            if (originalImage != null)
            {
                pictureBox1.Image = RotateImage(originalImage, 90);
                nap = 4;
            }
            addseg();
            addseg();
            addseg();
            timer1.Enabled = true;
        }
        private void WinGame()
        {
            if (isGameOver) return;

            isGameOver = true;
            timer1.Enabled = false;


            for (int i = 0; i < linii.Count; i++)
            {
                string[] parts = linii[i].Split(';');
                int le = lvleid;
                if (Convert.ToInt32(parts[3]) >= le)
                {
                    le = Convert.ToInt32(parts[3]);
                }
                if (parts.Length >= 1 && parts[0] == Naame)
                {
                    string newLine = $"{parts[0]};{parts[1]};{parts[2]};{le};{parts[4]};{parts[5]};{parts[6]}";
                    linii[i] = newLine;
                    break;
                }
            }
            File.WriteAllLines("users.txt", linii);
            MessageBox.Show("Поздравляем! Вы победили!", "Победа",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = speed * ttm;

            if (pictureBox1.Bounds.IntersectsWith(winblok.Bounds))
            {
                WinGame();
                timer2.Stop();
                return;
            }

            move_snake();

        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (pictureBox1.Bounds.IntersectsWith(winblok.Bounds))
            {
                WinGame();
                timer2.Stop();
                return;
            }


            foreach (Control control in Controls)
            {
                if (control is PictureBox pic && pic.Tag?.ToString() == "lava")
                {
                    if (pictureBox1.Bounds.IntersectsWith(pic.Bounds))
                    {
                        GameOver();
                        return;
                    }
                }
            }
        }

        private void winblok_Click_1(object sender, EventArgs e)
        {

        }
    }
}
