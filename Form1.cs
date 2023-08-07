using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White);

            Pen.Width = 5;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 270, 170, 670, 170);
            e.Graphics.DrawLine(Pen, 270, 290, 670, 290);

            e.Graphics.DrawLine(Pen, 400, 70, 400, 380);
            e.Graphics.DrawLine(Pen, 550, 70, 550, 380);
        }

        private void ChangeCurrentPlayer()
        {
            if (lbPlayer.Tag.ToString() == "X")
            {
                lbPlayer.Text = "Player 2";
                lbPlayer.Tag = "O";
            }

            else
            {
                lbPlayer.Text = "Player 1";
                lbPlayer.Tag = "X";
            }

        }

        private void EnableButtons()
        {
            pbBox1.Enabled = true;
            pbBox2.Enabled = true;
            pbBox3.Enabled = true;
            pbBox4.Enabled = true;
            pbBox5.Enabled = true;
            pbBox6.Enabled = true;
            pbBox7.Enabled = true;
            pbBox8.Enabled = true;
            pbBox9.Enabled = true;
        }

        private void ResetImagesAndTagValue()
        {
            pbBox1.Image = Properties.Resources.QuestionMark;
            pbBox1.Tag = "Empty";

            pbBox2.Image = Properties.Resources.QuestionMark;
            pbBox2.Tag = "Empty";
            
            pbBox3.Image = Properties.Resources.QuestionMark;
            pbBox3.Tag = "Empty";
            
            pbBox4.Image = Properties.Resources.QuestionMark;
            pbBox4.Tag = "Empty";
            
            pbBox5.Image = Properties.Resources.QuestionMark;
            pbBox5.Tag = "Empty";
            
            pbBox6.Image = Properties.Resources.QuestionMark;
            pbBox6.Tag = "Empty";
            
            pbBox7.Image = Properties.Resources.QuestionMark;
            pbBox7.Tag = "Empty";
            
            pbBox8.Image = Properties.Resources.QuestionMark;
            pbBox8.Tag = "Empty";
            
            pbBox9.Image = Properties.Resources.QuestionMark;
            pbBox9.Tag = "Empty";
        }

        private void ResetButtons()
        {
            ResetImagesAndTagValue();
            EnableButtons();
        }

        private void DisableButtons()
        {
            pbBox1.Enabled = false;
            pbBox2.Enabled = false;
            pbBox3.Enabled = false;
            pbBox4.Enabled = false;
            pbBox5.Enabled = false;
            pbBox6.Enabled = false;
            pbBox7.Enabled = false;
            pbBox8.Enabled = false;
            pbBox9.Enabled = false;
        }

        private string CheckAndGetWinnerLetter()
        {
            if (pbBox1.Tag.ToString() != "Empty")
            {
                if (pbBox1.Tag.ToString() == pbBox2.Tag.ToString() && pbBox1.Tag.ToString() == pbBox3.Tag.ToString())
                    return Convert.ToString(pbBox1.Tag);

                if (pbBox1.Tag.ToString() == pbBox4.Tag.ToString() && pbBox1.Tag.ToString() == pbBox7.Tag.ToString())
                    return Convert.ToString(pbBox1.Tag);

                if (pbBox1.Tag.ToString() == pbBox5.Tag.ToString() && pbBox1.Tag.ToString() == pbBox9.Tag.ToString())
                    return Convert.ToString(pbBox1.Tag);
            }

            if (pbBox2.Tag.ToString() != "Empty")
            {
                if (pbBox2.Tag.ToString() == pbBox5.Tag.ToString() && pbBox2.Tag.ToString() == pbBox8.Tag.ToString())
                    return Convert.ToString(pbBox2.Tag);
            }

            if (pbBox3.Tag.ToString() != "Empty")
            {
                if (pbBox3.Tag.ToString() == pbBox6.Tag.ToString() && pbBox3.Tag.ToString() == pbBox9.Tag.ToString())
                    return Convert.ToString(pbBox3.Tag);

                if (pbBox3.Tag.ToString() == pbBox5.Tag.ToString() && pbBox3.Tag.ToString() == pbBox7.Tag.ToString())
                    return Convert.ToString(pbBox3.Tag);
            }


            if (pbBox4.Tag.ToString() != "Empty")
            {
                if (pbBox4.Tag.ToString() == pbBox5.Tag.ToString() && pbBox4.Tag.ToString() == pbBox6.Tag.ToString())
                    return Convert.ToString(pbBox4.Tag);
            }


            if (pbBox7.Tag.ToString() != "Empty")
            {
                if (pbBox7.Tag.ToString() == pbBox8.Tag.ToString() && pbBox7.Tag.ToString() == pbBox9.Tag.ToString())
                    return Convert.ToString(pbBox7.Tag);
            }

            return null;
        }

        private void pbBox_Click(object sender, MouseEventArgs e)
        {
            string Winner;

            if (((PictureBox)sender).Tag.ToString() == "Empty")
            {
                if (lbPlayer.Tag.ToString() == "X")
                {
                    ((PictureBox)sender).Tag = "X";
                    ((PictureBox)sender).Image = Properties.Resources.X;
                }

                else
                {
                    ((PictureBox)sender).Tag = "O";
                    ((PictureBox)sender).Image = Properties.Resources.O;
                }

                if ((Winner = CheckAndGetWinnerLetter()) != null)
                {
                    lbWinner.Text = lbPlayer.Text.ToString();

                    DisableButtons();

                    MessageBox.Show("Winner is: " + Winner, "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    return;
                }

                ChangeCurrentPlayer();
            }

            else
            {
                MessageBox.Show("Worng Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbBox1_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox2_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox3_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox4_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox5_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox6_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox7_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox8_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void pbBox9_Click(object sender, EventArgs e)
        {
            pbBox_Click(sender, (System.Windows.Forms.MouseEventArgs)e);
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetButtons();
        }

    }
}
