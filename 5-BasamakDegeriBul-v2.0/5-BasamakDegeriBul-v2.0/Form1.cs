using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_BasamakDegeriBul_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string sayi = textBox1.Text;
            char[] dizi = sayi.ToCharArray();
            int toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam = toplam + (int)dizi[i];
                listBox1.Items.Add(dizi[i]);
            }
            MessageBox.Show("Basamak Toplamları = "+Convert.ToString(toplam),"Basamak Toplamları");
        }
    }
}
