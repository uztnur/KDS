using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Psikoloji_Analiz_Testi
{
    //Author:ZELİHA NUR UZTİMÜR
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }
        int soru;
        int toplamı = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnİleri.Visible = true;
            btnBasla.Enabled = true;
           
            btnBasla.Text = "BİTİR";
            soru++;
            if (soru == 1)
            {
                textSoru.Text = "1- Üzüntülü ya da neşesiz hissetmek ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 26)
            {
                btnİleri.Visible = false;
                btnA.Text = "Skorunuz: " + toplamı.ToString();
                Font mevcutFont = btnA.Font;
                Font yeniFont = new Font(mevcutFont.FontFamily, 18, mevcutFont.Style);
                btnA.Font = yeniFont;
                btnB.Visible = false;
                btnC.Visible = false;
                btnD.Visible = false;
                btnE.Visible = false;

                if (toplamı >= 0 && toplamı <= 5)
                {
                    textSoru.Text = "Depresyon Yok.";
                }
                else if (toplamı >= 6 && toplamı <= 10)
                {
                    textSoru.Text = "Normal ama Mutsuz.";
                }
                else if (toplamı >= 11 && toplamı <= 25)
                {
                    textSoru.Text = "Hafif Depresyon.";
                }
                else if (toplamı >= 26 && toplamı <= 50)
                {
                    textSoru.Text = "Orta Depresyon.";
                }
                else if (toplamı >= 51 && toplamı <= 75)
                {
                    textSoru.Text = "Ağır Depresyon.";
                    MessageBox.Show("Acil bir uzmana başvurmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (toplamı >= 76 && toplamı <= 100)
                {
                    textSoru.Text = "Aşırı Depresyon.";
                    MessageBox.Show("Acil bir uzmana başvurmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Form5 fr = new Form5();
            //fr.toplamı = "Skorunuz: " + toplamı.ToString();
            //fr.ShowDialog();

        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            btnİleri.Visible = true;
          

            // Form boyutunu sabitleyin
            this.MinimumSize = new Size(1000, 715); // Minimum boyut ayarı
            this.MaximumSize = new Size(1000, 715);

        }
        private void btnİleri_Click(object sender, EventArgs e)
        {
            soru++;
            if (soru == 2)
            {
                textSoru.Text = "2- Mutsuz ya da umutsuz hissetmek";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 3)
            {
                textSoru.Text = "3- Ağlama nöbetleri ya da ağlamaklı hissetmek";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 4)
            {
                textSoru.Text = "4- Cesaretsiz hissetmek";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 5)
            {
                textSoru.Text = "5- Umutsuz hissetmek";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 6)
            {
                textSoru.Text = "6- Düşük özsaygı";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);


                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 7)
            {
                textSoru.Text = "7- Değersiz ya da yetersiz hissetmek ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";


                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 8)
            {
                textSoru.Text = "8- Suçluluk ya da utanç ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 9)
            {
                textSoru.Text = "9- Kendinizi eleştirmek ya da kendinizi suçlamak";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";


                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;

            }
            if (soru == 10)
            {
                textSoru.Text = "10- Karar vermede güçlük";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 11)
            {
                textSoru.Text = "11- Aile,arkadaşlar ve iş arkadaşlarına yönelik ilgi kaybı ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 12)
            {
                textSoru.Text = "12- Yalnızlık";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 13)
            {
                textSoru.Text = "13- Aile ya da arkadaşlarla daha az zaman geçirmek";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 14)
            {
                textSoru.Text = "14- Motivasyon eksikliği ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 15)
            {
                textSoru.Text = "15- İşyerinde ve diğer etkinliklerde ilgi kaybı ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 16)
            {
                textSoru.Text = "16- İş veya diğer etkinliklerden kaçınma ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 17)
            {
                textSoru.Text = "17- Yaşamdan zevk alma ve tatmin olmanın kaybı ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 18)
            {
                textSoru.Text = "18- Yorgun hissetmek ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 19)
            {
                textSoru.Text = "19- Uykuda dalmada güçlük ya da çok fazla uyumak ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 20)
            {
                textSoru.Text = "20- Azalmış ya da artmış iştah ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";
                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 21)
            {
                textSoru.Text = "21- Yaşama karşı istek kaybı";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";
                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 22)
            {
                textSoru.Text = "22- Sağlığınız hakkında endişelenmek ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 23)
            {
                textSoru.Text = "23- İntihar düşünceniz var mı ? ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }

            if (soru == 24)
            {
                textSoru.Text = "24- Yaşamınızı sona erdirmek ister misiniz ? ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2); 
                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;


                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;



            }
            if (soru == 25)
            {
                textSoru.Text = "25- Kendinize zarar vermek için bir planınız var mı ? ";
                btnA.Text = "Hiç";
                btnB.Text = "Biraz";
                btnC.Text = "Orta Derecede";
                btnD.Text = "Çok Fazla";
                btnE.Text = "Aşırı Derecede";

                btnA.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnB.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnC.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnD.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);
                btnE.BackColor = Color.FromArgb(0x5A, 0x8C, 0xF2);

                btnA.ForeColor = Color.White;
                btnB.ForeColor = Color.White;
                btnC.ForeColor = Color.White;
                btnD.ForeColor = Color.White;
                btnE.ForeColor = Color.White;
                btnİleri.Enabled = false;
                btnİleri.Visible = false;
                btnBasla.Enabled = true;

                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }

        }
        private void btnA_Click(object sender, EventArgs e)
        {
            toplamı = toplamı + 0;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            toplamı = toplamı + 1;
            btnA.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            toplamı = toplamı + 2;
            btnB.Enabled = false;
            btnA.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;

        }

        private void btnD_Click(object sender, EventArgs e)
        {
            toplamı = toplamı + 3;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnA.Enabled = false;
            btnE.Enabled = false;

        }

        private void btnE_Click(object sender, EventArgs e)
        {
            toplamı = toplamı + 4;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnA.Enabled = false;

        }

        
    }
}
