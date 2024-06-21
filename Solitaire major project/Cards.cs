using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire_major_project
{
    internal class Cards
    {
        public int suits { get; set; }
        public int cardvalue { get; set; }
        public List<Cards> cards { get; set; }

        static Cards()
        {
            List<Cards> cards = new List<Cards>(52);

        }

    }
}
