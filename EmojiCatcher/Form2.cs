using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiCatcher
{
    public partial class StillEmojiCatcher : Form
    {
        public StillEmojiCatcher()
        {
            InitializeComponent();
        }

        //Defficulty setting is in Difficulty class. If possible, do not touch anything here.

        //Start Score
        int score = 0;

        //Use dif.Diff == 0 mean user select easy, == 1 mean medium, == 2 mean hard.
        Settings settings = new Settings();
        
        //Trigger this one if want to start the game.
        public void startGame()
        {
            TimerShow.Text = Timer.times.ToString();
            timer1.Enabled = true;
            DifGroup.Enabled = false;
            StartButton.Enabled = false;
            Emoji1.Visible = true;
        }

        //Use this method for increasing score every time emoji has been clicked.
        public void addScore()
        {
            score++;
            Score.Text = score.ToString();
        }

        //Trigger this for bonus time, this only add 1 second to timer.
        public void bonusTime()
        {
            Timer.times += settings.bonusTimer;
            TimerShow.Text = Timer.times.ToString();
        }

        //This method should trigger when timer reach 0.
        public void endGame()
        {
            Emoji1.Visible = false;
            Emoji2.Visible = false;
            Emoji3.Visible = false;
            timer1.Enabled = false;
            FinalMsg.Visible = true;
            FinalMsg.Text = "The Game is END and your Score is: " + score.ToString();

            StartButton.Enabled = true;
            DifGroup.Enabled = true;
            DifEasy.Checked = false;
            DifMedium.Checked = false;
            DifHard.Checked = false;
        }

        //Trigger this to reset everything.
        public void reset()
        {
            score = 0;
            Score.Text = score.ToString();
            this.Size = new Size(settings.flsx, settings.flsy);
            FinalMsg.Visible = false;
            Emoji1.Location = new Point(400, 150);
            Emoji2.Location = new Point(400, 150);
            Emoji3.Location = new Point(400, 150);
            FinalMsg.Dock = DockStyle.Right;
        }

        //Load player name on open form2.
        private void Form2_Load(object sender, EventArgs e)
        {
            PlayerNameLabel.Text = PlayerName.name;
            this.Size = new Size(settings.flsx, settings.flsy);
        }

        //To make sure form1 is closed when closing form2 since form1 just hiding in background.
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        int gc = 1;
        private void PlayerName_Click(object sender, EventArgs e)
        {
            void bonusTime(int gcb)
            {
                Timer.times +=gcb;
                TimerShow.Text = Timer.times.ToString();
            }

            if (gc == 4)
            {
                MessageBox.Show("This game is made by 『Mr.Curse』");
                gc = 1;
                
                if (timer1.Enabled == true)
                {
                    int c = r.Next(1, 3);
                    int d = r.Next(1, 10);

                    if (c == 2)
                    {
                        bonusTime(d);
                    }
                }
            }
            gc++;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

        }

        //If you want to trigger something when start the game, you should write it here.
        private void StartButton_Click(object sender, EventArgs e)
        {
            reset();

            if (DifEasy.Checked)
            {
                settings.Diff = 0;
                Timer.times = settings.startTimer;
                Emoji1.Size = new Size(settings.e0, settings.e0);
                Emoji2.Size = new Size(settings.e2, settings.e2);
                Emoji3.Size = new Size(settings.e4, settings.e4);
                startGame();

            } else if (DifMedium.Checked)
            {
                settings.Diff = 1;
                Timer.times = settings.startTimer;
                Emoji1.Size = new Size(settings.m0, settings.m0);
                Emoji2.Size = new Size(settings.m2, settings.m2);
                Emoji3.Size = new Size(settings.m4, settings.m4);
                startGame();

            } else if (DifHard.Checked)
            {
                settings.Diff = 2;
                Timer.times = settings.startTimer;
                Emoji1.Size = new Size(settings.h0, settings.h0);
                Emoji2.Size = new Size(settings.h2, settings.h2);
                Emoji3.Size = new Size(settings.h4, settings.h4);
                startGame();
            }
            else { MessageBox.Show("You forget to choose the Difficulty!");
            }
        }

        //Shouldn't edit this one.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //This is timer part that link to Timer class. Use timerReduce() from Timer class for reduce time per timer1 tick.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timer.times != 0)
            {
                Timer.timerReduce();
                TimerShow.Text = Timer.times.ToString();
            }
            else
            {
                endGame();
            }
        }

        Random r = new Random();

        //Default Windows Size is 800x500 random should be x = (154,680) y = (0,357) for First emoji
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (score == 4)
            {
                if (settings.Diff == 0)
                {
                    Emoji1.Size = new Size(settings.e1, settings.e1);
                } else if (settings.Diff == 1)
                {
                    Emoji1.Size = new Size(settings.m1, settings.m1);
                } else if (settings.Diff == 2)
                {
                    Emoji1.Size = new Size(settings.h1, settings.h1);
                }
            }

            if (score == 9)
            {
                this.Size = new Size(settings.slsx, settings.slsy);
                Emoji1.Visible = false;
                Emoji2.Visible = true;
                bonusTime();
            }

            addScore();

            int x = r.Next(settings.flx1, settings.flx2);
            int y = r.Next(settings.fly1, settings.fly2);
            Emoji1.Location = new Point(x, y);
        }

        //Windows Size is 900x700 random should be x = (154,805) y = (0,582) for Second emoji
        private void Emoji2_Click(object sender, EventArgs e)
        {
            if (score == 14)
            {
                if (settings.Diff == 0)
                {
                    Emoji2.Size = new Size(settings.e3, settings.e3);
                } else if (settings.Diff == 1)
                {
                    Emoji2.Size = new Size(settings.m3, settings.m3);
                } else if (settings.Diff == 2)
                {
                    Emoji2.Size = new Size(settings.h3, settings.h3);
                }
            }

            if (score == 19)
            {
                this.Size = new Size(settings.tlsx, settings.tlsy);
                Emoji2.Visible = false;
                Emoji3.Visible = true;
                bonusTime();

                FinalMsg.Dock = DockStyle.Fill;
            }

            addScore();

            int x = r.Next(settings.slx1, settings.slx2);
            int y = r.Next(settings.sly1, settings.sly2);
            Emoji2.Location = new Point(x, y);
        }

        //Windows Size is 1100x900 random should be x = (154,1030) y = (0,807) for Third emoji
        private void Emoji3_Click(object sender, EventArgs e)
        {
            if (score == 24)
            {
                if (settings.Diff == 0)
                {
                    Emoji3.Size = new Size(settings.e5, settings.e5);
                } else if (settings.Diff == 1)
                {
                    Emoji3.Size = new Size(settings.m5, settings.m5);
                } else if (settings.Diff == 2)
                {
                    Emoji3.Size = new Size(settings.h5, settings.h5);
                }
            }

            if (score > 24)
            {
                if (settings.Diff == 0)
                {
                    int z = r.Next(settings.e6, settings.e7);
                    Emoji3.Size = new Size(z, z);
                } else if (settings.Diff == 1)
                {
                    int z = r.Next(settings.m6, settings.m7);
                    Emoji3.Size = new Size(z, z);

                } else if (settings.Diff == 2)
                {
                    int z = r.Next(settings.h6, settings.h7);
                    Emoji3.Size = new Size(z, z);
                }
            }

            addScore();

            if (score % 10 == 0)
            {
                bonusTime();
            }

            int x = r.Next(settings.tlx1, settings.tlx2);
            int y = r.Next(settings.tly1, settings.tly2);
            Emoji3.Location = new Point(x, y);
        }

        private void FinalMsg_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeLebel_Click(object sender, EventArgs e)
        {

        }
    }
}
