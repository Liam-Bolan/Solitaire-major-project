using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solitaire_major_project
{
    public partial class SolitaireGame : Form
    {
        public SolitaireGame()
        {
            InitializeComponent();
        }

        private void SolitaireGame_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Image = Properties.Resources.ace_of_spades;
            pictureBox1.Width = 160;
            pictureBox1.Height = 220;
            pictureBox1.Location = new Point(25, 25);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
