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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (NameInput.Text == "")
            {
                MessageBox.Show("Please type in your name");
            } else if (NameInput.Text.Length > 12)
            {
                MessageBox.Show("Name max length is 12.\nPlease reenter your name again.");
                NameInput.Text = "";
            } else
            {
                PlayerName.name = NameInput.Text;
                Hide();
                StillEmojiCatcher form2 = new StillEmojiCatcher();
                form2.ShowDialog();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
