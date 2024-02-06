using System.Data;

namespace CalcForms
{
    public partial class Form1 : Form
    {
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            dt = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "-";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "/";
        }
        private void Total_Click(object sender, EventArgs e)
        {
            var result = dt.Compute(textBox.Text, null);
            textBox.Text = result.ToString();
        }
    }
}
