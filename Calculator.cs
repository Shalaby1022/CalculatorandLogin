namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private int num1;
        private int num2;
        private char op;




        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region numbers buttons

        #endregion


        private void button_1_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("9");
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            txt_result.AppendText("0");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_result.Text);
            op = '*';
            txt_result.Text = "";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_result.Text);
            op = '/';
            txt_result.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_result.Text);
            op = '+';
            txt_result.Text = "";
        }



        private void substract_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(txt_result.Text);
            op = '-';
            txt_result.Text = "";
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            num1 = num2 = 0;
            txt_result.Text = "";
        }
        private void equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txt_result.Text);

            switch (op)
            {
                case '+':
                    txt_result.Text = (num1 + num2).ToString();
                    break;
                case '-':
                    txt_result.Text = (num1 - num2).ToString();
                    break;
                case '*':
                    txt_result.Text = (num1 * num2).ToString();
                    break;
                case '/':
                    try
                    {
                        txt_result.Text = (num1 / num2).ToString();

                    }
                    catch (Exception E) { MessageBox.Show(E.Message); txt_result.Text = ""; }
                    break;


            }

        }
    }
}