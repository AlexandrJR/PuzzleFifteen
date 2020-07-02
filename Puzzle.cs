using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleFifteen
{
    public partial class PuzzleArea : Form
    {

        Random rand = new Random();
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
            InitializeBlocks();
            ShuffleButton();
        }

        public void InitializePuzzleArea()
        {
            this.BackColor = Color.LightCoral;
            this.Text = "Puzzle15";
            this.ClientSize = new Size(560,560);

            
        }

        private void InitializeBlocks()
        {
            int blockCount = 1;
            PuzzleBlock block;
            for (int row = 1; row < 5; row++)
            {
                for (int col = 1; col < 5; col++)
                {
                    block = new PuzzleBlock()
                    {
                        Top = row * 84,
                        Left = col * 84,
                        Text = blockCount.ToString(),
                        Name = "Block" + blockCount.ToString()
                    };

                    block.Click += Block_Click;

                    if (blockCount == 16)
                    {
                        block.Name = "EmptyBlock";
                        block.Text = string.Empty;
                        block.BackColor = Color.LightCoral;
                    }
                    blockCount++;
                    this.Controls.Add(block);
                }
            }
        }

        private void Block_Click(object sender, EventArgs e)
        {
            Button block = (Button)sender;
            if (IsAdjacent(block))
            {
                SwapBlocks(block);
            }            
        }

        private void SwapBlocks(Button block)
        {
            Button emptyBlock = (Button)this.Controls["EmptyBlock"];
            Point oldLocation = block.Location;
            block.Location = emptyBlock.Location;
            emptyBlock.Location = oldLocation;
        }

        private bool IsAdjacent(Button block)
        {
            double a;
            double b;
            double c;
            Button emptyBlock = (Button)this.Controls["EmptyBlock"];

            a = Math.Abs(emptyBlock.Top - block.Top);
            b = Math.Abs(emptyBlock.Left - block.Left);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            if(c < 85)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void ShuffleButton()
        {
            Button swapButton = new Button()
            {
                Top = 25,
                Left = 84,
                Size = new Size(150, 50),
                Text = "Shuffle",
                Font = new Font("Tahoma", 18),
                BackColor = Color.Coral
            };

            this.Controls.Add(swapButton);
            swapButton.Click += ShuffleButton_Click;
        }

        private void ShuffleButton_Click(object sender, EventArgs e)
        {
            string blockName;
            for (int i = 0; i < 100; i++)
            {
                blockName = "Block" + rand.Next(1, 16);
                Button block = (Button)this.Controls[blockName];
                SwapBlocks(block);
            }
        }
    }
}
