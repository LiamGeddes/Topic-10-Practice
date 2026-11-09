using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10_Practice
{
    public partial class Form1 : Form
    {
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void imgMario_Click(object sender, EventArgs e)
        {
            int number = generator.Next(5);

            if (number == 0)
            {
                imgMario.Image = Properties.Resources.MarioMad;
            }
            else
            {
                imgMario.Image = Properties.Resources.MarioAwake;
            }
        }

        private void imgMarioSleep_Click(object sender, EventArgs e)
        {
            imgMario.Image = Properties.Resources.MarioAsleep;
        }

        private void imgMario_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void imgMario_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
