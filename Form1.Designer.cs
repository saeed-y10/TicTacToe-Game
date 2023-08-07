namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pbBox1 = new System.Windows.Forms.PictureBox();
            this.pbBox2 = new System.Windows.Forms.PictureBox();
            this.pbBox3 = new System.Windows.Forms.PictureBox();
            this.pbBox4 = new System.Windows.Forms.PictureBox();
            this.pbBox5 = new System.Windows.Forms.PictureBox();
            this.pbBox6 = new System.Windows.Forms.PictureBox();
            this.pbBox7 = new System.Windows.Forms.PictureBox();
            this.pbBox8 = new System.Windows.Forms.PictureBox();
            this.pbBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Skranji", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbTitle.Location = new System.Drawing.Point(392, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(471, 58);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tic Tac Toe Game";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lemon", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(21, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winner";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Lemon", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.Lime;
            this.lbWinner.Location = new System.Drawing.Point(21, 318);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(248, 43);
            this.lbWinner.TabIndex = 3;
            this.lbWinner.Text = "In Progress";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Lemon", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.Color.Snow;
            this.lbPlayer.Location = new System.Drawing.Point(21, 174);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(179, 43);
            this.lbPlayer.TabIndex = 4;
            this.lbPlayer.Tag = "Player 1";
            this.lbPlayer.Text = "Player 1";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestartGame.Location = new System.Drawing.Point(29, 390);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(211, 43);
            this.btnRestartGame.TabIndex = 5;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click);
            // 
            // pbBox1
            // 
            this.pbBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox1.Location = new System.Drawing.Point(392, 91);
            this.pbBox1.Name = "pbBox1";
            this.pbBox1.Size = new System.Drawing.Size(100, 86);
            this.pbBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox1.TabIndex = 6;
            this.pbBox1.TabStop = false;
            this.pbBox1.Tag = "Empty";
            this.pbBox1.Click += new System.EventHandler(this.pbBox1_Click);
            // 
            // pbBox2
            // 
            this.pbBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox2.Location = new System.Drawing.Point(578, 91);
            this.pbBox2.Name = "pbBox2";
            this.pbBox2.Size = new System.Drawing.Size(100, 86);
            this.pbBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox2.TabIndex = 7;
            this.pbBox2.TabStop = false;
            this.pbBox2.Tag = "Empty";
            this.pbBox2.Click += new System.EventHandler(this.pbBox2_Click);
            // 
            // pbBox3
            // 
            this.pbBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox3.Location = new System.Drawing.Point(763, 91);
            this.pbBox3.Name = "pbBox3";
            this.pbBox3.Size = new System.Drawing.Size(100, 86);
            this.pbBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox3.TabIndex = 8;
            this.pbBox3.TabStop = false;
            this.pbBox3.Tag = "Empty";
            this.pbBox3.Click += new System.EventHandler(this.pbBox3_Click);
            // 
            // pbBox4
            // 
            this.pbBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox4.Location = new System.Drawing.Point(392, 237);
            this.pbBox4.Name = "pbBox4";
            this.pbBox4.Size = new System.Drawing.Size(100, 86);
            this.pbBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox4.TabIndex = 9;
            this.pbBox4.TabStop = false;
            this.pbBox4.Tag = "Empty";
            this.pbBox4.Click += new System.EventHandler(this.pbBox4_Click);
            // 
            // pbBox5
            // 
            this.pbBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox5.Location = new System.Drawing.Point(578, 237);
            this.pbBox5.Name = "pbBox5";
            this.pbBox5.Size = new System.Drawing.Size(100, 86);
            this.pbBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox5.TabIndex = 10;
            this.pbBox5.TabStop = false;
            this.pbBox5.Tag = "Empty";
            this.pbBox5.Click += new System.EventHandler(this.pbBox5_Click);
            // 
            // pbBox6
            // 
            this.pbBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox6.Location = new System.Drawing.Point(763, 237);
            this.pbBox6.Name = "pbBox6";
            this.pbBox6.Size = new System.Drawing.Size(100, 86);
            this.pbBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox6.TabIndex = 11;
            this.pbBox6.TabStop = false;
            this.pbBox6.Tag = "Empty";
            this.pbBox6.Click += new System.EventHandler(this.pbBox6_Click);
            // 
            // pbBox7
            // 
            this.pbBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox7.Location = new System.Drawing.Point(392, 379);
            this.pbBox7.Name = "pbBox7";
            this.pbBox7.Size = new System.Drawing.Size(100, 86);
            this.pbBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox7.TabIndex = 12;
            this.pbBox7.TabStop = false;
            this.pbBox7.Tag = "Empty";
            this.pbBox7.Click += new System.EventHandler(this.pbBox7_Click);
            // 
            // pbBox8
            // 
            this.pbBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox8.Location = new System.Drawing.Point(578, 379);
            this.pbBox8.Name = "pbBox8";
            this.pbBox8.Size = new System.Drawing.Size(100, 86);
            this.pbBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox8.TabIndex = 13;
            this.pbBox8.TabStop = false;
            this.pbBox8.Tag = "Empty";
            this.pbBox8.Click += new System.EventHandler(this.pbBox8_Click);
            // 
            // pbBox9
            // 
            this.pbBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBox9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.QuestionMark;
            this.pbBox9.Location = new System.Drawing.Point(763, 379);
            this.pbBox9.Name = "pbBox9";
            this.pbBox9.Size = new System.Drawing.Size(100, 86);
            this.pbBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBox9.TabIndex = 14;
            this.pbBox9.TabStop = false;
            this.pbBox9.Tag = "Empty";
            this.pbBox9.Click += new System.EventHandler(this.pbBox9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(929, 477);
            this.Controls.Add(this.pbBox9);
            this.Controls.Add(this.pbBox8);
            this.Controls.Add(this.pbBox7);
            this.Controls.Add(this.pbBox6);
            this.Controls.Add(this.pbBox5);
            this.Controls.Add(this.pbBox4);
            this.Controls.Add(this.pbBox3);
            this.Controls.Add(this.pbBox2);
            this.Controls.Add(this.pbBox1);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox pbBox1;
        private System.Windows.Forms.PictureBox pbBox2;
        private System.Windows.Forms.PictureBox pbBox3;
        private System.Windows.Forms.PictureBox pbBox4;
        private System.Windows.Forms.PictureBox pbBox5;
        private System.Windows.Forms.PictureBox pbBox6;
        private System.Windows.Forms.PictureBox pbBox7;
        private System.Windows.Forms.PictureBox pbBox8;
        private System.Windows.Forms.PictureBox pbBox9;
    }
}

