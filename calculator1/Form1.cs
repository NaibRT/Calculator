using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator1
{
    public partial class Form1 : Form
    {
       
        List<decimal> Operands = new List<decimal>();
        public string operatore { get; set; }
        public static decimal sum = 1;

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "1";
        }

        private void button20_Click(object sender, EventArgs e)
        {

            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            operatore = button20.Text;
            showRichbox.Text = "";
            //Divide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showRichbox.Text += "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            showRichbox.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showRichbox.Text="";
            operatore = null;
            Operands.Clear();
            sum = 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            operatore = button19.Text;
            showRichbox.Text = "";
            //Multiplication();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (operatore == button19.Text)
            {
                Multiplication();
            }
            else if (operatore == button20.Text)
            {
                Divide();
            }
            else if (operatore == button17.Text)
            {
                Adding();
            }
            else if (operatore == button18.Text)
            {
                Subtraction();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            operatore = button17.Text;
            showRichbox.Text = "";
            //Adding();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            operatore = button18.Text;
            showRichbox.Text = "";
            //Subtraction();
        }
        public void Multiplication()
        {
            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            for (int i = 0; i < Operands.Count; i++)
            {
                sum *= Operands[i];
            }
            Operands.Clear();
            var result = sum.ToString();
            showRichbox.Text = result;
            sum = 1;
        }
        public void Divide()
        {
            sum = Operands[0];
            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            for (int i = 1; i < Operands.Count; i++)
            {
                sum /= Operands[i];
            }
            Operands.Clear();
            var result = sum.ToString();
            showRichbox.Text = result;
            sum = 1;
        }
        public void Adding()
        {
            sum = 0;
            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            for (int i = 0; i < Operands.Count; i++)
            {
                sum += Operands[i];
            }
            Operands.Clear();
            var result = sum.ToString();
            showRichbox.Text = result;
            sum = 1;
        }
        public void Subtraction()
        {
            sum = Operands[0];
            Operands.Add(Convert.ToDecimal(showRichbox.Text));
            for (int i = 1; i < Operands.Count; i++)
            {
                sum -= Operands[i];
            }
            Operands.Clear();
            var result = sum.ToString();
            showRichbox.Text = result;
            sum = 1;
        }

    }
}
