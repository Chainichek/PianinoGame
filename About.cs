using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianinoGame
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            aboutTextLabel.Text = "Цель этой игры - не дать упасть за экран плиткам, падающим сверху.\n\n" +
                "Экран игры разделен на три вертикальные полосы, по которым двигаюся плитки. \n\n" +
                "Играть можно как мышью, так и клавиатурой.\n" +
                "Игра мышкой: кликайте левой кнопкой по плиткам, чтобы зарабатывать очки.\n" +
                "Игра клавиатурой: для игры требуется 3 клавишы: A, S, D.\n" +
                "Клавиша A отвечает за нажатие плиток на 1 полосе. (Самая левая).\n" +
                "Клавиша S отвечает за нажатие плиток на 2 полосе. (По цетру)\n" +
                "Клавиша D отвечает за нажатие плиток на 3 полосе. (Самая правая)\n\n" +
                "Нажимать или кликать нужно на самую нижнюю плитку.";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
