using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_windowsowy
{
    public partial class Form1 : Form
    {
        Double results = 0;
        string operation = "";
        bool enter_value = false;
        float iCelsius, iFahrenheit, iKelvin;
        char iOperation;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 260;
            textBox1.Width = 205;
        }

        private void standardowyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Width = 260;
            textBox1.Width = 205;
        }

        private void naukowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 490;
            textBox1.Width = 435;
        }

        private void konwersjaTemperaturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 790;
            textBox1.Width = 435;
        }

        private void tabliczkaMnożeniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 790;
            textBox1.Width = 435;
        }

        private void zamianaJednostekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 790;
            textBox1.Width = 435;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;

            }
            else
                textBox1.Text = textBox1.Text + num.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblshowOp.Text = "";
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            lblshowOp.Text = "";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);
            if (textBox1.Text == "")
                textBox1.Text = "0"; 
        }

        private void Arytmetyczne(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = float.Parse(textBox1.Text);
            textBox1.Text = "";
            lblshowOp.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblshowOp.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (results + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "mod":
                    textBox1.Text = (results % Double.Parse(textBox1.Text)).ToString();
                    break;
                case "exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14519265358997";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("sqrt" + "(" + (textBox1.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("Sinh" + "(" + (textBox1.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = System.Convert.ToString(qSinh);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("Sin" + "(" + (textBox1.Text) + ")");
            qSin = Math.Sin(qSin);
            textBox1.Text = System.Convert.ToString(qSin);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("Cosh" + "(" + (textBox1.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            textBox1.Text = System.Convert.ToString(qCosh);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("Cos" + "(" + (textBox1.Text) + ")");
            qCos= Math.Cos(qCos);
            textBox1.Text = System.Convert.ToString(qCos);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("Tanh" + "(" + (textBox1.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            textBox1.Text = System.Convert.ToString(qTanh);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("Tan" + "(" + (textBox1.Text) + ")");
            qTan = Math.Tan(qTan);
            textBox1.Text = System.Convert.ToString(qTan);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0/ Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            lblshowOp.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "0";
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Double a;
            a =Convert.ToDouble(textBox1.Text)/Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            switch(iOperation)
            {
                case 'C':
                    iCelsius = float.Parse(textBox2.Text);
                   textBox3.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFahrenheit = float.Parse(textBox2.Text);
                    textBox3.Text = ((((iFahrenheit-32) * 5) / 9).ToString());
                    break;
                case 'K':
                    iKelvin = float.Parse(textBox2.Text);
                    textBox3.Text = (((((9 * iKelvin) / 5) + 32)+273.15).ToString());
                    break;
            }
        }
    }
}
