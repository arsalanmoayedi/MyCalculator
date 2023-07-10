using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator1
{
    public partial class Form1 : Form
    {
        ICalcurator calculator;
        

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
            
        }

      bool ValidateInput()
        {
            bool isvalid = true;
            if (txtbox1.Text=="0")
            {
                isvalid = false;
                MessageBox.Show("عدد اول را وارد کنید");
            }
            else
            {
                if (txtbox2.Text=="0")
                {
                    isvalid = false;
                    MessageBox.Show("عدد دوم را وارد کنید");
                }
            }
            return isvalid;
        }
        private void btnsum_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    double txt1 = Convert.ToDouble(txtbox1.Text);
                    double txt2 = Convert.ToDouble(txtbox2.Text);
                    double sum = calculator.Sum(txt1, txt2);
                    MessageBox.Show("حاصل حمع شما هست:" + sum);
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("لطفا فقط عدد وارد کنید");
            }
          
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    double txt1 = Convert.ToDouble(txtbox1.Text);
                    double txt2 = Convert.ToDouble(txtbox2.Text);
                    double minus = calculator.Minus(txt1, txt2);
                    MessageBox.Show("حاصل منها شما هست:" + minus);
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("لطفا فقط عدد وارد کنید");
            }
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    double txt1 = Convert.ToDouble(txtbox1.Text);
                    double txt2 = Convert.ToDouble(txtbox2.Text);
                    double multiple = calculator.Multiple(txt1, txt2);
                    MessageBox.Show("حاصل ضرب شما هست:" + multiple);
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("لطفا فقط عدد وارد کنید");
            }
        }

        private void btndivine_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    float txt1 = Convert.ToInt32(txtbox1.Text);
                    float txt2 = Convert.ToInt32(txtbox2.Text);
                    double divine = calculator.divine((float)txt1,(float) txt2);
                    MessageBox.Show("حاصل تقسیم شما هست:" + divine);
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("لطفا فقط عدد وارد کنید");
            }
        }
    }
}
