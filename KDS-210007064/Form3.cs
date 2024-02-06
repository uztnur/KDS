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
    public partial class Form3 : Form
    {
        //NOVACO ÖFKE ÖLÇEĞİ

        public Form3()
        {
            InitializeComponent();
            this.Load += Form3_Load;
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
                textSoru.Text = "1-Yeni aldığınız bir aleti açıyorsunuz,fişe takıyorsunuz ve çalışmadığını fark ediyorsunuz .------ ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";
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

                if (toplamı >= 0 && toplamı <= 45)
                {
                    textSoru.Text = "yaşadığınız öfke ve rahatsızlık miktarı oldukça az. nüfusun ancak küçük bir yüzdesi testte bu kadar az puan alacaktır. seçilmiş azınlıktan birisiniz.";
                }
                else if (toplamı >= 46 && toplamı <= 55)
                {
                    textSoru.Text = "ortalama insandan daha huzurlu ve barışçılsınız.";
                }
                else if (toplamı >= 56 && toplamı <= 75)
                {
                    textSoru.Text = "yaşamın getirdiği sıkıntılara ortalama bir öfkeyle yanıt veriyorsunuz.";
                }
                else if (toplamı >= 76 && toplamı <= 85)
                {
                    textSoru.Text = "yaşamın getirdiği sıkıntılara öfkeli bir şekillde tepki veriyorsunuz. sıklıkla, ortalama birinden daha sinirlisiniz.";
                    MessageBox.Show("Acil bir uzmandan yardıma başvurmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (toplamı >= 86 && toplamı <= 100)
                {
                    textSoru.Text = "gerçek bir öfke şampiyonusunuz. kendinizi kolayca kurtaramadığınız yoğun duygularla istila edilmiş durumdasınız. büyük olasılıkla, sizi inciten olaydan çok sonra bile olumsuz duygularla savaşıyorsunuz. tanıdığınız insanlar arasında bir \"delifişek\" olarak biliniyor olabilirsiniz. çok sık, baş ağrıları ve yüksek tansiyon gibi sorunlar yaşayabilirsiniz. öfkeniz kontrolden çıkabilir ve zaman zaman başınızı derde sokacak dürtüsel saldırgan patlamalara yol açabilir. yetişkin nüfusun sadece küçük bir yüzdesi sizin kadar yoğun tepki verir.";
                    MessageBox.Show("Acil bir uzmandan yardıma başvurmalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
          

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnİleri.Visible = true;

            //this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Form boyutunu sabitleyin
            this.MinimumSize = new Size(1000, 715); // Minimum boyut ayarı
            this.MaximumSize = new Size(1000, 715);

        }
        private void btnİleri_Click(object sender, EventArgs e)
        {
            soru++;
            if (soru == 2)
            {
                textSoru.Text = "2- Bir tamirci sizden çok fazla para istiyor.------";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "3- Diğerlerinin yaptıkları fark edilmezken,bir tek sizin hatalarınız göze batıyor.-----";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "4- Arabanız çamura ya da kara saplanıyor.-------";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";
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
                textSoru.Text = "5- Birileriyle konuşuyorsunuz ve size yanıt vermiyor.-----";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "6- Birileri kendilerini farklı göstermeye çalışıyor.-----";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "7- Kafeteryadaki masanıza dört fincan kahve taşımaya çabalarken, biri size çarpıyor ve kahveler dökülüyor.---- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";


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
                textSoru.Text = "8- Giysilerinizi astınız; fakat,geçenler onları yere düşürüyor ve kaldırmıyor.---- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "9- Mağazaya girdiğiniz andan itibaren bir satıcı tarafından izleniyorsunuz.---";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";


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
                textSoru.Text = "10- Biriyle bir yerlere gitmek için randevulaştınız. Bu kişi son dakikada vazgeçiyor ve sizi ortada bırakıyor.---";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "11- Size şaka yapılıyor ya da sizinle alay ediliyor.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "12- Trafik ışığında arabanız stop ediyor.----";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "13- Park yerinde yanlışlıkla hatalı bir dönüş yapıyorsunuz. Arabanızdan çıktığınızda birileri size ‘’Araba kullanmayı nerede öğrendin ?’’diye bağırmaya başlıyor.-----";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "14- Biri bir hata yapıyor ve suçu üzerinize atıyor.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "15- Konsantre olmaya çalışıyorsunuz; fakat, yanınızdaki bir kişi ayaklarını yere vuruyor.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "16- Birine önemli bir kitap ya da bir alet ödünç verdiniz; fakat, geri vermedi.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "17- Çok yoğun bir gün geçirdiniz, ve birlikte yaşadığınız kişi önceden anlaştığınız bir şeyi yapmayı unuttuğunuz için şikayet etmeye başlıyor.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "18- Arkadaşlarınızla ya da sevgilinizle önemli bir şeyi tartışmaya çalışıyorsunuz; fakat, o kişi sizi dinlemiyor.---- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "19- O konu hakkında çok az fikri olmasına rağmen, ısrar eden kişilerle tartışıyorsunuz.---- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "20- Biri,sizle başka biri arasındaki tartışmaya burnunu sokuyor.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";
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
                textSoru.Text = "21- Acele olarak bir yere yetişmelisiniz; fakat, önünüzdeki araç 90 km hızla gidilecek yolda 30 km hızla gidiyor ve onu geçemiyorsunuz.-----";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";
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
                textSoru.Text = "22- Bir sakızın üstüne bastınız.------ ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "23- Yanlarından geçerken bir grup insan sizinle alay ediyor.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "24- Bir yere yetişme telaşıyla, iyi bir pantolonu sivri bir yere takarak yırtıyorsunuz.----- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
                textSoru.Text = "25- Son jetonunuzu bir telefon konuşması yapmak için kullanıyorsunuz; fakat,daha çevirmeniz bitmeden hat kopuyor ve jeton boşa gidiyor.---- ";
                btnA.Text = "Hiç rahatsızlık hissetmezsiniz.";
                btnB.Text = "Biraz huzursuzluk hissedersiniz.";
                btnC.Text = "Orta derecede sinirli hissedersiniz.";
                btnD.Text = "Oldukça kızgın hissedersiniz.";
                btnE.Text = "Çok kızgın hissedersiniz.";

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
        //private void btnA_Click(object sender, EventArgs e)
        //{
        //    toplamı = toplamı + 0;
        //    btnB.Enabled = false;
        //    btnC.Enabled = false;
        //    btnD.Enabled = false;
        //    btnE.Enabled = false;

        //}

        //private void btnB_Click(object sender, EventArgs e)
        //{
        //    toplamı = toplamı + 1;
        //    btnA.Enabled = false;
        //    btnC.Enabled = false;
        //    btnD.Enabled = false;
        //    btnE.Enabled = false;

        //}

        //private void btnC_Click(object sender, EventArgs e)
        //{
        //    toplamı = toplamı + 2;
        //    btnB.Enabled = false;
        //    btnA.Enabled = false;
        //    btnD.Enabled = false;
        //    btnE.Enabled = false;

        //}

        //private void btnD_Click(object sender, EventArgs e)
        //{
        //    toplamı = toplamı + 3;
        //    btnB.Enabled = false;
        //    btnC.Enabled = false;
        //    btnA.Enabled = false;
        //    btnE.Enabled = false;

        //}

        //private void btnE_Click(object sender, EventArgs e)
        //{
        //    toplamı = toplamı + 4;
        //    btnB.Enabled = false;
        //    btnC.Enabled = false;
        //    btnD.Enabled = false;
        //    btnA.Enabled = false;

        //}


    }
}
 