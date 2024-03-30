namespace EmojiCatcher
{
    partial class StillEmojiCatcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StillEmojiCatcher));
            this.DifGroup = new System.Windows.Forms.GroupBox();
            this.DifHard = new System.Windows.Forms.RadioButton();
            this.DifMedium = new System.Windows.Forms.RadioButton();
            this.DifEasy = new System.Windows.Forms.RadioButton();
            this.WelcomeLebel = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.TimerShow = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FinalMsg = new System.Windows.Forms.Label();
            this.Emoji1 = new System.Windows.Forms.PictureBox();
            this.Emoji2 = new System.Windows.Forms.PictureBox();
            this.Emoji3 = new System.Windows.Forms.PictureBox();
            this.DifGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji3)).BeginInit();
            this.SuspendLayout();
            // 
            // DifGroup
            // 
            this.DifGroup.Controls.Add(this.DifHard);
            this.DifGroup.Controls.Add(this.DifMedium);
            this.DifGroup.Controls.Add(this.DifEasy);
            this.DifGroup.Location = new System.Drawing.Point(20, 103);
            this.DifGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DifGroup.Name = "DifGroup";
            this.DifGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DifGroup.Size = new System.Drawing.Size(151, 123);
            this.DifGroup.TabIndex = 0;
            this.DifGroup.TabStop = false;
            this.DifGroup.Text = "Difficulty";
            // 
            // DifHard
            // 
            this.DifHard.AutoSize = true;
            this.DifHard.Location = new System.Drawing.Point(20, 80);
            this.DifHard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DifHard.Name = "DifHard";
            this.DifHard.Size = new System.Drawing.Size(58, 20);
            this.DifHard.TabIndex = 3;
            this.DifHard.Text = "Hard";
            this.DifHard.UseVisualStyleBackColor = true;
            // 
            // DifMedium
            // 
            this.DifMedium.AutoSize = true;
            this.DifMedium.Location = new System.Drawing.Point(20, 52);
            this.DifMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DifMedium.Name = "DifMedium";
            this.DifMedium.Size = new System.Drawing.Size(76, 20);
            this.DifMedium.TabIndex = 2;
            this.DifMedium.Text = "Medium";
            this.DifMedium.UseVisualStyleBackColor = true;
            // 
            // DifEasy
            // 
            this.DifEasy.AutoSize = true;
            this.DifEasy.Location = new System.Drawing.Point(20, 23);
            this.DifEasy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DifEasy.Name = "DifEasy";
            this.DifEasy.Size = new System.Drawing.Size(59, 20);
            this.DifEasy.TabIndex = 1;
            this.DifEasy.Text = "Easy";
            this.DifEasy.UseVisualStyleBackColor = true;
            // 
            // WelcomeLebel
            // 
            this.WelcomeLebel.AutoSize = true;
            this.WelcomeLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLebel.Location = new System.Drawing.Point(29, 23);
            this.WelcomeLebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLebel.Name = "WelcomeLebel";
            this.WelcomeLebel.Size = new System.Drawing.Size(162, 24);
            this.WelcomeLebel.TabIndex = 1;
            this.WelcomeLebel.Text = "Welcome Player";
            this.WelcomeLebel.Click += new System.EventHandler(this.WelcomeLebel_Click);
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLabel.Location = new System.Drawing.Point(16, 34);
            this.PlayerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(175, 22);
            this.PlayerNameLabel.TabIndex = 2;
            this.PlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerNameLabel.Click += new System.EventHandler(this.PlayerName_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.TimerShow);
            this.panel1.Controls.Add(this.Score);
            this.panel1.Controls.Add(this.ScoreLabel);
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.WelcomeLebel);
            this.panel1.Controls.Add(this.PlayerNameLabel);
            this.panel1.Controls.Add(this.DifGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 562);
            this.panel1.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(45, 479);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 28);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(45, 437);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 28);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TimerShow
            // 
            this.TimerShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerShow.Location = new System.Drawing.Point(69, 297);
            this.TimerShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimerShow.Name = "TimerShow";
            this.TimerShow.Size = new System.Drawing.Size(52, 20);
            this.TimerShow.TabIndex = 6;
            this.TimerShow.Text = "0";
            this.TimerShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(65, 389);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(64, 21);
            this.Score.TabIndex = 5;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(57, 353);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(58, 20);
            this.ScoreLabel.TabIndex = 4;
            this.ScoreLabel.Text = "Score";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(65, 263);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(50, 20);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FinalMsg
            // 
            this.FinalMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.FinalMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalMsg.Location = new System.Drawing.Point(133, 0);
            this.FinalMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FinalMsg.Name = "FinalMsg";
            this.FinalMsg.Size = new System.Drawing.Size(907, 562);
            this.FinalMsg.TabIndex = 6;
            this.FinalMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FinalMsg.Visible = false;
            this.FinalMsg.Click += new System.EventHandler(this.FinalMsg_Click);
            // 
            // Emoji1
            // 
            this.Emoji1.Image = global::EmojiCatcher.Properties.Resources._1st;
            this.Emoji1.Location = new System.Drawing.Point(659, 239);
            this.Emoji1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Emoji1.Name = "Emoji1";
            this.Emoji1.Size = new System.Drawing.Size(133, 123);
            this.Emoji1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emoji1.TabIndex = 7;
            this.Emoji1.TabStop = false;
            this.Emoji1.Visible = false;
            this.Emoji1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Emoji2
            // 
            this.Emoji2.Image = global::EmojiCatcher.Properties.Resources._2nd;
            this.Emoji2.Location = new System.Drawing.Point(359, 204);
            this.Emoji2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Emoji2.Name = "Emoji2";
            this.Emoji2.Size = new System.Drawing.Size(100, 92);
            this.Emoji2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emoji2.TabIndex = 8;
            this.Emoji2.TabStop = false;
            this.Emoji2.Visible = false;
            this.Emoji2.Click += new System.EventHandler(this.Emoji2_Click);
            // 
            // Emoji3
            // 
            this.Emoji3.Image = global::EmojiCatcher.Properties.Resources._3rd;
            this.Emoji3.Location = new System.Drawing.Point(513, 404);
            this.Emoji3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Emoji3.Name = "Emoji3";
            this.Emoji3.Size = new System.Drawing.Size(67, 62);
            this.Emoji3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emoji3.TabIndex = 9;
            this.Emoji3.TabStop = false;
            this.Emoji3.Visible = false;
            this.Emoji3.Click += new System.EventHandler(this.Emoji3_Click);
            // 
            // StillEmojiCatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 562);
            this.Controls.Add(this.Emoji3);
            this.Controls.Add(this.Emoji2);
            this.Controls.Add(this.Emoji1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FinalMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "StillEmojiCatcher";
            this.Text = "Still Emoji Catcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.DifGroup.ResumeLayout(false);
            this.DifGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emoji3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DifGroup;
        private System.Windows.Forms.RadioButton DifHard;
        private System.Windows.Forms.RadioButton DifMedium;
        private System.Windows.Forms.RadioButton DifEasy;
        private System.Windows.Forms.Label WelcomeLebel;
        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TimerShow;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label FinalMsg;
        private System.Windows.Forms.PictureBox Emoji1;
        private System.Windows.Forms.PictureBox Emoji2;
        private System.Windows.Forms.PictureBox Emoji3;
    }
}