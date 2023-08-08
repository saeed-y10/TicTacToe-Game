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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        enPlayer PlayerTurn = enPlayer.Player1;
        stGameResults GameStatus;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(White);

            Pen.Width = 10;

            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;

            // Draw Horizental Lines
            e.Graphics.DrawLine(Pen, 270, 160, 670, 160);
            e.Graphics.DrawLine(Pen, 270, 280, 670, 280);

            // Draw Vertical Lines
            e.Graphics.DrawLine(Pen, 400, 70, 400, 375);
            e.Graphics.DrawLine(Pen, 550, 70, 550, 375);
        }

        enum enPlayer
        {
            Player1,
            Player2,
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameResults
        {
            public enWinner Winner;
            public bool GameEnd;
            public Byte GameCount;
        }

        private void ResetButton(Button btn)
        {
            btn.Image = Properties.Resources.QuestionMark;
            btn.Tag = "?";
            btn.BackColor = Color.Black;
            btn.TabStop = true;
        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            PlayerTurn = enPlayer.Player1;
            lblPlayer.Text = "Player 1";
            GameStatus.GameEnd = false;
            GameStatus.GameCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
            lblWinner.Text = "In Progress";
        }

        void EndGame()
        {
            lblPlayer.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("game over", "game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                    GameStatus.Winner = enWinner.Player1;

                else
                    GameStatus.Winner = enWinner.Player2;

                GameStatus.GameEnd = true;
                EndGame();
                return true;
            }

            GameStatus.GameEnd = false;
            return false;
        }

        void CheckWinner()
        {
            // Check Rows
            //-----------------------------

            // Check Row 1
            if (CheckValues(button1, button2, button3))
                return;

            // Check Row 2
            if (CheckValues(button4, button5, button6))
                return;

            // Check Row 3
            if (CheckValues(button7, button8, button9))
                return;

            // Check Cols
            //-----------------------------

            // Check Col 1
            if (CheckValues(button1, button4, button7))
                return;

            // Check Col 2
            if (CheckValues(button2, button5, button8))
                return;

            // Check Col 3
            if (CheckValues(button3, button6, button9))
                return;

            // Check Diagonals
            //-----------------------------

            // Check Diagonal 1
            if (CheckValues(button1, button5, button9))
                return;

            // Check Diagonal 2
            if (CheckValues(button3, button5, button7))
                return;
        }

        private void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Properties.Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblPlayer.Text = "Player 2";
                        GameStatus.GameCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Properties.Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblPlayer.Text = "Player 1";
                        GameStatus.GameCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }

                btn.TabStop = false;
            }

            else
            {
                MessageBox.Show("wrong choice", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.GameCount == 9 && GameStatus.Winner == enWinner.GameInProgress)
            {
                GameStatus.GameEnd = true;
                GameStatus.Winner = enWinner.Draw;
                EndGame();
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }

    }
}
