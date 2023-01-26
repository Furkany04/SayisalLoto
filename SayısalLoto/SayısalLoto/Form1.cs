using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int a,b,c,d,e,f;
        int sayi1,sayi2,sayi3,sayi4,sayi5,sayi6;
        int bil = 0;
        void sayısalloto()
        {
            a = rastgele.Next(1, 100);
            b = rastgele.Next(1, 100);
            c = rastgele.Next(1, 100);
            d = rastgele.Next(1, 100);
            e= rastgele.Next(1, 100);
            f= rastgele.Next(1, 100);
           
        }
        void kontrol(int sayi1,int sayi2,int sayi3,int sayi4,int sayi5,int sayi6)
        {
            int para = 0;
            
            if(a == sayi1 || a == sayi2 ||a == sayi3 ||a == sayi4 || a == sayi5 ||a == sayi6)
            {
                bil++;
            }
            if (b == sayi2 || b == sayi1 || b == sayi3 || b == sayi4 || b == sayi5 || b == sayi6)
            {
                bil++;
            }
            if (c == sayi3 || c == sayi2 || c == sayi1 || c == sayi4 || c == sayi5 || c == sayi6)
            {
                bil++;
            }
            if (d == sayi4 || d == sayi2 || d == sayi3 || d == sayi1 || d == sayi5 || d == sayi6)
            {
                bil++;
            }
            if (e == sayi5 || e == sayi2 || e == sayi3 || e == sayi4 || e == sayi1 || e == sayi6)
            {
                bil++;
            }
            if (f == sayi6 || f == sayi2 || f == sayi3 || f == sayi4 || f == sayi5 || f == sayi1)
            {
                bil++;
            }
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            label3.Text = c.ToString();
            label4.Text = d.ToString();
            label5.Text = e.ToString();
            label6.Text = f.ToString();
            if (comboBox1.SelectedIndex == 0)
            {
                para = bil * 10;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                para = bil * 20;
            }
            else
                para = bil * 50;

            sonuclbl.Text = bil.ToString()  + "  tane bildiniz \n şu kadar kazandınız :" + para + "tl";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            sayi1 = int.Parse(textBox1.Text);
            sayi2 = int.Parse(textBox2.Text);
            sayi3 = int.Parse(textBox3.Text);
            sayi4 = int.Parse(textBox4.Text);
            sayi5 = int.Parse(textBox5.Text);
            sayi6 = int.Parse(textBox6.Text);
            textBox1.ReadOnly= true;
            textBox2.ReadOnly= true;
            textBox3.ReadOnly= true;
            textBox4.ReadOnly= true;
            textBox5.ReadOnly= true;
            textBox6.ReadOnly= true;
            sayısalloto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol(sayi1, sayi2, sayi3, sayi4, sayi5, sayi6);
            
        }
    }
}
