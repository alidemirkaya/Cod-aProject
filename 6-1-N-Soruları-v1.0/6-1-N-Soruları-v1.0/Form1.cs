using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_1_N_Soruları_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.Parse(textBox1.Text) >= int.Parse(textBox2.Text))
            {
                MessageBox.Show("Başlangıç Sayısı Bitiş Sayısından Büyük Olamaz", "Uyarı");
            }
            else
            {
                int sayi1 = int.Parse(textBox1.Text);
                int sayi2 = int.Parse(textBox2.Text);
                for(int i = sayi1; i < sayi2; i++)
                {
                    listBox1.Items.Add(i);
                }
            }

        }
    }
}
