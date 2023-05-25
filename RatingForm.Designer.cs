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
            this.label1 = new System.Windows.Forms.Label();
            this.RatingNamePlace = new System.Windows.Forms.Label();
            this.btn_BackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рейтинг";
            // 
            // RatingNamePlace
            // 
            this.RatingNamePlace.AutoSize = true;
            this.RatingNamePlace.BackColor = System.Drawing.Color.Transparent;
            this.RatingNamePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingNamePlace.Location = new System.Drawing.Point(83, 132);
            this.RatingNamePlace.Name = "RatingNamePlace";
            this.RatingNamePlace.Size = new System.Drawing.Size(88, 24);
            this.RatingNamePlace.TabIndex = 1;
            this.RatingNamePlace.Text = "1. Место";
            this.RatingNamePlace.Click += new System.EventHandler(this.RatingNamePlace_Click);
            // 
            // btn_BackToMainMenu
            // 
            this.btn_BackToMainMenu.Location = new System.Drawing.Point(174, 509);
            this.btn_BackToMainMenu.Name = "btn_BackToMainMenu";
            this.btn_BackToMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btn_BackToMainMenu.TabIndex = 2;
            this.btn_BackToMainMenu.Text = "Назад";
            this.btn_BackToMainMenu.UseVisualStyleBackColor = true;
            this.btn_BackToMainMenu.Click += new System.EventHandler(this.btn_BackToMainMenu_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(444, 561);
            this.Controls.Add(this.btn_BackToMainMenu);
            this.Controls.Add(this.RatingNamePlace);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rating";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RatingForm_FormClosed);
            this.Load += new System.EventHandler(this.atingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_BackToMainMenu;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RatingNamePlace;
    }
}