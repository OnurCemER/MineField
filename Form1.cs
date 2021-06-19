using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _163301059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int sure; //Kontrol kolaylığı açısından varsayılan 15 saniye olarak belirlendi. Max. değer 30sn.
        public Random rnd;
        public Button btn;
        public izlemeEkrani izle;
        public int[] mayinlar;
        public string[] mayinliKomsu;
        public int tikSay;
                
        private void Form1_Load(object sender, EventArgs e)
        {
            btnMayinBasla.Tag = true;
        }

        private void btnMayinBasla_Click(object sender, EventArgs e)
        {
            //Oyuna Başlama Butonu
            if ((bool)btnMayinBasla.Tag)
            {
                OyunaBasla();
            }
            else if ((bool)btnMayinBasla.Tag == false)
            {
                timerSure.Stop();
                YenidenBasla("Oyuna Yeniden Başlamak İstiyor Musunuz?");
            }
        }
        
        private void btn_Click(object sender, EventArgs e)
        {
            //Mayın Tarlasındaki Butonların Tıklanma Olayları
            MayinTarama(sender,flowLayoutPanel1);
            int name = Convert.ToInt16(((Button)sender).Name);
            ((Button)sender).Text=MayinliKomsu(name).ToString();
        }

        private void timerSure_Tick(object sender, EventArgs e)
        {
            if (sure >= 1)
            {
                sure--;
                lblSure.Text = "Kalan Süre = " + sure.ToString();
            }
            else
            {
                OyunBitti();
            }

        }
        
        public void Olustur(int satir, int sutun , int mayin) 
        {
            //Mayın Tarlasının ve Mayınların Oluşturulduğu Kodlar.
            rnd = new Random();
            izle = new izlemeEkrani();
            mayinlar = new int[mayin];
            izle.dizi = new int[mayin];
            for (int i = 0; i < mayinlar.Length; i++)
            {
                int secilenMayin = rnd.Next(0,satir*sutun);
                if (mayinlar.Contains(secilenMayin))
                {
                    i--;
                }
                else {
                    mayinlar[i] = secilenMayin;
                    izle.dizi[i] = secilenMayin;
                }
            }
        }
        
        public void ButonDoldur(int satir, int sutun, FlowLayoutPanel flp,int[] mayinlar) 
        {
            //Mayın Tarlasındaki Butonların Oluşturulduğu ve FlowLayoutPanele Dizildiği Kodlar.
            mayinliKomsu = new string[satir*sutun];
            flp.Controls.Clear();
            for (int i = 0; i < satir * sutun; i++)
            {
                btn = new Button();
                btn.Name = i.ToString();
                btn.Height = 40;
                btn.Width = 45;
                btn.BackColor = Color.Gray;
                if (mayinlar.Contains(i))
                {
                    btn.Tag = true;
                }
                else
                {
                    btn.Tag = false;
                }

                btn.Click += btn_Click;
                flp.Controls.Add(btn);
            }
        }

        public void MayinTarama(Object sender, FlowLayoutPanel flp)
        {
            //Mayın dizilerinin doldurulduğu kodlar.
            Button secili = (Button)sender;
            
            if ((bool)secili.Tag)
            {
                foreach (Control item in flp.Controls)
                {
                    if ((bool)item.Tag == true)
                    {
                        item.BackColor = Color.Red;
                        timerSure.Stop();
                    }
                    else
                    {
                        item.BackColor = Color.Green;
                    }
                    
                }
                OyunBitti();
            }
            else
            {
                secili.BackColor = Color.Green;
                sure = (int)numericSure.Value + 1;
                tikSay += 1;
                if (tikSay>=(flowLayoutPanel1.Controls.Count-(mayinlar.Length)))
                {
                    timerSure.Stop();
                    YenidenBasla("Tebrikler Tüm Mayınları Buldunuz. Yeniden Başlamak İster Misiniz?");
                }
            }
            
        }

        public void OyunaBasla() 
        {
            //Oyunu başlatma esnasında gereken kodlar
            Olustur(5, 5, (int)numericMayin.Value);
            ButonDoldur(5, 5, flowLayoutPanel1,mayinlar);
            timerSure.Start();
            sure = (int)numericSure.Value + 1;
            btnMayinBasla.Tag = false;
            izle.Show();
        }

        private void OyunBitti()
        {
            //Oyun bittiğinde yapılacak işlemler
            btnMayinBasla.Tag = true;
            timerSure.Stop();
            YenidenBasla("Oyun Bitti. Oyuna Yeniden Başlamak İstiyor Musunuz?");
        }

        private void YenidenBasla(string metin) 
        {
            //Oyunu Yeniden Başlatmak için gereken kodlar.
             var res = MessageBox.Show(metin, "Yeniden Başlat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             tikSay = 0;
             if (res == DialogResult.Yes)
             {
                 btnMayinBasla.Tag = true;
                 izle.Close();
                 OyunaBasla();
             }
             else if (res == DialogResult.No)
             {
                 this.Close();
             }
        }

        private int KomsuArama(int btnName) 
        {
         
             /*
             Sol veya sağ köşedeki butonların isimlerinin mod5'ine göre 
             * hangi komşuluklarına bakılacağına karar veren metot
             */

            int mayinSay = 0;
            if (mayinlar.Contains(btnName - 5)) { mayinSay++; }
            if (btnName%5!=4)
            {
                if (mayinlar.Contains(btnName - 4)) { mayinSay++; }
                if (mayinlar.Contains(btnName + 1)) { mayinSay++; }
                if (mayinlar.Contains(btnName + 6)) { mayinSay++; }
            }
            if (btnName % 5 != 0)
            {
                if (mayinlar.Contains(btnName - 1)) { mayinSay++; }
                if (mayinlar.Contains(btnName - 6)) { mayinSay++; }
                if (mayinlar.Contains(btnName + 4)) { mayinSay++; }
            }
            if (mayinlar.Contains(btnName + 5)) { mayinSay++; }
            return mayinSay;
        }

        private int MayinliKomsu(int btnName) 
        {
            int deger = KomsuArama(btnName);
            return deger;
        }


        /**********************-Armstrong Ödevi Kodları-**********************************/

        public void ArmstrongSayi(int alt, int ust)
        {
            int altSinir = alt;
            int ustSinir = ust;

            for (int i = altSinir; i < ustSinir; i++)
            {
                int yuzlerBas = i / 100;
                int onlarBas = (i - yuzlerBas * 100) / 10;
                int birlerBas = (i - yuzlerBas * 100 - onlarBas * 10);
                int sonuc = Convert.ToInt32(Math.Pow(yuzlerBas, 3) + Math.Pow(onlarBas, 3) + Math.Pow(birlerBas, 3));
                

                if (i == sonuc)
                    listBox.Items.Add(sonuc);
            }
            if (listBox.Items.Count < 1) { MessageBox.Show("Belirtilen Aralıkta Hiç Sayı Bulunamadı."); }
        }

        private void btnArmstrongBul_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            if (string.IsNullOrWhiteSpace(txtAltSinir.Text) || string.IsNullOrWhiteSpace(txtUstSinir.Text))
            {
                MessageBox.Show("Kutucuklar Doldurulmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int altSinir = int.Parse(txtAltSinir.Text);
                int ustSinir = int.Parse(txtUstSinir.Text);
                ArmstrongSayi(altSinir, ustSinir);
            }
        }

        private void txtAltSinir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                MessageBox.Show("Yalnızca Rakam Girişi Yapınız!");
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
