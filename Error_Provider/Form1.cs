namespace Error_Provider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                // MessageBox.Show("Fill the Username!!");
                errorProvider1.SetError(this.textBox1, "Please fill the username!!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                //MessageBox.Show("Fill the Password!!");
                errorProvider2.SetError(this.textBox2, "Please fill the password!!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                // MessageBox.Show("Fill the Username!!");
                errorProvider1.SetError(this.textBox1, "Please fill the username!!");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                //MessageBox.Show("Fill the Password!!");
                errorProvider2.SetError(this.textBox2, "Please fill the password!!");
            }
            else
            {
                MessageBox.Show("Welcome!!");
            }
                
        }
    }
}