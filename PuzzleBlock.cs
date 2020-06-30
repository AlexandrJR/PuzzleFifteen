using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleFifteen
{
    class PuzzleBlock : Button //Inheritance

    {
        public PuzzleBlock()
        {
            InitializePuzzleBlock();
        }

        private void InitializePuzzleBlock()
        {
            this.BackColor = Color.Coral;
            this.Height = 80;
            this.Width = 80;
            this.Text = "0";
            this.Font = new Font("Tahoma", 17);
        }
    }
}
