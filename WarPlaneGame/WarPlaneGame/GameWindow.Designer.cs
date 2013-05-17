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
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Start);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.ScoreLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.ScoreLabel.Location = new System.Drawing.Point(9, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(52, 18);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score";
            // 
            // RemainingLifes
            // 
            this.RemainingLifes.AutoSize = true;
            this.RemainingLifes.BackColor = System.Drawing.Color.Gainsboro;
            this.RemainingLifes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLifes.ForeColor = System.Drawing.Color.Black;
            this.RemainingLifes.Location = new System.Drawing.Point(9, 27);
            this.RemainingLifes.Name = "RemainingLifes";
            this.RemainingLifes.Size = new System.Drawing.Size(43, 18);
            this.RemainingLifes.TabIndex = 1;
            this.RemainingLifes.Text = "lifes";
            // 
            // PlayerTime
            // 
            this.PlayerTime.Enabled = true;
            this.PlayerTime.Tick += new System.EventHandler(this.CountTime);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.RemainingLifes);
            this.Controls.Add(this.ScoreLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWindow";
            this.Text = "War Plane Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovePlayerPlane);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FireRocket);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label RemainingLifes;
        private System.Windows.Forms.Timer PlayerTime;


    }
}