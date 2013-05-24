namespace WarPlaneGame
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.RemainingLifes = new System.Windows.Forms.Label();
            this.PlayerTime = new System.Windows.Forms.Timer(this.components);
            this.TimerLabel = new System.Windows.Forms.Label();
            this.BosRocketTimer = new System.Windows.Forms.Timer(this.components);
            this.BosLife = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 40;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Start);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Black;
            this.ScoreLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(0, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(58, 18);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score";
            // 
            // RemainingLifes
            // 
            this.RemainingLifes.AutoSize = true;
            this.RemainingLifes.BackColor = System.Drawing.Color.Black;
            this.RemainingLifes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLifes.ForeColor = System.Drawing.Color.White;
            this.RemainingLifes.Location = new System.Drawing.Point(0, 18);
            this.RemainingLifes.Name = "RemainingLifes";
            this.RemainingLifes.Size = new System.Drawing.Size(43, 18);
            this.RemainingLifes.TabIndex = 1;
            this.RemainingLifes.Text = "lifes";
            // 
            // PlayerTime
            // 
            this.PlayerTime.Enabled = true;
            this.PlayerTime.Interval = 1000;
            this.PlayerTime.Tick += new System.EventHandler(this.UpdateTimeSpent);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.Color.Black;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimerLabel.ForeColor = System.Drawing.Color.White;
            this.TimerLabel.Location = new System.Drawing.Point(470, 0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(0, 20);
            this.TimerLabel.TabIndex = 2;
            // 
            // BosRocketTimer
            // 
            this.BosRocketTimer.Interval = 1500;
            this.BosRocketTimer.Tick += new System.EventHandler(this.BossFireRocket);
            // 
            // BosLife
            // 
            this.BosLife.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BosLife.Location = new System.Drawing.Point(526, 4);
            this.BosLife.Maximum = 20;
            this.BosLife.Name = "BosLife";
            this.BosLife.Size = new System.Drawing.Size(470, 14);
            this.BosLife.TabIndex = 3;
            this.BosLife.Visible = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BosLife);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.RemainingLifes);
            this.Controls.Add(this.ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameWindow";
            this.Text = "War Plane Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovePlayerPlane);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FireRocket);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label RemainingLifes;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.ProgressBar BosLife;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer PlayerTime;
        private System.Windows.Forms.Timer BosRocketTimer;


    }
}