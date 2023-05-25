
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
            this.AboutLabel = new System.Windows.Forms.Label();
            this.aboutTextLabel = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLabel.Location = new System.Drawing.Point(147, 43);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(92, 26);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "Об игре";
            // 
            // aboutTextLabel
            // 
            this.aboutTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.aboutTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutTextLabel.Location = new System.Drawing.Point(22, 105);
            this.aboutTextLabel.Name = "aboutTextLabel";
            this.aboutTextLabel.Size = new System.Drawing.Size(395, 392);
            this.aboutTextLabel.TabIndex = 1;
            this.aboutTextLabel.Text = "текст об игре\r\n";
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Back.Location = new System.Drawing.Point(164, 526);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.aboutTextLabel);
            this.Controls.Add(this.AboutLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_Back;

        #endregion

        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label aboutTextLabel;
    }
}