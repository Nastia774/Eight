using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8._4_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            return textBox1_TextChanged() % textBox2_TextChanged();
        }

        double textBox2_TextChanged(object sender, EventArgs e)
        {
            return double.Parse(sender);
        }

        double textBox1_TextChanged(object sender, EventArgs e)
        {

            return double.Parse(sender);
        }
    }
}
