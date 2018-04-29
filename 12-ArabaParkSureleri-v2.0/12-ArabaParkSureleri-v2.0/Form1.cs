using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_ArabaParkSureleri_v2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void islemyap()
        {
            int t_ucret = 0;
            int t_sure = 0;
            int aracsayisi=listView1.Items.Count;
            for(int i = 0; i < aracsayisi; i++)
            {
                t_ucret = t_ucret +int.Parse(listView1.Items[i].SubItems[2].Text);
                t_sure = t_sure+ int.Parse(listView1.Items[i].SubItems[1].Text);
            }
            textBox3.Text = Convert.ToString(aracsayisi);
            textBox4.Text = Convert.ToString(t_ucret);
            // ORtalama Ücret
            double ort_ucret = t_ucret / aracsayisi;
            textBox5.Text = Convert.ToString(ort_ucret);
            // Ortalama Süre
            double ort_sure = t_sure / aracsayisi;          
            textBox6.Text = Convert.ToString(ort_sure);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string model = textBox1.Text;
            int sure =int.Parse(textBox2.Text);
            int ucreti = 0;
            if (sure <= 3)
            {
                ucreti = 8;
            }
            else if (sure > 3 && sure <= 24)
            {
                ucreti = 8 + (sure - 3) * 2;
            }
            else if (sure > 24)
            {
                ucreti = 75;
            }
            string[] dizi = { model, Convert.ToString(sure), Convert.ToString(ucreti) };
            listView1.Items.Add(new ListViewItem(dizi));
            // İslem Yap fonksiyonunu çağırıyoruz
            islemyap();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
