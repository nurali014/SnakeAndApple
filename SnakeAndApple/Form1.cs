namespace SnakeAndApple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dx = 0;            // ilanın sağa-sola istiqaməti (-1 sol, 1 sağ)
        int dy = 0;            // ilanın yuxarı-aşağı istiqaməti (-1 yuxarı, 1 aşağı)
        int speed = 5;         // ilanın sürəti
        int score = 0;         // xal
        int time = 5;          // alma/bomba ekranda neçə saniyə qalır
        bool facingRight = true;
        bool GameOver = false;
        Random rnd = new Random();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //ilanın istiqaməti
            if (e.KeyCode == Keys.Left)
            {
                dx = -1;
                dy = 0;
                //ilanın başı sola baxsın
                if (facingRight)
                {
                    snake.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    snake.Refresh();
                    facingRight = false;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                dx = 1;
                dy = 0;
                //ilanın başı sağa baxsın
                if (!facingRight)
                {
                    snake.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    snake.Refresh();
                    facingRight = true;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                dx = 0;
                dy = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                dx = 0;
                dy = 1;
            }

            //yeni oyun
            if (e.KeyCode == Keys.Enter && GameOver)
            {
                RestartGame();
            }
        }

        //ilanın hərəkəti
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameOver) return;
            snake.Left += dx * speed;
            snake.Top += dy * speed;

            //ilan ekrandan çıxanda o biri tərəfdən girir
            if (snake.Right < 0)
            {
                snake.Left = ClientSize.Width;
            }
            if (snake.Left > ClientSize.Width)
            {
                snake.Left = -snake.Width;
            }
            if (snake.Bottom < 0)
            {
                snake.Top = ClientSize.Height;
            }
            if (snake.Top > ClientSize.Height)
            {
                snake.Top = -snake.Height;
            }

            //alma yeyildi - xal və sürət artır
            if (apple.Visible && snake.Bounds.IntersectsWith(apple.Bounds))
            {
                score++;
                speed++;
                lblScore.Text = "Xal: " + score;
                lblSpeed.Text = "Sürət: " + speed;
                NewItem(true);
            }

            //bomba yeyildi - oyun bitir
            if (bomb.Visible && snake.Bounds.IntersectsWith(bomb.Bounds))
            {
                timer1.Stop();
                timer2.Stop();
                GameOver = true;
                MessageBox.Show("Oyun bitdi! Bombanı yedin.\nNəticə: " + score + " xal\nYeni oyun üçün Enter basın", "Snake and apple");
            }
        }

        //hər saniyə işləyir - 5 saniyəni sayır
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (GameOver) return;
            time--;
            lblTime.Text = "Vaxt: " + time;

            //5 saniyə bitdi - alma/bomba başqa yerə atılır
            if (time <= 0)
            {
                NewItem(true);
            }
        }

        //alma və ya bombanı random yerə atır
        private void NewItem(bool canBeBomb)
        {
            //random: alma bombaya çevrilə bilər (3-dən 1 ehtimal)
            bool isBomb = false;
            if (canBeBomb && rnd.Next(0, 3) == 0)
            {
                isBomb = true;
            }
            apple.Visible = !isBomb;
            bomb.Visible = isBomb;

            //random yer (ilanın üstünə və ya lap yanına düşməsin)
            Rectangle snakeArea = snake.Bounds;
            snakeArea.Inflate(60, 60);
            Point p;
            do
            {
                int x = rnd.Next(0, ClientSize.Width - apple.Width);
                int y = rnd.Next(40, ClientSize.Height - apple.Height);
                p = new Point(x, y);
            }
            while (snakeArea.IntersectsWith(new Rectangle(p, apple.Size)));

            apple.Location = p;
            bomb.Location = p;

            //5 saniyə yenidən başlayır
            time = 5;
            lblTime.Text = "Vaxt: " + time;
            timer2.Stop();
            timer2.Start();
        }

        private void RestartGame()
        {
            GameOver = false;
            snake.Location = new Point(420, 380);
            dx = 0;
            dy = 0;
            speed = 5;
            score = 0;
            lblScore.Text = "Xal: " + score;
            lblSpeed.Text = "Sürət: " + speed;
            NewItem(false); //oyunun əvvəlində həmişə alma olur
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //şəkillər Images qovluğundan yüklənir
            snake.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "snake.png"));
            apple.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "apple.png"));
            bomb.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "bomb.png"));
            RestartGame();
        }
    }
}
