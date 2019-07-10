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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
            rnd = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bir kontrolün left property'sio kontrolün sola olan uzaklığını verir.
            //Bir kontrolün Left ve Top özelliklerine atama yapabilirsiniz. Ancak Right ve Bottom özelliklerinin o anki değerini kontrol edebilir.

            //pctrAt1.Right" += rnd.Next(5, 16);
            //pctrAt2.Left += rnd.Next(5, 16);
            //pctrAt3.Left += rnd.Next(5, 16);

            pctrAt1.Left += rnd.Next(5, 16);
            pctrAt2.Left += rnd.Next(5, 16);
            pctrAt3.Left += rnd.Next(5, 16);
            if (pctrAt1.Left>pctrAt2.Left && pctrAt1.Left>pctrAt3.Left)
            {
                lblGosterge.Text = "Birinci at önde gidiyor...";
            }
            //if (pctrAt1.Right > pctrAt2.Right && pctrAt1.Right > pctrAt3.Right)
            //{
            //    lblGosterge.Text = "Birinci at önde gidiyor...";
            //}
            else if (pctrAt2.Left > pctrAt1.Left && pctrAt2.Left > pctrAt3.Left)
            {
                lblGosterge.Text = "İkinci at önde gidiyor...";
            }
            else if (pctrAt3.Left > pctrAt1.Left && pctrAt3.Left > pctrAt2.Left)
            {
                lblGosterge.Text = "Üçüncü at önde gidiyor...";
            }

            //bir kontrolün "Width" özelliği o kontrolün genişliği bize teslim eder. "Height" özelliği yüksekliği verir.
            if (pctrAt1.Left+pctrAt1.Width>=lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı birinci kulvardaki atınız kazandı.");
            }
            else if (pctrAt2.Left + pctrAt2.Width >= lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı ikinci kulvardaki atınız kazandı!!!");
            }
            else if (pctrAt3.Left + pctrAt3.Width >= lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı üçüncü kulvardaki atınız kazandı!!!");
            }


        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pctrAt1.Left = 79;
            pctrAt2.Left = 79;
            pctrAt3.Left = 79;
            lblGosterge.Text = " ";
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //Hile
            pctrAt3.Left += 15;
        }
    }
}
