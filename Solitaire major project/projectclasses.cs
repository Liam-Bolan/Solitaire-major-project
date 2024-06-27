using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Solitaire_major_project
{
    public enum suits
    {
        hearts, diamonds,spades,clubs
    }
    class Card : PictureBox
    {
        private string[] names = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private string[] suits = { "hearts", "diamonds", "spades", "clubs" };
        public int value { get; set; }
        public suits suit { get; set; }

        public string name()
        {
            return names[value - 1];
        }

        public void SetImage()
        {
            string imagefile = "../../resources/" + names[value - 1] + "_of_" + suits[(int)suit] + ".png";
            Image = Image.FromFile(imagefile);
            MouseMove += new MouseEventHandler(Card_MouseDown);
            SizeMode = PictureBoxSizeMode.Zoom;
        }

        
        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - 80;
                Top += e.Y - 110;

            }

        }

    }

    class deck
    {
        private Card[] cards = new Card[52];
        private int pos = 0;

        public deck()
        {
            for (int s = 0; s < 4; s++)
            {
                for (int v = 0; v < 13; v++)
                {
                    Card c = new Card();
                    c.value = v+1;
                    c.suit = (suits)s;
                    cards[s * 13 + v] = c;
                }
            }
        }

        public Card Draw()
        {
            pos++;
            return cards[pos - 1];
        }

    }

}
