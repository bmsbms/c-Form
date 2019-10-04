using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat_01_from
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
           // button1.BackColor = colorDialog1.Color;
            BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(textBox1.Text);
                int input2 = Convert.ToInt32(textBox2.Text);


                int eredmeny = input1 + input2;

                MessageBox.Show("a ket szam összege: "+eredmeny.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Rossz adatot adtál meg :( \n \n"+ex);
            }
        }
    }
}
