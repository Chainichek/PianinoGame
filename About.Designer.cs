
namespace PianinoGame
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.AboutLabel = new System.Windows.Forms.Label();
            this.aboutTextLabel = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            resources.ApplyResources(this.AboutLabel, "AboutLabel");
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.Name = "AboutLabel";
            // 
            // aboutTextLabel
            // 
            resources.ApplyResources(this.aboutTextLabel, "aboutTextLabel");
            this.aboutTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutTextLabel.Name = "aboutTextLabel";
            // 
            // btn_Back
            // 
            resources.ApplyResources(this.btn_Back, "btn_Back");
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // About
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.aboutTextLabel);
            this.Controls.Add(this.AboutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_Back;

        #endregion

        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label aboutTextLabel;
    }
}