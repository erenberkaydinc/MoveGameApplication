using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HareketEttirmeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y - 10);
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 10);
            button1.BackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X+10, button1.Location.Y);
            button1.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X-10, button1.Location.Y);
            button1.BackColor = Color.Green;
        }
    }
}
