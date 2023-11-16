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
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            Form2 f = new Form2(this);
            form2 = f;
        }
        currency rub = new currency("RUB", 1.0);
        currency cny = new currency("CNY", 11.81);
        currency mdl = new currency("MDL", 4.53);
        money a = new money();
        private void Form1_Load(object sender, EventArgs e)
        {

            
            form2.Show();
            comboBox1.Items.Add(rub.seeName());
            comboBox1.Items.Add(cny.seeName());
            comboBox1.Items.Add(mdl.seeName());
            comboBox1.Text = "RUB";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == rub.seeName()) textBox1.Text = rub.seeMoney(a.showM()).ToString();
            if (comboBox1.Text == cny.seeName()) textBox1.Text = cny.seeMoney(a.showM()).ToString();
            if (comboBox1.Text == mdl.seeName()) textBox1.Text = mdl.seeMoney(a.showM()).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this,form2,1,2);
            form3.Show();
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
        
    }
}
//11.81
//4.53