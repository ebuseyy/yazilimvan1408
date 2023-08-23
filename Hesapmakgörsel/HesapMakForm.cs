using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hesapmakgörsel
{
    public partial class HesapMakForm : Form
    {
        SqlConnection ridvan = new SqlConnection("Server=DESKTOP-520STTO;Database=Northwind;User Id=sa;Password=12345;");
        public HesapMakForm()
        {
            InitializeComponent();
        }
        
        private void HesapMakForm_Load(object sender, EventArgs e)
        {
            button1.Text = "1";
            button2.Text = "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tsayi1.Text = "1";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(50, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ridvan.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select * from Categories",ridvan);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            ridvan.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ridvan.Open();
            SqlCommand cmd = new SqlCommand("insert into categories(CategoryName)values('"+textBox1.Text+"')",ridvan);

            cmd.ExecuteNonQuery();

            ridvan.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int sayac;
            string isim;
            sayac = 1;
            isim = "sena";


            while (@sayac <= 10)
            {
                listBox1.Items.Add(isim);
                sayac = sayac + 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ridvan.Open();
            SqlCommand cmd = new SqlCommand("update categories set  CategoryName='"+textBox1.Text+"' where categoryID="+textBox2.Text+"", ridvan);

            cmd.ExecuteNonQuery();

            ridvan.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ridvan.Open();
            SqlCommand cmd = new SqlCommand("delete from categories where categoryID="+textBox2.Text+"", ridvan);

            int sonuc=cmd.ExecuteNonQuery();
            if (sonuc < 0)
                MessageBox.Show("kategori silinemedi");
            else
                MessageBox.Show("kategori silme işlemi başarılı");

            ridvan.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = dataGridView1.CurrentCell.RowIndex;
            textBox2.Text = dataGridView1.Rows[id].Cells["categoryID"].Value.ToString();
        }
    }
}
