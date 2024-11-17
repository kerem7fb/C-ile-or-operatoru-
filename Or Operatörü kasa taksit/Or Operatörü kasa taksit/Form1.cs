using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Or_Operatörü_kasa_taksit
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(textBox1.Text);
            if (radioButton2.Checked == true || radioButton3.Checked == true) 
            {
                tutar = tutar + (tutar * 0.05);
            }
            if (radioButton4.Checked == true || radioButton5.Checked == true) 
            {
                tutar = tutar + (tutar * 0.10);
            }
            MessageBox.Show("Ödenecek Toplam Tutar " + tutar.ToString() + "TL'dir");
        }
    }
}
