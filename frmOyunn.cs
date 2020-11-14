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

namespace Hedef
{
    public partial class frmOyunn : Form
    {
        static int toplam = 0;
        static int sure = 111;
        Random rnd = new Random();
        public frmOyunn()
        {
            InitializeComponent();
            
            Image panel = new Bitmap(@"C:\Users\Arda Işıktaş\Desktop\Dersler\Nesne Tabanlı Programlama\ders2\ders2\Resources\panel2.jpg");
            pnlGosterge.BackgroundImage = panel;

        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            
            Button btn = new Button();
            Image hedef= new Bitmap(@"C:\Users\Arda Işıktaş\Desktop\Dersler\Nesne Tabanlı Programlama\ders2\ders2\Resources\hedef.jpg");
            btn.BackgroundImage = hedef;
            Image arkaplan = new Bitmap(@"C:\Users\Arda Işıktaş\Desktop\Dersler\Nesne Tabanlı Programlama\ders2\ders2\Resources\arkaplan3.jpg");
            this.BackgroundImage = arkaplan;
            btn.Size = new Size(50, 73);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlGosterge.Width - btn.Width) , rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(250).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblScore.Text = $"Skorunuz: {toplam}";
            btn.Dispose();

        }

        private void frmOyunn_Load(object sender, EventArgs e)
        {
             
            
        }
        
        private static void FSkayit(string kayit)
        {


            FileStream fs = new FileStream("logkayit", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(DateTime.Now + " ");
            sw.Write(kayit + "\n");
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

                result = MessageBox.Show($"Oyununuz bitmiştir. \n{lblScore.Text}\n" +
                "Tekrar oynamak için tıklayınız..", "ÇIKIŞ", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    MessageBox.Show("Tekrar bekleriz", "Reflex Oyunu");
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
           //btnBaslat.BackColor = Color.Black;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            tmrButton.Stop();
            tmrSure.Stop();
            lblSure.Text = "0";
            DialogResult result = new DialogResult();

            result = MessageBox.Show($"Oyununuz bitmiştir. \n{lblScore.Text}\n" +
            "Tekrar oynamak için tıklayınız..", "ÇIKIŞ", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Tekrar bekleriz", "Reflex Oyunu");
                Application.Exit();
            }
            else
            {
                Application.Restart();

            }

        }
    }
}