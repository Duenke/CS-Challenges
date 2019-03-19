using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thermometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ChangeTemp(object sender, ScrollEventArgs e)
        {
            int degF = vScrollBar1.Maximum - vScrollBar1.Value;
            double degC = (5.0 / 9.0) * (degF - 32.0);
            label3.Text = degF.ToString();
            label4.Text = Convert.ToInt16(degC).ToString();
        }
    }
}
