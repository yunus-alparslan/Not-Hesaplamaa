using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1, not2, ortalama,topla;

            not1 = Convert.ToInt16(textBox1.Text);
            not2 = Convert.ToInt16(textBox2.Text);

            topla = not1 + not2;

            ortalama = topla / 2;

            label2.Text = ortalama.ToString();

            

        }

  


    }
}
