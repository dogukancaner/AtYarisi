using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();

            int birinciatgenisligi = pictureBox1.Width;
            int ikinciatgenisligi = pictureBox2.Width;
            int ucuncuatgenisligi = pictureBox3.Width;

            int bitisuzakligi = pictureBox4.Left;

            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (pictureBox1.Left>pictureBox2.Left+10 && pictureBox1.Left>pictureBox3.Left+10)
            {
                label6.Text = " 1 NUMARALI AT YARIŞI ÖNDE GÖTÜRÜYOR";
            }
            if (pictureBox2.Left > pictureBox1.Left + 10 && pictureBox2.Left > pictureBox3.Left + 10)
            {
                label6.Text = " 2 NUMARALI AT YARIŞI ÖNDE GÖTÜRÜYOR";
            }
            if (pictureBox3.Left > pictureBox1.Left + 10 && pictureBox3.Left > pictureBox2.Left + 10)
            {
                label6.Text = " 3 NUMARALI AT YARIŞI ÖNDE GÖTÜRÜYOR";
            }

            if (birinciatgenisligi+pictureBox1.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show(" 1 NUMARALI YARIŞI KAZANDI !!!");
            }
            if (ikinciatgenisligi+pictureBox2.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show(" 2 NUMARALI AT YARIŞI KAZANDI !!!");
            }
            if (ucuncuatgenisligi+pictureBox3.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 NUMARALI AT YARIŞI KAZANDI !!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
