using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;


namespace WarPlaneGame
{
    public partial class Form1 : Form
    {
        public Sounds sounds;

//Public constructor
        public Form1()
        {
            InitializeComponent();    
            sounds = new Sounds();
            sounds.playIntro();
        }

        private void NewGameClicked(object sender, EventArgs e)
        {
            GameWindow game = new GameWindow();
            game.ShowDialog();
            game.freezScreen();
            sounds.playIntro();
       }

        private void HowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlayForm how = new HowToPlayForm();
            how.ShowDialog();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HowToPlay_MouseHover(object sender, EventArgs e)
        {
            HowToPlay.BackColor = Color.Black;
            HowToPlay.ForeColor = Color.White;
          

        }

        private void HowToPlay_MouseLeave(object sender, EventArgs e)
        {
            HowToPlay.BackColor = Color.White;
            HowToPlay.ForeColor = Color.Black;
        }

        private void NewGame_MouseEnter(object sender, EventArgs e)
        {
            NewGame.BackColor = Color.Black;
            NewGame.ForeColor = Color.White;
          
        }

        private void NewGame_MouseLeave(object sender, EventArgs e)
        {
            NewGame.BackColor = Color.White;
            NewGame.ForeColor = Color.Black;
        }

        private void Quit_MouseEnter(object sender, EventArgs e)
        {
            Quit.BackColor = Color.Black;
            Quit.ForeColor = Color.White;
        }

        private void Quit_MouseLeave(object sender, EventArgs e)
        {
            Quit.BackColor = Color.White;
            Quit.ForeColor = Color.Black;
        }


    }
}