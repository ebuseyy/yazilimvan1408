namespace Hesapmakgörsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("merhaba dünya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("c# tıkladınız");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int a = button3.Location.X;
            int b = button3.Location.Y;

            button3.Location = new Point(a + 10, b);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int a = pictureBox1.Location.X;
            int b = pictureBox1.Location.Y;

            pictureBox1.Location = new Point(a + 10, b);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Pink;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Black;
        }
    }
}