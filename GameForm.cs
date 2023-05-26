using PianinoGame.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PianinoGame.Models;
using Timer = System.Threading.Timer;

namespace PianinoGame
{
    public partial class GameForm : Form
    {
        // TODO доделать, ща акцент на скринах с формами сделаю и всё
        private static GameForm _gameForm;
        
        
        
        private bool gameIsStarted = true;
        private bool gameIsFinished = false;


        public string name = "Игрок";

        private int Line = 0;
        private static int cellWidth = 0;
        private List<PictureBox> PictureBoxes = new List<PictureBox>();
        BackgroundWorker worker;
        private int score = 0;

        private bool line1IsFree = true;
        private bool line2IsFree = true;
        private bool line3IsFree = true;

        private int timeSleep = 50;


        private GameForm()
        {
            InitializeComponent();

            cellWidth = this.Width / 3;


            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_GameProccess;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync(10000);

            this.KeyUp += new KeyEventHandler(Form1_KeyUp);
        }


        public static GameForm GetInstance()
        {
            if (_gameForm == null)
            {
                _gameForm = new GameForm();
            }
            return _gameForm;
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
            picture.Hide();
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
            if (PictureBoxes.Count != 0)
            {
                if (PictureBoxes[0].Name.Equals(key))
                {
                    closePic(PictureBoxes[0]);
                }
            }
        }
       
        public void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            for (int i = PictureBoxes.Count-1; i >= 0; i--)
            {
                PictureBox picture = PictureBoxes[i];
                picture.Location = new Point(picture.Location.X, picture.Location.Y + 10);
                if (picture.Location.Y > this.Height)
                {
                    gameIsFinished = true;
                }
                if (picture.Location.Y > 30 + 180)
                {
                    freeLine(picture);
                }
            }
            
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
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
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
                Connection connection = Connection.GetInstanse();
                connection.insertUser(name, score);
                this.Hide();
                MainForm.GetInstance().Show();
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

        private void Pause()
        {
            gameIsStarted = !gameIsStarted;

            if (!gameIsStarted)
            {
                gamePanel.Visible = false;
                pausePanel.Visible = true;
            }
            else
            {
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
            Close();
            MainForm.GetInstance().Show();
        }

        private void pauseContinueButton_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void pauseApplicationExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pauseAboutButton_Click(object sender, EventArgs e)
        {
            About.GetInstance().Show();
        }
    }
}
