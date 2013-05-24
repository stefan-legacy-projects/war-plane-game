namespace WarPlaneGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.HowToPlay = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(929, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 29);
            this.ScoreLabel.TabIndex = 0;
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(12, 134);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(226, 57);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGameClicked);
            this.NewGame.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.NewGame.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            // 
            // HowToPlay
            // 
            this.HowToPlay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HowToPlay.Location = new System.Drawing.Point(12, 215);
            this.HowToPlay.Name = "HowToPlay";
            this.HowToPlay.Size = new System.Drawing.Size(226, 57);
            this.HowToPlay.TabIndex = 2;
            this.HowToPlay.Text = "How to Play";
            this.HowToPlay.UseVisualStyleBackColor = true;
            this.HowToPlay.Click += new System.EventHandler(this.HowToPlay_Click);
            this.HowToPlay.MouseEnter += new System.EventHandler(this.HowToPlay_MouseHover);
            this.HowToPlay.MouseLeave += new System.EventHandler(this.HowToPlay_MouseLeave);
            // 
            // Quit
            // 
            this.Quit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit.Location = new System.Drawing.Point(12, 300);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(226, 57);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit ";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            this.Quit.MouseEnter += new System.EventHandler(this.Quit_MouseEnter);
            this.Quit.MouseLeave += new System.EventHandler(this.Quit_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarPlaneGame.Properties.Resources.Intro;
            this.ClientSize = new System.Drawing.Size(639, 481);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.HowToPlay);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.ScoreLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "War Plane Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button HowToPlay;
        private System.Windows.Forms.Button Quit;


    }
}

