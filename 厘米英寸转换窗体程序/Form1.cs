namespace homework1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double inch = 0, cm = 0;
            cm = double.Parse(textBox1.Text);
            inch = cm * 0.3937;
            textBox2.Text = Convert.ToString(inch);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double inch = 0, cm = 0;
            inch = double.Parse(textBox2.Text);
            cm = inch * 2.54;
            textBox1.Text = Convert.ToString(cm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }
    }
}