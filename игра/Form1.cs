using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;

namespace игра
{

    public partial class game : Form
    {
        List<string> linii;
        int count = 0;
        int ttm;
        string Naame;
        int speed = 500;
        int nap = 1;
        private Image originalImage;
        private List<PictureBox> snakeSegments = new List<PictureBox>();
        private const int segmentSize = 51;
        private bool isGameOver = false;
        private PictureBox food;

        public game(int kfc, string name)
        {
            ttm = kfc;
            Naame = name;
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.head;
            originalImage = pictureBox1.Image;
            KeyPreview = true;
            snakeSegments.Add(pictureBox1);
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
        private void CreateFood()
        {
            if (food != null)
            {
                Controls.Remove(food);
                food.Dispose();
            }

            Random random = new Random();
            Point newLocation;
            bool validPosition;

            List<Point> occupiedPositions = snakeSegments.Select(seg => seg.Location).ToList();

            do
            {
                int maxX = (ClientSize.Width - 2 * segmentSize) / segmentSize;
                int maxY = (ClientSize.Height - 2 * segmentSize) / segmentSize;
                int x = segmentSize + random.Next(0, maxX) * segmentSize;
                int y = segmentSize + random.Next(0, maxY) * segmentSize;
                newLocation = new Point(x, y);
                validPosition = !occupiedPositions.Contains(newLocation);

            } while (!validPosition);

            food = new PictureBox
            {
                Size = new Size(segmentSize, segmentSize),
                Location = newLocation,
                Image = Properties.Resources.food,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Controls.Add(food);
            food.BringToFront();
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
                            sk = Properties.Resources.segment;
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
        private void Form1_Load(object sender, EventArgs e)
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
            CreateFood();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer2.Interval = 1;

        }
        public void prov()
        {

            // съедание еды
            if (pictureBox1.Bounds.IntersectsWith(food.Bounds))
            {
                count++;
                addseg();
                CreateFood();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = speed * ttm;
            move_snake();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //addseg();
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
                    if (count > currentScore)
                    {
                        string newLine = $"{parts[0]};{parts[1]};{count};{parts[3]};{parts[4]};{parts[5]};{parts[6]}";
                        linii[i] = newLine;
                        scoreUpdated = true;
                    }
                    break;
                }
            }

            try
            {
                File.WriteAllLines("users.txt", linii);
                if (scoreUpdated)
                {
                    MessageBox.Show($"Игра окончена! Новый рекорд: {count} очков", "Результат",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Игра окончена! Ваш счет: {count} очков", "Результат",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении результатов: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            isGameOver = true;
            Hide();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            countfood.Text = $"{count}";
            prov();
        }
    }
}
