namespace PianinoGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.startGameLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // startGameLabel
            // 
            resources.ApplyResources(this.startGameLabel, "startGameLabel");
            this.startGameLabel.BackColor = System.Drawing.Color.Transparent;
            this.startGameLabel.Name = "startGameLabel";
            this.startGameLabel.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // ratingLabel
            // 
            resources.ApplyResources(this.ratingLabel, "ratingLabel");
            this.ratingLabel.BackColor = System.Drawing.Color.Transparent;
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Click += new System.EventHandler(this.RatingLabel_Click);
            // 
            // exitLabel
            // 
            resources.ApplyResources(this.exitLabel, "exitLabel");
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // aboutLabel
            // 
            resources.ApplyResources(this.aboutLabel, "aboutLabel");
            this.aboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // settingsLabel
            // 
            resources.ApplyResources(this.settingsLabel, "settingsLabel");
            this.settingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Click += new System.EventHandler(this.settingsLabel_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.settingsLabel);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.startGameLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startGameLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label settingsLabel;
    }
}

