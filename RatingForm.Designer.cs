namespace PianinoGame
{
    partial class RatingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.RatingNamePlace = new System.Windows.Forms.Label();
            this.btn_BackToMainMenu = new System.Windows.Forms.Button();
            this.GeneralRatingLabel = new System.Windows.Forms.Label();
            this.PersonalRatingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // RatingNamePlace
            // 
            resources.ApplyResources(this.RatingNamePlace, "RatingNamePlace");
            this.RatingNamePlace.BackColor = System.Drawing.Color.Transparent;
            this.RatingNamePlace.Name = "RatingNamePlace";
            this.RatingNamePlace.Click += new System.EventHandler(this.RatingNamePlace_Click);
            // 
            // btn_BackToMainMenu
            // 
            resources.ApplyResources(this.btn_BackToMainMenu, "btn_BackToMainMenu");
            this.btn_BackToMainMenu.Name = "btn_BackToMainMenu";
            this.btn_BackToMainMenu.UseVisualStyleBackColor = true;
            this.btn_BackToMainMenu.Click += new System.EventHandler(this.btn_BackToMainMenu_Click);
            // 
            // GeneralRatingLabel
            // 
            resources.ApplyResources(this.GeneralRatingLabel, "GeneralRatingLabel");
            this.GeneralRatingLabel.Name = "GeneralRatingLabel";
            this.GeneralRatingLabel.Click += new System.EventHandler(this.GeneralRatingLabel_Click);
            // 
            // PersonalRatingLabel
            // 
            resources.ApplyResources(this.PersonalRatingLabel, "PersonalRatingLabel");
            this.PersonalRatingLabel.Name = "PersonalRatingLabel";
            this.PersonalRatingLabel.Click += new System.EventHandler(this.PersonalRatingLabel_Click);
            // 
            // RatingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.PersonalRatingLabel);
            this.Controls.Add(this.GeneralRatingLabel);
            this.Controls.Add(this.btn_BackToMainMenu);
            this.Controls.Add(this.RatingNamePlace);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RatingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RatingForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.ControlBox = false;
        }

        private System.Windows.Forms.Label GeneralRatingLabel;
        private System.Windows.Forms.Label PersonalRatingLabel;

        private System.Windows.Forms.Button btn_BackToMainMenu;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RatingNamePlace;
    }
}