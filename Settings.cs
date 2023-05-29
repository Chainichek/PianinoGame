using System;
using System.Windows.Forms;

namespace PianinoGame
{
    public partial class Settings : Form
    {
        private static Settings _settings;

        private Settings()
        {
            InitializeComponent();
        }


        public static Settings GetInstance()
        {
            return _settings ?? (_settings = new Settings());
        }
    }
}