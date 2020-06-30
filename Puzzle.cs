using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleFifteen
{
    public partial class PuzzleArea : Form
    {
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
            InitializeBlocks();
        }

        public void InitializePuzzleArea()
        {
            this.BackColor = Color.LightCoral;
            this.Text = "Puzzle15";
            this.ClientSize = new Size(570,570) ;
        }

        private void InitializeBlocks()
        {
            int blockCount = 0;
            PuzzleBlock block;
            for(int row = 1; row <= 4; row++)
            {
                for (int col = 1; col <= 4; col++)
                {
                    block = new PuzzleBlock();

                    block.Top = row * 90;
                    block.Left = col * 90;

                    blockCount++;
                    block.Text = blockCount.ToString();

                    this.Controls.Add(block);
                }
            }
        }
    }
}
