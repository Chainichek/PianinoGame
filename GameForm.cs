using PianinoGame.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using PianinoGame.Models;
using Color = System.Drawing.Color;
using Timer = System.Threading.Timer;

namespace PianinoGame
{
    public partial class GameForm : Form
    {
        // TODO доделать, ща акцент на скринах с формами сделаю и всё
        private static GameForm _gameForm;

        //Координата цели
        private int targetY;

        private bool gameIsStarted = true;
        private bool gameIsFinished = false;

        //Панели, попавшие в цель
        private List<PictureBox> targetBoxes;

        private int Line = 0;
        private static int cellWidth = 0;
        private List<PictureBox> PictureBoxes = new List<PictureBox>();
        BackgroundWorker worker;
        private int score = 0;

        private bool line1IsFree = true;
        private bool line2IsFree = true;
        private bool line3IsFree = true;

        private int timeSleep = 50;

        private MediaPlayer my_sound;


        private GameForm()
        {
            InitializeComponent();

            cellWidth = this.Width / 3;

            targetY = gamePictureBoxTargerPanel.Location.Y + (gamePictureBoxTargerPanel.Height >> 1);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }

        public new void Show()
        {
            base.Show();
        }

        private void SetWorker()
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_GameProccess;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync(10000);
        }

        public static GameForm GetInstance()
        {
            if (_gameForm == null)
            {
                _gameForm = new GameForm();
            }

            return _gameForm;
        }

        public void RunGame()
        {
            gameIsStarted = true;
            gameIsFinished = false;
            score = 0;
            SetWorker();
            my_sound = new MediaPlayer();
            my_sound.Open(new Uri("C:\\Users\\ildar\\source\\repos\\Chainichek\\PianinoGame\\Resources\\23.wav"));
            my_sound.Play();
        }
        public void SetVolume(int volume)
        {
            // MediaPlayer volume is a float value between 0 and 1.
            my_sound.Volume = volume / 100.0f;
        }

        public void upHard()
        {
            if (score % 5 == 0)
            {
                if (timeSleep > 15)
                {
                    timeSleep -= 5;
                }
            }
        }

        public void updateScoreLabel()
        {
            upHard();
            score += 1;
            ScoreLabel.Text = "Счёт: " + score.ToString();
        }

        public void worker_GameProccess(object sender, DoWorkEventArgs e)
        {
            
            while (!gameIsFinished)
            {
                if (gameIsStarted)
                {
                    worker.ReportProgress(1);
                    Thread.Sleep(timeSleep);
                }

            }

        }

        public void takeLine(PictureBox picture)
        {
            if (picture.Name.Equals("0"))
            {
                line1IsFree = false;
            }
            if (picture.Name.Equals("1"))
            {
                line2IsFree = false;
            }
            if (picture.Name.Equals("2"))
            {
                line3IsFree = false;
            }
        }

        public void freeLine(PictureBox picture)
        {

            if (picture.Name.Equals("0"))
            {
                line1IsFree = true;
            }
            if (picture.Name.Equals("1"))
            {
                line2IsFree = true;
            }
            if (picture.Name.Equals("2"))
            {
                line3IsFree = true;
            }
        }

        private void closePic(PictureBox picture)
        {
            updateScoreLabel();
            gamePanel.Controls.Remove(picture);
            PictureBoxes.Remove(picture);
            freeLine(picture);
        }


        private void picClicked(PictureBox picture)
        {
            if (PictureBoxes.Count != 0)
            {
                if (PictureBoxes[0] == picture)
                {
                    closePic(picture);
                }
            }
            
        }

        private void picPressed(string key)
        {
            PictureBox pictureBox = targetBoxes.Find(x => x.Name.Equals(key));
            if (targetBoxes.Count == 0 || pictureBox == null)
            {
                gameIsFinished = true;
                return;
            }

            closePic(pictureBox);
            
        }

        private bool IsTarget(PictureBox picture) => (picture.Location.Y + picture.Height > gamePictureBoxTargerPanel.Location.Y &&
                                                      picture.Location.Y <
                                                      gamePictureBoxTargerPanel.Location.Y +
                                                      gamePictureBoxTargerPanel.Height);

        private bool IsOutOfScreen(PictureBox picture) => picture.Location.Y > gamePanel.Location.Y + gamePanel.Height;

        public void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Удаление пропавших ссылок
            PictureBoxes.RemoveAll(item => item == null);

            for (int i = PictureBoxes.Count-1; i >= 0; i--)
            {
                PictureBox picture = PictureBoxes[i];
                picture.Location = new Point(picture.Location.X, picture.Location.Y + 10);
                if (IsOutOfScreen(picture))
                {
                    gameIsFinished = true;
                }
                if (picture.Location.Y > 30 + 180)
                {
                    freeLine(picture);
                }
            }

            //Если попадает в границы невидимого таргет-бокса
            targetBoxes = PictureBoxes.Where(IsTarget).ToList();


            if (PictureBoxes.Count < 3)
            {
                int randomLine = new Random().Next(0, 3);
                if ((line1IsFree && 0 == randomLine) || (line2IsFree && 1 == randomLine) || (line3IsFree && 2 == randomLine))
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Name = randomLine.ToString();
                    pictureBox.Size = new Size(cellWidth - 10, 180);
                    pictureBox.BackColor = Color.BlueViolet;
                    pictureBox.Location = new Point(cellWidth * randomLine, -180);
                    pictureBox.Image = Properties.Resources.card;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Parent = gamePanel;

                    pictureBox.MouseClick += pictureBox_MouseClick;

                    takeLine(pictureBox);

                    PictureBoxes.Add(pictureBox);
                }
            }

            
        }
        async void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            my_sound.Stop();
            DialogResult result = MessageBox.Show(
                "Игра завершена.\n" +
                "Ваш счет: " + score.ToString(),
                "Игра окончена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.OK)
            {
                var connection = new Connection();
                var task = Task.Run(() => connection.saveGameResult(Properties.Settings.Default.UserId, score));
                
                Visible = false;
                MainForm.GetInstance().Show();

                Reset();
                await task;
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            var pic = (sender as PictureBox);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        picClicked(pic);
                        break;
                    }
                    
            }
        }

        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    {
                        if (gameIsStarted)
                            picPressed("0");
                        break;
                    }
                case Keys.S:
                    {
                        if (gameIsStarted)
                            picPressed("1");
                        break;
                    }
                case Keys.D:
                    {
                        if (gameIsStarted)
                            picPressed("2");
                        break;
                    }
                case Keys.Escape:
                {
                    Pause();

                    break;
                }

            }
        }

        private void Reset()
        {
            foreach (var t in PictureBoxes)
            {
                gamePanel.Controls.Remove(t);
                freeLine(t);
            }
            targetBoxes.Clear();
            PictureBoxes.Clear();

            worker.Dispose();
        }

        private void Pause()
        {
            gameIsStarted = !gameIsStarted;

            if (!gameIsStarted)
            {
                my_sound.Pause();
                gamePanel.Visible = false;
                pausePanel.Visible = true;
            }
            else
            {
                my_sound.Play();
                SetVolume(Properties.Settings.Default.GeneralVolume);
                gamePanel.Visible = true;
                pausePanel.Visible = false;
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void BackPicBox_Click(object sender, EventArgs e)
        {
            Visible = false;
            MainForm.GetInstance().Show();

            Reset();
        }

        private void pauseContinueButton_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void pauseApplicationExitButton_Click(object sender, EventArgs e)
        {
            my_sound.Stop();
            DialogResult result = MessageBox.Show(
                "Выйти из игры?",
                "Выход из игры",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pauseAboutButton_Click(object sender, EventArgs e)
        {
            About.GetInstance().SetBackForm(this);
            Hide();
            About.GetInstance().Show();
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics g = e.Graphics;
            

            using (var brush = new SolidBrush(Color.FromArgb(112, Color.Red)))
            {
                if (panel != null)
                {
                    Rectangle rect = new Rectangle(new Point(panel.Location.X, gamePictureBoxTargerPanel.Location.Y), new Size(panel.Width, gamePictureBoxTargerPanel.Height));
                    g.FillRectangle(brush, rect);
                }
            }
        }

        private void pauseSettingsButton_Click(object sender, EventArgs e)
        {
            Settings.GetInstance().SetBackForm(this);
            this.Hide();
            Settings.GetInstance().ShowDialog();
        }

        private void pause_PictureBox_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void pauseGameExitButton_Click_1(object sender, EventArgs e)
        {
            my_sound.Stop();
            DialogResult result = MessageBox.Show(
                "Игра завершена.\n" +
                "Ваш счет: " + score.ToString(),
                "Игра окончена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.OK)
            {
                var connection = new Connection();
                connection.saveGameResult(Properties.Settings.Default.UserId, score);
                
                Visible = false;
                MainForm.GetInstance().Show();

                Reset();
            }
        }
    }
}
