namespace calculator
{
    public partial class Form1 : Form
    {
        double n1, n2, r;
        string opera;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = txtResult.Text + "0";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
                txtResult.Text = txtResult.Text = "";
                txtResult.Text = txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string curtext;
            curtext = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            txtResult.Text = curtext;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtResult.Text);
            opera = "+";
            txtResult.Text = "";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtResult.Text);
            opera = "-";
            txtResult.Text = "";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtResult.Text);
            opera = "x";
            txtResult.Text = "";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtResult.Text);
            opera = "/";
            txtResult.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txtResult.Text);
            if (opera == "+")
            {
                r = n1 + n2;
                txtResult.Text = r.ToString();
            }
            if (opera == "-")
            {
                r = n1 - n2;
                txtResult.Text = r.ToString();
            }
            if (opera == "x")
            {
                r = n1 * n2;
                txtResult.Text = r.ToString();
            }
            if (opera == "/")
            {
                r = n1 / n2;
                txtResult.Text = r.ToString();
            }
        }
    }
}