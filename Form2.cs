using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knopka_Ybegaet
{
    public partial class Form2 : Form
    {
        Random rand = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        public void button3_MouseEnter(object sender, EventArgs e)
        {
            RandLocation();
        }
        void RandLocation()
        {
            int MaxX = ClientSize.Width - button3.Width;
            int MaxY = ClientSize.Height - button3.Height;

            int x = rand.Next(MaxX);
            int y = rand.Next(MaxY);

            button3.Location = new Point(x, y);
        }
    }
}
