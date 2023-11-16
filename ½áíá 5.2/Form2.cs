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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }
        currency rub = new currency("RUB", 1.0);
        currency cny = new currency("CNY", 11.81);
        currency mdl = new currency("MDL", 4.53);
        money a = new money();
        bool f = true;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(rub.seeName());
            comboBox1.Items.Add(cny.seeName());
            comboBox1.Items.Add(mdl.seeName());
            comboBox1.Text = "RUB";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (f) { textBox1.Text = a.showM().ToString(); f = false; return; }
            if (comboBox1.Text == rub.seeName()) textBox1.Text = rub.seeMoney(a.showM()).ToString();
            if (comboBox1.Text == cny.seeName()) textBox1.Text = cny.seeMoney(a.showM()).ToString();
            if (comboBox1.Text == mdl.seeName()) textBox1.Text = mdl.seeMoney(a.showM()).ToString();
        }
        public void change(double d)
        {
            a.upd(d);
            if (comboBox1.Text == rub.seeName()) textBox1.Text = rub.seeMoney(a.showM()).ToString();
            if (comboBox1.Text == cny.seeName()) textBox1.Text = cny.seeMoney(a.showM()).ToString();
            if (comboBox1.Text == mdl.seeName()) textBox1.Text = mdl.seeMoney(a.showM()).ToString();

        }
        public string getv()
        {
            return a.showV();
        }
        public double getM()
        {
            return a.showM();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(form1,this,2,1);
            form3.Show();
        }
    }
}
