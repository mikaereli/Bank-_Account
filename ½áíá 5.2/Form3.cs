using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба_5._2
{
    public partial class Form3 : Form
    {
        Form1 form1;
        Form2 form2;
        int from, to;
        public Form3(Form1 a,Form2 b, int frm, int too)
        {
            InitializeComponent();
            form1 = a;
            form2 = b;
            label3.Text = frm.ToString();
            label4.Text = too.ToString();
            from = frm;
            to = too;   
        }
        currency rub = new currency("RUB", 1.0);
        currency cny = new currency("CNY", 11.81);
        currency mdl = new currency("MDL", 4.53);
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(rub.seeName());
            comboBox1.Items.Add(cny.seeName());
            comboBox1.Items.Add(mdl.seeName());
            comboBox1.Text = "RUB";
        }
        double a;
        private void ch()
        {
            if (from == 1)
            {
                if (comboBox1.Text != form1.getv() && textBox1.Text != "" && textBox1.Text[textBox1.Text.Length - 1] != '.')
                {
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.01).ToString();
                }
                else textBox2.Text = "0";
                if (comboBox1.Text != form2.getv() && textBox1.Text != "")
                {
                    textBox3.Text = (double.Parse(textBox1.Text) * 0.01).ToString();
                }
                else textBox3.Text = "0";
            }
            else
            {
                if (comboBox1.Text != form2.getv() && textBox1.Text != "" && textBox1.Text[textBox1.Text.Length - 1] != '.')
                {
                    textBox2.Text = (double.Parse(textBox1.Text) * 0.01).ToString();
                }
                else textBox2.Text = "0";
                if (comboBox1.Text != form1.getv()  && textBox1.Text != "")
                {
                    textBox3.Text = (double.Parse(textBox1.Text) * 0.01).ToString();
                }
                else textBox3.Text = "0";
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == rub.seeName()) textBox1.Text = a.ToString();
            if (comboBox1.Text == cny.seeName()) textBox1.Text = (a/cny.cor()).ToString();
            if (comboBox1.Text == mdl.seeName()) textBox1.Text = (a / mdl.cor()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ch();
            button1.Visible = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           // textBox1.Enabled = false;
            //ch();
            string f = textBox1.Text;
            for (int i = 0; i < f.Length; i++) if (f[i] > '9' || f[i] < '0' || f[i] != '.') f.Substring(i, 1);
            a = double.Parse(f);
            if (comboBox1.Text == cny.seeName()) a *= cny.cor();
            if (comboBox1.Text == mdl.seeName()) a *= mdl.cor();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b, c;
            b = double.Parse(textBox2.Text);
            if (comboBox1.Text == cny.seeName()) b *= cny.cor();
            if (comboBox1.Text == mdl.seeName()) b *= mdl.cor();
            c = double.Parse(textBox3.Text);
            if (comboBox1.Text == cny.seeName()) c *= cny.cor();
            if (comboBox1.Text == mdl.seeName()) c *= mdl.cor();
            if (from == 1)
            {
                if (form1.getM() >= a + b) { form1.change(-(a + b)); form2.change(a - c); }
                else MessageBox.Show("Not enoungh money");
            }
            else
            {
                if (form2.getM() >= a + b) { form2.change(-(a + b)); form1.change(a - c); }
                else MessageBox.Show("Not enoungh money");
            }
        }
    }
}
