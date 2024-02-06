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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Load += Form4_Load;
        }
        int soru;
        int toplamı = 0;
        private void Form4_Load(object sender, EventArgs e)
        {
            btnİleri.Visible = true;


            // Form boyutunu sabitleyin
            this.MinimumSize = new Size(1000, 715); // Minimum boyut ayarı
            this.MaximumSize = new Size(1000, 715);
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnİleri.Visible = true;
            btnBasla.Enabled = true;

            btnBasla.Text = "BİTİR";
            soru++;
            if (soru == 1)
            {
                textSoru.Text = "1-Sevdiğim insanların öleceğine veya beni terk edeceğine dair çok fazla endişe duyarım.  ";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;


            }
            if (soru == 10)
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
                    textSoru.Text = "Çok düşük: Bu şema muhtemelen sizin için geçerli değildir.";
                }
                else if (toplamı >= 46 && toplamı <= 55)
                {
                    textSoru.Text = " Düşük: Bu şema sizin için arada sırada geçerlidir.";
                }
                else if (toplamı >= 56 && toplamı <= 75)
                {
                    textSoru.Text = "Orta: Bu şema sizin hayatınızda bir sorundur.";
                }
                else if (toplamı >= 76 && toplamı <= 85)
                {
                    textSoru.Text = "Yüksek: Bu kesinlikle sizin için önemli bir şemadır.";
                    MessageBox.Show("Bu konuda destek almalısınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (toplamı >= 86 && toplamı <= 100)
                {
                    textSoru.Text = " Çok yüksek: Bu kesinlikle sizin temel şemalarınızdan bir tanesidir.";
                    MessageBox.Show("Bu konuda destek almalısınız!" +
                        "Aksi takdirde aşağıdaki durumlarla karşı karşıya kalabilirsiniz:Reddedilme veya terk edilme korkusu: İlişki istikrarlı ve sorunsuz olsa da sürekli endişeli hisseder veya başkalarının onu terk etmesini veya reddetmesini bekler.\r\nDüşük özgüven: Sevgiyi, ilgiyi veya bakımı hak etmediğini düşünür. Kendini değersiz, yetersiz veya terk edilmeye layık hisseder.\r\nOnay arama: Terk edilme korkusunu hafifletmek için sürekli olarak başkalarından güvence, ilgi veya onay arar.\r\nSağlıklı ilişkiler kurmada yaşanan problemler: Bazı bireyler kendilerini terk edilmekten korumak için ilişkiden kaçınma davranışları sergileyebilirken, diğerleri aşırı derecede bağımlı hale gelebilir.\r\nDuygusal güvenlik hissini zedeler:  Başkalarına güvenmekte zorluk yaşar ve hayal kırıklığına uğramaktan çok korkar.\r\nİlişkilerde kaygı: Terk edilme şeması ilişkilerde yaşanan kaygının temel nedenidir. Sakin ve tutarlı bir ilişkiye sahip olmak zorlaşır. İlişki içinde olmak bir felaketin yaklaşmakta olduğu hissini beraberinde getirir. \r\nArkadaşlık ilişkileri: Terk edilme şemasının etkileri genelllikle romantik ilişkilerde kendini gösterse de arkadaşlık ilişkilerini de etkileyebilir. ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
              
            }


        }


        private void btnİleri_Click(object sender, EventArgs e)
        {
            soru++;
            if (soru == 2)
            {
                textSoru.Text = "2- İnsanların beni terk edeceğinden korktuğum için insanlara yapışırım. Sağlam bir desteğim yok.";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";

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
                textSoru.Text = "3- Durmadan bana bağlı kalmayacak insanlara aşık oluyorum.";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";

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
                textSoru.Text = "4- İnsanlar hayatıma girip çıkıyorlar.";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";
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
                textSoru.Text = "5- Sevdiğim biri uzaklaştığı zaman umutsuzluğa kapılıyorum.";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";

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
                textSoru.Text = "6- Sevgililerimin  beni terk edeceği fikrine o kadar takılmış durumdayım ki, onları uzaklaştırıyorum.";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";

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
                textSoru.Text = "7- Bana en yakın olan insanların sağı solu belli olmaz. Bir an benim yanımdadırlar ama sonra bir an yok olurlar. ";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";

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
                textSoru.Text = "8-Başka insanlara çok fazla ihtiyaç duyarım. ";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";

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
                textSoru.Text = "9- Sonunda yalnız kalacağım.";
                btnA.Text = "Hiç doğru değil";
                btnB.Text = "Kısmen doğru";
                btnC.Text = "Biraz doğru";
                btnD.Text = "Genellikle doğru";
                btnE.Text = "Kesinlikle doğru";

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
