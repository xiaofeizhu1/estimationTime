using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DSS : Form
    {
        public float start,start1,start2,start3,start11,total, ec1amount, ec2amount, ec3amount, ec4amount, escamount;

        private void Enc4AT_TextChanged(object sender, EventArgs e)
        {
            ec4amount = 1;
            ec4amount = string.IsNullOrEmpty(Enc4AT.Text) ? 0 : float.Parse(Enc4AT.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void EscHT_TextChanged(object sender, EventArgs e)
        {
            if (EscHT.Text == "400")
            {
                start11 = 0.60f;
            }
            else if (EscHT.Text == "600")
            {
                start11 = 0.67f;
            }
            else if (EscHT.Text == "800")
            {
                start11 = 0.73f;
            }
            else if (EscHT.Text == "1000")
            {
                start11 = 0.80f;
            }
            else if (EscHT.Text == "1200")
            {
                start11 = 0.87f;
            }
            else if (EscHT.Text == "1400")
            {
                start11 = 0.93f;
            }
            else if (EscHT.Text == "1600")
            {
                start11 = 1.00f;
            }
            else if (EscHT.Text == "1800")
            {
                start11 = 1.07f;
            }
            else if (EscHT.Text == "2000")
            {
                start11 = 1.13f;
            }
        }

        private void EscAT_TextChanged(object sender, EventArgs e)
        {
            escamount = 1f;
            escamount = string.IsNullOrEmpty(EscAT.Text) ? 0 : float.Parse(EscAT.Text);
        }

        public DSS()
        {
            InitializeComponent();
        }

        private void Enc3AT_TextChanged(object sender, EventArgs e)
        {
            ec3amount = 1;
            ec3amount = string.IsNullOrEmpty(Enc3AT.Text) ? 0 : float.Parse(Enc3AT.Text);
        }

        private void Enc2AT_TextChanged(object sender, EventArgs e)
        {
            ec2amount = 1;
            ec2amount = string.IsNullOrEmpty(Enc2AT.Text) ? 0 : float.Parse(Enc2AT.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Enc1HT.Text != "400" && Enc1HT.Text != "600"
             && Enc1HT.Text != "800" && Enc1HT.Text != "1000" &&
             Enc1HT.Text != "1200" && Enc1HT.Text != "1400"
             && Enc1HT.Text != "1600" && Enc1HT.Text != "1800" && Enc1HT.Text != "2000")
            {
                int number = string.IsNullOrEmpty(Enc1HT.Text) ? 0 : Int32.Parse(Enc1HT.Text);
                //int number = Int32.Parse(Enc1HT.Text);
                List<int> list = new List<int> {0, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc1HT.Text = closest.ToString();
            }
            if (Enc2HT.Text != "400" && Enc2HT.Text != "600"
            && Enc2HT.Text != "800" && Enc2HT.Text != "1000" &&
            Enc2HT.Text != "1200" && Enc2HT.Text != "1400"
            && Enc2HT.Text != "1600" && Enc2HT.Text != "1800" && Enc2HT.Text != "2000")
            {

                int number = string.IsNullOrEmpty(Enc2HT.Text) ? 0 : Int32.Parse(Enc2HT.Text);
                // int number = Int32.Parse(Enc2HT.Text);
                List<int> list = new List<int> {0, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc2HT.Text = closest.ToString();

            }
            if (Enc3HT.Text != "400" && Enc3HT.Text != "600"
           && Enc3HT.Text != "800" && Enc3HT.Text != "1000" &&
           Enc3HT.Text != "1200" && Enc3HT.Text != "1400"
           && Enc3HT.Text != "1600" && Enc3HT.Text != "1800" && Enc3HT.Text != "2000")
            {
                int number = string.IsNullOrEmpty(Enc3HT.Text) ? 0 : Int32.Parse(Enc3HT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc3HT.Text = closest.ToString();
            }
            if (Enc4HT.Text != "400" && Enc4HT.Text != "600"
            && Enc4HT.Text != "800" && Enc4HT.Text != "1000" &&
            Enc4HT.Text != "1200" && Enc4HT.Text != "1400"
            && Enc4HT.Text != "1600" && Enc4HT.Text != "1800" && Enc4HT.Text != "2000")
            {
                int number = string.IsNullOrEmpty(Enc4HT.Text) ? 0 : Int32.Parse(Enc4HT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc4HT.Text = closest.ToString();
            }
            if (Enc1WT.Text != "400" && Enc1WT.Text != "700"&& Enc1WT.Text != "900")
            {
                int number = string.IsNullOrEmpty(Enc1WT.Text) ? 0 : Int32.Parse(Enc1WT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> { 0, 400, 700, 900 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc1WT.Text = closest.ToString();
            }
            if (Enc2WT.Text != "400" && Enc2WT.Text != "700" && Enc2WT.Text != "900")
            {
                int number = string.IsNullOrEmpty(Enc2WT.Text) ? 0 : Int32.Parse(Enc2WT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 400, 700, 900 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc2WT.Text = closest.ToString();
            }
            if (Enc3WT.Text != "400" && Enc3WT.Text != "700" && Enc3WT.Text != "900")
            {
                int number = string.IsNullOrEmpty(Enc3WT.Text) ? 0 : Int32.Parse(Enc3WT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 400, 700, 900 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc3WT.Text = closest.ToString();
            }
            if (Enc4WT.Text != "400" && Enc4WT.Text != "700" && Enc4WT.Text != "900")
            {
                int number = string.IsNullOrEmpty(Enc4WT.Text) ? 0 : Int32.Parse(Enc4WT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 400, 700, 900 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc4WT.Text = closest.ToString();
            }
            if (Enc1DT.Text != "225" && Enc1DT.Text != "325" && Enc1DT.Text != "425")
            {
                int number = string.IsNullOrEmpty(Enc1DT.Text) ? 0 : Int32.Parse(Enc1DT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 225, 325, 425 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc1DT.Text = closest.ToString();
            }
            if (Enc2DT.Text != "225" && Enc2DT.Text != "325" && Enc2DT.Text != "425")
            {
                int number = string.IsNullOrEmpty(Enc2DT.Text) ? 0 : Int32.Parse(Enc2DT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 225, 325, 425 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc2DT.Text = closest.ToString();
            }
            if (Enc3DT.Text != "225" && Enc3DT.Text != "325" && Enc3DT.Text != "425")
            {
                int number = string.IsNullOrEmpty(Enc3DT.Text) ? 0 : Int32.Parse(Enc3DT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> {0, 225, 325, 425 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc3DT.Text = closest.ToString();
            }
            if (Enc4DT.Text != "225" && Enc4DT.Text != "325" && Enc4DT.Text != "425")
            {
                int number = string.IsNullOrEmpty(Enc4DT.Text) ? 0 : Int32.Parse(Enc4DT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> { 0, 225, 325, 425 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                Enc4DT.Text = closest.ToString();
            }
            //
            if (EscHT.Text != "400" && EscHT.Text != "600"
             && EscHT.Text != "800" && EscHT.Text != "1000" &&
            EscHT.Text != "1200" && EscHT.Text != "1400"
            && EscHT.Text != "1600" && EscHT.Text != "1800" && EscHT.Text != "2000")
            {
                int number = string.IsNullOrEmpty(EscHT.Text) ? 0 : Int32.Parse(EscHT.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> { 0, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                EscHT.Text = closest.ToString();
            }


            if (Enc1HT.Text == "400" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 3.64f;
            }
            else if (Enc1HT.Text == "600" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 3.74f;
            }
            else if (Enc1HT.Text == "800" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 3.96f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 4.18f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 4.55f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 4.92f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 5.30f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 5.67f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb1.Checked)
            {
                start = 6.04f;
            }
            else if (Enc1HT.Text == "400" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 3.82f;
            }
            else if (Enc1HT.Text == "600" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 3.97f;
            }
            else if (Enc1HT.Text == "800" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 4.62f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 5.91f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 6.33f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 6.76f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 7.57f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 8.56f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb2.Checked)
            {
                start = 9.04f;
            }
            else if (Enc1HT.Text == "400" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 4.73f;
            }
            else if (Enc1HT.Text == "600" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 4.86f;
            }
            else if (Enc1HT.Text == "800" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 5.15f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 5.43f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 5.92f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 6.40f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 6.89f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 7.37f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "400" && Enc1DT.Text == "225" && rb3.Checked)
            {
                start = 7.85f;
            }
            // line 2
            else if (Enc1HT.Text == "600" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 4.22f;
            }
            else if (Enc1HT.Text == "800" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 4.55f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 5.31f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 5.61f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 5.90f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 6.05f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 6.71f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 7.20f;
            }
            else if (Enc1HT.Text == "600" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 5.43f;
            }
            else if (Enc1HT.Text == "800" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 6.40f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 6.59f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 7.36f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 8.31f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 9.16f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 10.32f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 11.05f;
            }
            else if (Enc1HT.Text == "600" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 4.45f;
            }
            else if (Enc1HT.Text == "800" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 5.02f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 5.54f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 5.93f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 6.41f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 6.94f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 7.83f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "700" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 8.57f;
            }

            //line3
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 5.51f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 5.78f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 6.08f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 6.36f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 6.95f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb1.Checked)
            {
                start = 7.47f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 5.51f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 5.78f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 6.08f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 6.36f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 6.95f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb2.Checked)
            {
                start = 7.47f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 5.76f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 6.12f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 6.61f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 7.20f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 8.06f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "900" && Enc1DT.Text == "325" && rb3.Checked)
            {
                start = 8.61f;
            }

            //line 4
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 5.54f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 5.76f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 6.04f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 6.20f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 6.90f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 7.39f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 7.04f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 7.61f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 8.42f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 9.26f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 10.43f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 11.27f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 5.82f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 6.18f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 6.54f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 7.02f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 7.95f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "700" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 8.70f;
            }

            //line5
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 5.64f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 5.90f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 6.20f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 6.51f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 7.06f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb1.Checked)
            {
                start = 7.58f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 7.25f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 7.78f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 8.63f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 9.54f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 10.64f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb2.Checked)
            {
                start = 11.37f;
            }
            else if (Enc1HT.Text == "1000" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 5.99f;
            }
            else if (Enc1HT.Text == "1200" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 6.35f;
            }
            else if (Enc1HT.Text == "1400" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 6.72f;
            }
            else if (Enc1HT.Text == "1600" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 7.33f;
            }
            else if (Enc1HT.Text == "1800" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 8.15f;
            }
            else if (Enc1HT.Text == "2000" && Enc1WT.Text == "900" && Enc1DT.Text == "425" && rb3.Checked)
            {
                start = 8.82f;
            }
            //else
            //{
            //    start = 888;
            //}

            //enc2@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            if (Enc2HT.Text == "400" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 3.64f;
            }
            else if (Enc2HT.Text == "600" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 3.74f;
            }
            else if (Enc2HT.Text == "800" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 3.96f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 4.18f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 4.55f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 4.92f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 5.30f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 5.67f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb1.Checked)
            {
                start1 = 6.04f;
            }
            else if (Enc2HT.Text == "400" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 3.82f;
            }
            else if (Enc2HT.Text == "600" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 3.97f;
            }
            else if (Enc2HT.Text == "800" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 4.62f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 5.91f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 6.33f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 6.76f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 7.57f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 8.56f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb2.Checked)
            {
                start1 = 9.04f;
            }
            else if (Enc2HT.Text == "400" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 4.73f;
            }
            else if (Enc2HT.Text == "600" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 4.86f;
            }
            else if (Enc2HT.Text == "800" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 5.15f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 5.43f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 5.92f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 6.40f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 6.89f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 7.37f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "400" && Enc2DT.Text == "225" && rb3.Checked)
            {
                start1 = 7.85f;
            }
            // line 2
            else if (Enc2HT.Text == "600" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 4.22f;
            }
            else if (Enc2HT.Text == "800" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 4.55f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 5.31f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 5.61f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 5.90f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 6.05f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 6.71f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 7.20f;
            }
            else if (Enc2HT.Text == "600" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 5.43f;
            }
            else if (Enc2HT.Text == "800" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 6.40f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 6.59f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 7.36f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 8.31f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 9.16f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 10.32f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 11.05f;
            }
            else if (Enc2HT.Text == "600" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 4.45f;
            }
            else if (Enc2HT.Text == "800" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 5.02f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 5.54f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 5.93f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 6.41f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 6.94f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 7.83f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "700" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 8.57f;
            }

            //line3
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 5.51f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 5.78f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 6.08f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 6.36f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 6.95f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb1.Checked)
            {
                start1 = 7.47f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 5.51f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 5.78f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 6.08f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 6.36f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 6.95f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb2.Checked)
            {
                start1 = 7.47f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 5.76f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 6.12f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 6.61f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 7.20f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 8.06f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "900" && Enc2DT.Text == "325" && rb3.Checked)
            {
                start1 = 8.61f;
            }

            //line 4
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 5.54f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 5.76f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 6.04f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 6.20f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 6.90f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 7.39f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 7.04f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 7.61f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 8.42f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 9.26f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 10.43f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 11.27f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 5.82f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 6.18f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 6.54f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 7.02f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 7.95f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "700" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 8.70f;
            }

            //line5
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 5.64f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 5.90f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 6.20f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 6.51f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 7.06f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb1.Checked)
            {
                start1 = 7.58f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 7.25f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 7.78f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 8.63f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 9.54f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 10.64f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb2.Checked)
            {
                start1 = 11.37f;
            }
            else if (Enc2HT.Text == "1000" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 5.99f;
            }
            else if (Enc2HT.Text == "1200" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 6.35f;
            }
            else if (Enc2HT.Text == "1400" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 6.72f;
            }
            else if (Enc2HT.Text == "1600" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 7.33f;
            }
            else if (Enc2HT.Text == "1800" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 8.15f;
            }
            else if (Enc2HT.Text == "2000" && Enc2WT.Text == "900" && Enc2DT.Text == "425" && rb3.Checked)
            {
                start1 = 8.82f;
            }
            //else
            //{
            //    start1 = 888;
            //}
            //enc3&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
            if (Enc3HT.Text == "400" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 3.64f;
            }
            else if (Enc3HT.Text == "600" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 3.74f;
            }
            else if (Enc3HT.Text == "800" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 3.96f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 4.18f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 4.55f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 4.92f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 5.30f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 5.67f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb1.Checked)
            {
                start2 = 6.04f;
            }
            else if (Enc3HT.Text == "400" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 3.82f;
            }
            else if (Enc3HT.Text == "600" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 3.97f;
            }
            else if (Enc3HT.Text == "800" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 4.62f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 5.91f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 6.33f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 6.76f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 7.57f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 8.56f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb2.Checked)
            {
                start2 = 9.04f;
            }
            else if (Enc3HT.Text == "400" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 4.73f;
            }
            else if (Enc3HT.Text == "600" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 4.86f;
            }
            else if (Enc3HT.Text == "800" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 5.15f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 5.43f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 5.92f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 6.40f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 6.89f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 7.37f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "400" && Enc3DT.Text == "225" && rb3.Checked)
            {
                start2 = 7.85f;
            }
            // line 2
            else if (Enc3HT.Text == "600" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 4.22f;
            }
            else if (Enc3HT.Text == "800" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 4.55f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 5.31f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 5.61f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 5.90f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 6.05f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 6.71f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 7.20f;
            }
            else if (Enc3HT.Text == "600" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 5.43f;
            }
            else if (Enc3HT.Text == "800" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 6.40f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 6.59f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 7.36f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 8.31f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 9.16f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 10.32f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 11.05f;
            }
            else if (Enc3HT.Text == "600" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 4.45f;
            }
            else if (Enc3HT.Text == "800" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 5.02f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 5.54f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 5.93f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 6.41f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 6.94f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 7.83f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "700" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 8.57f;
            }

            //line3
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 5.51f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 5.78f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 6.08f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 6.36f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 6.95f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb1.Checked)
            {
                start2 = 7.47f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 5.51f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 5.78f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 6.08f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 6.36f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 6.95f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb2.Checked)
            {
                start2 = 7.47f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 5.76f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 6.12f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 6.61f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 7.20f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 8.06f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "900" && Enc3DT.Text == "325" && rb3.Checked)
            {
                start2 = 8.61f;
            }

            //line 4
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 5.54f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 5.76f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 6.04f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 6.20f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 6.90f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 7.39f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 7.04f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 7.61f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 8.42f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 9.26f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 10.43f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 11.27f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 5.82f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 6.18f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 6.54f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 7.02f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 7.95f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "700" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 8.70f;
            }

            //line5
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 5.64f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 5.90f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 6.20f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 6.51f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 7.06f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb1.Checked)
            {
                start2 = 7.58f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 7.25f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 7.78f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 8.63f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 9.54f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 10.64f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb2.Checked)
            {
                start2 = 11.37f;
            }
            else if (Enc3HT.Text == "1000" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 5.99f;
            }
            else if (Enc3HT.Text == "1200" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 6.35f;
            }
            else if (Enc3HT.Text == "1400" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 6.72f;
            }
            else if (Enc3HT.Text == "1600" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 7.33f;
            }
            else if (Enc3HT.Text == "1800" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 8.15f;
            }
            else if (Enc3HT.Text == "2000" && Enc3WT.Text == "900" && Enc3DT.Text == "425" && rb3.Checked)
            {
                start2 = 8.82f;
            }
            //else
            //{
            //    start2 = 888;
            //}

            //enc4^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            if (Enc4HT.Text == "400" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 3.64f;
            }
            else if (Enc4HT.Text == "600" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 3.74f;
            }
            else if (Enc4HT.Text == "800" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 3.96f;
            }
            else if (Enc4HT.Text == "1000" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 4.18f;
            }
            else if (Enc4HT.Text == "1200" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 4.55f;
            }
            else if (Enc4HT.Text == "1400" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 4.92f;
            }
            else if (Enc4HT.Text == "1600" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 5.30f;
            }
            else if (Enc4HT.Text == "1800" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 5.67f;
            }
            else if (Enc4HT.Text == "2000" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb1.Checked)
            {
                start3 = 6.04f;
            }
            else if (Enc4HT.Text == "400" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 3.82f;
            }
            else if (Enc4HT.Text == "600" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 3.97f;
            }
            else if (Enc4HT.Text == "800" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 4.62f;
            }
            else if (Enc4HT.Text == "1000" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 5.91f;
            }
            else if (Enc4HT.Text == "1200" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 6.33f;
            }
            else if (Enc4HT.Text == "1400" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 6.76f;
            }
            else if (Enc4HT.Text == "1600" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 7.57f;
            }
            else if (Enc4HT.Text == "1800" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 8.56f;
            }
            else if (Enc4HT.Text == "2000" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb2.Checked)
            {
                start3 = 9.04f;
            }
            else if (Enc4HT.Text == "400" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 4.73f;
            }
            else if (Enc4HT.Text == "600" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 4.86f;
            }
            else if (Enc4HT.Text == "800" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 5.15f;
            }
            else if (Enc4HT.Text == "1000" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 5.43f;
            }
            else if (Enc4HT.Text == "1200" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 5.92f;
            }
            else if (Enc4HT.Text == "1400" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 6.40f;
            }
            else if (Enc4HT.Text == "1600" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 6.89f;
            }
            else if (Enc4HT.Text == "1800" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 7.37f;
            }
            else if (Enc4HT.Text == "2000" && Enc4WT.Text == "400" && Enc4DT.Text == "225" && rb3.Checked)
            {
                start3 = 7.85f;
            }
            // line 2
            else if (Enc4HT.Text == "600" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 4.22f;
            }
            else if (Enc4HT.Text == "800" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 4.55f;
            }
            else if (Enc4HT.Text == "1000" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 5.31f;
            }
            else if (Enc4HT.Text == "1200" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 5.61f;
            }
            else if (Enc4HT.Text == "1400" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 5.90f;
            }
            else if (Enc4HT.Text == "1600" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 6.05f;
            }
            else if (Enc4HT.Text == "1800" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 6.71f;
            }
            else if (Enc4HT.Text == "2000" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 7.20f;
            }
            else if (Enc4HT.Text == "600" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 5.43f;
            }
            else if (Enc4HT.Text == "800" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 6.40f;
            }
            else if (Enc4HT.Text == "1000" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 6.59f;
            }
            else if (Enc4HT.Text == "1200" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 7.36f;
            }
            else if (Enc4HT.Text == "1400" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 8.31f;
            }
            else if (Enc4HT.Text == "1600" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 9.16f;
            }
            else if (Enc4HT.Text == "1800" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 10.32f;
            }
            else if (Enc4HT.Text == "2000" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 11.05f;
            }
            else if (Enc4HT.Text == "600" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 4.45f;
            }
            else if (Enc4HT.Text == "800" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 5.02f;
            }
            else if (Enc4HT.Text == "1000" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 5.54f;
            }
            else if (Enc4HT.Text == "1200" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 5.93f;
            }
            else if (Enc4HT.Text == "1400" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 6.41f;
            }
            else if (Enc4HT.Text == "1600" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 6.94f;
            }
            else if (Enc4HT.Text == "1800" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 7.83f;
            }
            else if (Enc4HT.Text == "2000" && Enc4WT.Text == "700" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 8.57f;
            }

            //line3
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 5.51f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 5.78f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 6.08f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 6.36f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 6.95f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb1.Checked)
            {
                start3 = 7.47f;
            }
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 5.51f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 5.78f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 6.08f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 6.36f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 6.95f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb2.Checked)
            {
                start3 = 7.47f;
            }
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 5.76f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 6.12f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 6.61f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 7.20f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 8.06f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "900" && Enc4DT.Text == "325" && rb3.Checked)
            {
                start3 = 8.61f;
            }

            //line 4
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 5.54f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 5.76f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 6.04f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 6.20f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 6.90f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 7.39f;
            }
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 7.04f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 7.61f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 8.42f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 9.26f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 10.43f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 11.27f;
            }
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 5.82f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 6.18f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 6.54f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 7.02f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 7.95f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "700" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 8.70f;
            }

            //line5
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 5.64f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 5.90f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 6.20f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 6.51f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 7.06f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb1.Checked)
            {
                start3 = 7.58f;
            }
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 7.25f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 7.78f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 8.63f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 9.54f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 10.64f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb2.Checked)
            {
                start3 = 11.37f;
            }
            else if (Enc4HT.Text == "1000" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 5.99f;
            }
            else if (Enc4HT.Text == "1200" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 6.35f;
            }
            else if (Enc4HT.Text == "1400" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 6.72f;
            }
            else if (Enc4HT.Text == "1600" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 7.33f;
            }
            else if (Enc4HT.Text == "1800" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 8.15f;
            }
            else if (Enc4HT.Text == "2000" && Enc3WT.Text == "900" && Enc4DT.Text == "425" && rb3.Checked)
            {
                start3 = 8.82f;
            }
            //else
            //{
            //    start3 = 888;
            //}

            Add();
            totaltb.Text = (Convert.ToString(total));
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            ec1amount = 1;
            ec1amount = string.IsNullOrEmpty(Enc1AT.Text) ? 0 : float.Parse(Enc1AT.Text);
        }

        private void Add()
        {
            total = start*ec1amount+start1*ec2amount+start2* ec3amount+ start3 * ec4amount+ start11 * escamount;
        }
    }
}
