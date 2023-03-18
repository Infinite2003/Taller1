using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbcarga.Increment(1);
            lblpor.Text = Convert.ToString(pbcarga.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pbcarga.Value = 0;
            lblpor.Text = "0%";
        }
    }
}
