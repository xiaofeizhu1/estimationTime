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
    public partial class Form1 : Form
    {
        public float plinth,color,smooth,start, start1,start2,start3,start4,total, total1, ec1height,ec1amount, ec2amount, ec3amount, escamount,flamount,ocnp,ocn,ofo,owe,ogr,opa,oas;
        public int en = 0,mu=0,cr=0,dor=0,la=0,ct=0,du=0,lu=0,ra=0,gl=0;

        private void flAM_TextChanged(object sender, EventArgs e)
        {
            flamount = 1f;
            flamount = string.IsNullOrEmpty(flAM.Text) ? 0 : float.Parse(flAM.Text);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (fltb.Text == "400")
            {
                start4 = 1.20f;
            }
            else if (fltb.Text == "600")
            {
                start4 = 1.21f;
            }
            else if (fltb.Text == "800")
            {
                start4 = 1.23f;
            }
            else if (fltb.Text == "1000")
            {
                start4 = 1.24f;
            }
            else if (fltb.Text == "1200")
            {
                start4 = 1.30f;
            }
            else if (fltb.Text == "1400")
            {
                start4 = 1.34f;
            }
            else if (fltb.Text == "1600")
            {
                start4 = 1.39f;
            }
            else if (fltb.Text == "1800")
            {
                start4 = 1.47f;
            }
            else if (fltb.Text == "2000")
            {
                start4 = 1.55f;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DSS frm = new DSS();
            //frm.Show();
            //Form1 f = new Form1();
            //f.Close();

            this.Hide();
            var form2 = new DSS();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                plinth = 0.67f;
            }
            else
            {
                color = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                color = 2.0f;
            }
            else
            {
                color = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                smooth = 0.5f;
            }
            else
            {
                smooth = 0;
            }
        }

        private void cttb_TextChanged(object sender, EventArgs e)
        {
            ct = string.IsNullOrEmpty(cttb.Text) ? 0 : Int32.Parse(cttb.Text);
        }

        private void dutb_TextChanged(object sender, EventArgs e)
        {
            du = string.IsNullOrEmpty(dutb.Text) ? 0 : Int32.Parse(dutb.Text);
        }

        private void lutb_TextChanged(object sender, EventArgs e)
        {
            lu = string.IsNullOrEmpty(lutb.Text) ? 0 : Int32.Parse(lutb.Text);
        }

        private void gltb_TextChanged(object sender, EventArgs e)
        {
            gl = string.IsNullOrEmpty(gltb.Text) ? 0 : Int32.Parse(gltb.Text);
        }

        private void latb_TextChanged(object sender, EventArgs e)
        {
            la = string.IsNullOrEmpty(latb.Text) ? 0 : Int32.Parse(latb.Text);
        }

        private void dotb_TextChanged(object sender, EventArgs e)
        {
            dor = string.IsNullOrEmpty(dotb.Text) ? 0 : Int32.Parse(dotb.Text);
        }

        private void crtb_TextChanged(object sender, EventArgs e)
        {
            cr = string.IsNullOrEmpty(crtb.Text) ? 0 : Int32.Parse(crtb.Text);
        }

        private void mutb_TextChanged(object sender, EventArgs e)
        {
            mu = string.IsNullOrEmpty(mutb.Text) ? 0 : Int32.Parse(mutb.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Enc1AT_TextChanged(object sender, EventArgs e)
        {
            ec1amount = 1;
            ec1amount = string.IsNullOrEmpty(Enc1AT.Text) ? 0 : float.Parse(Enc1AT.Text);
        }

        private void Enc2HT_TextChanged(object sender, EventArgs e)
        {
            if (Enc2HT.Text == "400")
            {
                start2 = 1.90f;
            }
            else if (Enc2HT.Text == "600")
            {
                start2 = 2.24f;
            }
            else if (Enc2HT.Text == "800")
            {
                start2 = 2.47f;
            }
            else if (Enc2HT.Text == "1000")
            {
                start2 = 2.71f;
            }
            else if (Enc2HT.Text == "1200")
            {
                start2 = 2.88f;
            }
            else if (Enc2HT.Text == "1400")
            {
                start2 = 3.15f;
            }
            else if (Enc2HT.Text == "1600")
            {
                start2 = 3.49f;
            }
            else if (Enc2HT.Text == "1800")
            {
                start2 = 3.79f;
            }
            else if (Enc2HT.Text == "2000")
            {
                start2 = 4.34f;
            }
            //else
            //{
            //    start = 4.34f;
            //}
        }

        private void Enc3HT_TextChanged(object sender, EventArgs e)
        {
            if (Enc3HT.Text == "400")
            {
                start3 = 1.90f;
            }
            else if (Enc3HT.Text == "600")
            {
                start3 = 2.24f;
            }
            else if (Enc3HT.Text == "800")
            {
                start3 = 2.47f;
            }
            else if (Enc3HT.Text == "1000")
            {
                start3 = 2.71f;
            }
            else if (Enc3HT.Text == "1200")
            {
                start3 = 2.88f;
            }
            else if (Enc3HT.Text == "1400")
            {
                start3 = 3.15f;
            }
            else if (Enc3HT.Text == "1600")
            {
                start3 = 3.49f;
            }
            else if (Enc3HT.Text == "1800")
            {
                start3 = 3.79f;
            }
            else if (Enc3HT.Text == "2000")
            {
                start3 = 4.34f;
            }
            //else
            //{
            //    start = 4.34f;
            //}
        }

        private void entb_TextChanged(object sender, EventArgs e)
        {
            en = string.IsNullOrEmpty(entb.Text) ? 0 : Int32.Parse(entb.Text);
        }

        private void EscAT_TextChanged(object sender, EventArgs e)
        {
                escamount = 1f;
                escamount = string.IsNullOrEmpty(EscAT.Text) ? 0 : float.Parse(EscAT.Text); 
        }

        private void EscHT_TextChanged(object sender, EventArgs e)
        {
            if (EscHT.Text == "400")
            {
                start1 = 0.60f;
            }
            else if (EscHT.Text == "600")
            {
                start1 = 0.67f;
            }
            else if (EscHT.Text == "800")
            {
                start1 = 0.73f;
            }
            else if (EscHT.Text == "1000")
            {
                start1 = 0.80f;
            }
            else if (EscHT.Text == "1200")
            {
                start1 = 0.87f;
            }
            else if (EscHT.Text == "1400")
            {
                start1 = 0.93f;
            }
            else if (EscHT.Text == "1600")
            {
                start1 = 1.00f;
            }
            else if (EscHT.Text == "1800")
            {
                start1 = 1.07f;
            }
            else if (EscHT.Text == "2000")
            {
                start1 = 1.13f;
            }
            //else
            //{
            //    start1 = 1.13f;
            //}
        }

        private void Enc3AT_TextChanged(object sender, EventArgs e)
        {
            ec3amount = 1f;
            ec3amount = string.IsNullOrEmpty(Enc3AT.Text) ? 0 : float.Parse(Enc3AT.Text);
        }

        private void Enc2AT_TextChanged(object sender, EventArgs e)
        {
            ec2amount = 1f;
            ec2amount = string.IsNullOrEmpty(Enc2AT.Text) ? 0 : float.Parse(Enc2AT.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (Enc1HT.Text == "400")
            {
                start = 1.90f;
            }
            else if (Enc1HT.Text == "600")
            {
                start = 2.24f;
            }
            else if (Enc1HT.Text == "800")
            {
                start = 2.47f;
            }
            else if (Enc1HT.Text == "1000")
            {
                start = 2.71f;
            }
            else if (Enc1HT.Text == "1200")
            {
                start = 2.88f;
            }
            else if (Enc1HT.Text == "1400")
            {
                start = 3.15f;
            }
            else if (Enc1HT.Text == "1600")
            {
                start = 3.49f;
            }
            else if (Enc1HT.Text == "1800")
            {
                start = 3.79f;
            }
            else if (Enc1HT.Text == "2000")
            {
                start = 4.34f;
            }
            //else
            //{
            //    start = 4.34f;
            //}
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
                
                int number = string.IsNullOrEmpty(Enc2HT.Text)?0: Int32.Parse(Enc2HT.Text);
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
            if (fltb.Text != "400" && fltb.Text != "600"
            && fltb.Text != "800" && fltb.Text != "1000" &&
            fltb.Text != "1200" && fltb.Text != "1400"
            && fltb.Text != "1600" && fltb.Text != "1800" && fltb.Text != "2000")
            {
                int number = string.IsNullOrEmpty(fltb.Text) ? 0 : Int32.Parse(fltb.Text);
                // int number = Int32.Parse(Enc3HT.Text);
                List<int> list = new List<int> { 0, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000 };
                int closest = list.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                fltb.Text = closest.ToString();
            }
            Add();
            textBox2.Text=(Convert.ToString(total));
            ocnptb.Text=(Convert.ToString(ocnp));
            ocntb.Text=(Convert.ToString(ocn));
            ofotb.Text=(Convert.ToString(ofo)); 
            owetb.Text=(Convert.ToString(owe));
            ogrtb.Text=(Convert.ToString(ogr));
            opatb.Text=(Convert.ToString(opa));
            oastb.Text=(Convert.ToString(oas));

        }
        private void Add()
        {
            total = (start*ec1amount + start2*ec2amount +  start3*ec3amount)+start1*escamount+start4*flamount+ en *0.25f+mu*0.5f+cr*1.0f+dor*0.25f+la*0.5f+ct*0.75f+du*1f+lu*0.25f+ra*0.33f+gl*0.28f+smooth+color+plinth;
            ocnp = 0.05f*start4 * flamount + (start * ec1amount + start2 * ec2amount + start3 * ec3amount) * 0.03f+ start1 * escamount*0.42f+ gl * 0.28f*0.05f;
            ocn = 0.45f*start4 * flamount+(start * ec1amount + start2 * ec2amount + start3 * ec3amount) * 0.15f + start1 * escamount * 0.17f + gl * 0.28f * 0.65f;
            ofo = 0.30f*start4 * flamount+(start * ec1amount + start2 * ec2amount + start3 * ec3amount) * 0.15f + start1 * escamount * 0.15f + gl * 0.28f * 0f;
            owe = (start * ec1amount + start2 * ec2amount + start3 * ec3amount) * 0.51f + start1 * escamount * 0.08f + gl * 0.28f * 0f+0.75f*plinth;
            ogr = (start * ec1amount + start2 * ec2amount + start3 * ec3amount) * 0.10f + start1 * escamount * 0.02f + gl * 0.28f * 0f+0.25f*plinth;
            opa = 0.10f* start4 * flamount+(start * ec1amount + start2 * ec2amount + start3 * ec3amount) * 0.10f + start1 * escamount * 0.08f + gl * 0.28f * 0f + smooth + color;
            oas = 0.10f*start4 * flamount+(start * ec1amount + start2 * ec2amount + start3 * ec3amount) * 0.20f + start1 * escamount * 0.08f + gl * 0.28f * 0.3f;
        }
    }
}
