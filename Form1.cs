using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Tyre_Program
{
    public partial class Form1 : Form
    {
        private Tyre tyre = new Tyre();
        private Fitting fitting = new Fitting();

        public Form1()
        {
            InitializeComponent();
            label6.Text = "Tyre Type: " + tyre.TireType;
            label7.Text = "Number in Stock: " + tyre.Stock;
            label8.Text = "Price of Tyre: £" + tyre.Price;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fitting.CarRegistration = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fitting.NumOfTyres = int.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            fitting.FittingDate = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cost = fitting.NumOfTyres * tyre.Price;
            label5.Text = "The cost is " + cost;
            tyre.Stock = tyre.Stock - fitting.NumOfTyres;
            label7.Text = "Number in Stock: " + tyre.Stock;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tyre.Stock++;
            label7.Text = "Number in Stock: " + tyre.Stock;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
