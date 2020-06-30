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
    public partial class Puzzle : Form
    {
        public Puzzle()
        {
            InitializeComponent();
            InitializePuzzleArea();
            InitializeButtons();
        }

        public void InitializePuzzleArea()
        {
            this.BackColor = Color.LightCoral;
            this.Text = "Puzzle15";
            
        }

        private void InitializeButtons()
        {
            Button button;
            for(int i = 1; i < 16; i++)
            {
                button = new Button();
                this.Controls.Add(button);
            }
        }
    }
}
