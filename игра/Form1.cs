using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Windows.Forms;
using System.IO;

namespace игра
{

    public partial class game : Form
    {

        int count = 0;
        int ttm;
        int speed = 500;
        int nap = 1;
        private Image originalImage;
        private List<PictureBox> snakeSegments = new List<PictureBox>();
        private const int segmentSize = 51;
        private bool isGameOver = false;
        private PictureBox food;

        public game(int kfc)
        {
            ttm = kfc;
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

            while (true)
            {
                int maxX = (ClientSize.Width - 2 * 51) / segmentSize;
                int maxY = (ClientSize.Height - 2 * 51) / segmentSize;

                int x = 51 + random.Next(0, maxX) * segmentSize;
                int y = 51 + random.Next(0, maxY) * segmentSize;

                newLocation = new Point(x, y);


                bool isOnSnake = snakeSegments.Any(segment => segment.Location == newLocation);

                if (!isOnSnake)
                    break;
            }

            food = new PictureBox
            {
                Size = new Size(segmentSize, segmentSize),
                Location = newLocation,
                Image = Properties.Resources.food,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            Controls.Add(food);
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


            // обновляение положения сегментов змейки
            for (int i = snakeSegments.Count - 1; i > 0; i--)
            {
                snakeSegments[i].Location = snakeSegments[i - 1].Location;
                snakeSegments[i].Image = Properties.Resources.segment;
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
            countfood.Text = $"{count}";
            move_snake();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //addseg();
        }
        private void GameOver()
        {
            isGameOver = true;
            MessageBox.Show("Игра окончена!");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            prov();
        }
    }
}
