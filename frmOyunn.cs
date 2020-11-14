using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2
{
    public partial class frmOyunn : Form
    {
        static int toplam = 0;
        static int sure = 111;
        Random rnd = new Random();
        public frmOyunn()
        {
            InitializeComponent();
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlGosterge.Width - btn.Width) , rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(250).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblScore.Text = $"Skor:{toplam}";
            btn.Dispose();

        }

        private void frmOyunn_Load(object sender, EventArgs e)
        {
             
            
        }
        
        private static void FSkayit(string deger)
        {


            FileStream fs = new FileStream("logkayit", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(DateTime.Now + " ");
            sw.Write(deger + "\n");
            fs.Flush();
            sw.Close();
            fs.Close();
        }
        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (lblSure.Text == "0")
            {


                tmrSure.Stop();
                tmrButton.Stop();

                FSkayit(lblScore.Text);

                DialogResult result = new DialogResult();

                result = MessageBox.Show($"Oyununuz bitmiştir. \nSkorunuz: {lblScore.Text} Puan\n" +
                "Yeniden oynamak için tıklayınız..", "ÇIKIŞ", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    Application.Restart();

                }
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();
            btnBaslat.BackColor = Color.Black;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            tmrButton.Stop();
            tmrSure.Stop();
            lblSure.Text = "0";
            DialogResult result = new DialogResult();

            result = MessageBox.Show($"Oyununuz bitmiştir. \nSkorunuz: {lblScore.Text} Puan\n" +
            "Yeniden oynamak için tıklayınız..", "ÇIKIŞ", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                Application.Restart();

            }

        }
    }
}
