using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psikoloji_Analiz_Testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;

        }





        private void Form1_Load(object sender, EventArgs e)
        {
           


            this.BackgroundImage = Image.FromFile("C:\\Users\\zelih\\OneDrive\\Masaüstü\\Yeni klasör (2)\\Psikoloji-Analiz-Testi-Bir-Gunde-Bir-Proje--32\\Resources\\Ekran görüntüsü 2024-01-19 191610.png"
               );
            this.BackgroundImageLayout = ImageLayout.Stretch; // İstediğiniz boyuta uyacak şekilde resmi germe
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Form boyutunu sabitleyin
            this.MinimumSize = new Size(1000, 715); // Minimum boyut ayarı
            this.MaximumSize = new Size(1000, 715);


        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(197)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(6)))), ((int)(((byte)(109)))));
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }



    }
}


