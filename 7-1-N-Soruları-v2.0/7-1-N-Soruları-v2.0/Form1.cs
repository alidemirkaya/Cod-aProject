﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_1_N_Soruları_v2._0
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
            if (int.Parse(textBox1.Text) >= int.Parse(textBox2.Text))
            {
                MessageBox.Show("Başlangıç Sayısı Bitiş Sayısından Büyük Olamaz", "Uyarı");
            }
            else
            {

                int sayi1 = int.Parse(textBox1.Text);
                int sayi2 = int.Parse(textBox2.Text);
                if (radioButton1.Checked == true)
                {
                    for (int i = sayi1; i < sayi2; i++)
                    {
                        if ((i % 2)!=0) { listBox1.Items.Add(i); }                        
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    for (int i = sayi1; i < sayi2; i++)
                    {
                        if ((i % 2) == 0) { listBox1.Items.Add(i); }
                    }
                }
            }
        }
    }
}
