using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solitaire_major_project
{
    public partial class SolitaireGame : Form
    {
        List<Card> CardsOnScreen = new List<Card>();
        public SolitaireGame()
        {
            InitializeComponent();
        }
        

        private void SolitaireGame_Load(object sender, EventArgs e)
        {
            
            //pictureBox1.Image = Properties.Resources.ace_of_spades;
            //pictureBox1.Width = 160;
            //pictureBox1.Height = 220;
            //pictureBox1.Location = new Point(46, 53);
            deck deck = new deck();
            for (int i = 0; i < 10; i++)
            {
                Card c = deck.Draw();
                c.SetImage();
                c.Width = 160;
                c.Height = 220;
                c.Location = new Point(20*i, 53);
                c.Parent = this;

            }


        }
               
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pictureBox1.Left += e.X-80;
                pictureBox1.Top += e.Y-110;
                
            }
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Left += e.X-80;
                pictureBox1.Top += e.Y-110;

            }
        }
        
    }
}
