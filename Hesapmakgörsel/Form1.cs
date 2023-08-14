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

        }
    }
}