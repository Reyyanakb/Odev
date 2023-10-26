using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel(adTxt.Text, adresTxt.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text),comboBox1.Text);
           if (comboBox1.Text =="işçi")
            {
                MessageBox.Show(pers.ucretHesapla().ToString());
            }
            else
            {
                pers.ucretHesapla(1000);
            }
            comboBox1.Items.Add("işçi");
            comboBox1.Items.Add("mühendis");





            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
