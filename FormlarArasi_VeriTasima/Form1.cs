using System;
using System.Windows.Forms;

namespace FormlarArasi_VeriTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.gond = textBox1.Text;
            frm.mesaj = textBox2.Text;
            frm.Show();
            this.Hide();
        }
    }
}
