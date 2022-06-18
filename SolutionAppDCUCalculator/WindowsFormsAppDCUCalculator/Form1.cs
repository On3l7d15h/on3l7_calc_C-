using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDCUCalculator
{
    public partial class frm_calculator : Form
    {
        double val1;
        string sign;
        public frm_calculator()
        {
            InitializeComponent();
        }

        private void frm_calculator_Load(object sender, EventArgs e)
        {
            button0.Click += handleOnClick;
            button1.Click += handleOnClick;
            button2.Click += handleOnClick;
            button3.Click += handleOnClick;
            button4.Click += handleOnClick;
            button5.Click += handleOnClick;
            button6.Click += handleOnClick;
            button7.Click += handleOnClick;
            button8.Click += handleOnClick;
            button9.Click += handleOnClick;
            button11.Click += handleOnClick;
            button17.Click += handleOnClickSigns;
            button12.Click += handleOnClickSigns;
            button13.Click += handleOnClickSigns;
            button14.Click += handleOnClickSigns;
            button15.Click += handleOnClickSigns;
        }

        #region methods !important

        private void handleOnClick(object sender, EventArgs e)
        {
            txt_outputResults.Text += ((Button)sender).Text;
        }

        private void handleOnClickSigns(object sender, EventArgs e)
        {

            if (txt_outputResults.Text != "")
            {
                val1 = Convert.ToDouble(txt_outputResults.Text);
                sign = ((Button)sender).Text;
                txt_history.Text += val1.ToString() + sign;
                txt_outputResults.Text = "";
            } else
            {
                MessageBox.Show("Estimado Usuario, por favor ingrese primero un valor númerico y luego coloque el signo de operación", "On3l7Calc");
            }
        }

        #endregion

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txt_history.Text == "") {
                MessageBox.Show("Distingido Usuario, digite alores y signos para poder hacer la operación", "On3l7Calc");
            } else
            {
                switch(sign)
                {
                    case "+":
                    {
                        txt_outputResults.Text = (val1 + double.Parse(txt_outputResults.Text)).ToString();
                        txt_history.Text = "";
                        break;
                    }

                    case "-":
                    {
                        txt_outputResults.Text = (val1 - double.Parse(txt_outputResults.Text)).ToString();
                        txt_history.Text = "";
                        break;
                    }

                    case "x":
                    {
                        txt_outputResults.Text = (val1 * double.Parse(txt_outputResults.Text)).ToString();
                        txt_history.Text = "";
                        break;
                    }

                    case "÷":
                    {
                        txt_outputResults.Text = (val1 / double.Parse(txt_outputResults.Text)).ToString();
                        txt_history.Text = "";
                        break;
                    }

                    case "^":
                        {
                            txt_outputResults.Text = (Math.Pow(val1,  double.Parse(txt_outputResults.Text))).ToString();
                            txt_history.Text = "";
                            break;
                        }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_history.Text = "";
            txt_outputResults.Text = "";
        }
    }
}
