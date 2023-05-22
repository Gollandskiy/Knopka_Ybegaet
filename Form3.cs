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
    public partial class Form3 : Form
    {
        private static bool isClick = false;
        private static int amountBtn = 0;

        private Point startPoint;
        private Button b;

        public Form3()
        {
            InitializeComponent();
            this.Text = "KNOPKA DELAETSA";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateButton()
        {
            b = new Button();
            b.Text = "button_" + (++amountBtn);
            this.Controls.Add(b);
        }

        private bool CheckBtnSize()
        {
            return b.Width >= 25 && b.Height >= 25;
        }

        private void Form3_MouseUp_1(object sender, MouseEventArgs e)
        {
            isClick = false;

            if (!CheckBtnSize())
            {
                MessageBox.Show("KNOPKA SDELALAS", "KNOPKA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Controls.Remove(b);
                amountBtn--;
            }
        }

        private void Form3_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                if (e.X < startPoint.X)
                {
                    if (e.Y < startPoint.Y)
                    {
                        b.Location = new Point(startPoint.X - b.Width, startPoint.Y - b.Height);
                        b.Size = new Size(startPoint.X - e.X, startPoint.Y - e.Y);
                    }

                    else
                    {
                        b.Location = new Point(startPoint.X - b.Width, startPoint.Y);
                        b.Size = new Size(startPoint.X - e.X, e.Y - startPoint.Y);
                    }
                }

                else
                {
                    if (e.Y < startPoint.Y)
                    {
                        b.Location = new Point(startPoint.X, startPoint.Y - b.Height);
                        b.Size = new Size(e.X - startPoint.X, startPoint.Y - e.Y);
                    }

                    else
                    {
                        b.Location = new Point(startPoint.X, startPoint.Y);
                        b.Size = new Size(e.X - startPoint.X, e.Y - startPoint.Y);
                    }
                }
            }
        }

        private void Form3_MouseDown_1(object sender, MouseEventArgs e)
        {
            isClick = true;
            startPoint = new Point(e.X, e.Y);

            CreateButton();
        }
    }
    }
