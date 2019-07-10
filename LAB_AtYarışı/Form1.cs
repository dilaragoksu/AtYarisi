using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rst = new Random();
        int sayi = 0;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = sayi + 1;
            lblSure.Text = Convert.ToString(sayi);

            pctrAt1.Left = pctrAt1.Left + rst.Next(1,10);
            pctrAt2.Left = pctrAt2.Left + rst.Next(1,10);
            pctrAt3.Left = pctrAt3.Left + rst.Next(1,10);

            if (pctrAt1.Left> label1.Width+20 || pctrAt2.Left> label1.Width+20 || pctrAt3.Left> label1.Width+20)
            {
                timer1.Enabled = false;
            }
            if (pctrAt1.Left >= label1.Width+20)
            {
                MessageBox.Show("1.At yarışı kazandı.");
            }
            else if (pctrAt2.Left >= label1.Width+20)
            {
                MessageBox.Show("2.At yarışı kazandı.");
            }
            else if (pctrAt3.Left >= label1.Width+20)
            {
                MessageBox.Show("3.At yarışı kazandı.");
            }
            if (pctrAt1.Left > pctrAt2.Left && pctrAt1.Left > pctrAt3.Left)
            {
                lblGosterge.Text = "1.At yarışı önde götürüyor...";
            }
            else if (pctrAt2.Left > pctrAt1.Left && pctrAt2.Left > pctrAt3.Left)
            {
                lblGosterge.Text = "2.At yarışı önde götürüyor...";
            }
            else if (pctrAt3.Left > pctrAt2.Left && pctrAt3.Left > pctrAt1.Left)
            {
                lblGosterge.Text = "3.At yarışı önde götürüyor...";
            }
            else
                lblGosterge.Text = "Berabere";
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            pctrAt1.Left = 0;
            pctrAt2.Left = 0;
            pctrAt3.Left = 0;
            timer1.Stop();
            lblGosterge.Text = " ";
            sayi = 0;
            lblSure.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
