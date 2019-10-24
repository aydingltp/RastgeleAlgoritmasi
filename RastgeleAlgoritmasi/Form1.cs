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

namespace RastgeleAlgoritmasi
{
    public partial class Form1 : Form
    {
        int rastgeleadimtimer = 0;
        public Form1()
        {
            InitializeComponent();
        }


        int saat = 0, dakika = 0, saniye = 0, sayac = 0;

        public string RastgeleKelime()
        {
            string kelime = "";
            var rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                kelime += ((char)rnd.Next('A', 'Z')).ToString();
            }
            return kelime;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            sure.Enabled = true;
            rastgeletimer.Enabled = true;
        }

        private void rastgeletimer_Tick(object sender, EventArgs e)
        {
            string gelendeger = RastgeleKelime();
            rastgeleadimtimer++;
            if (rastgeleadimtimer == 1000)
            {
                gelendeger = "TESADUF";
            }

            if (gelendeger == "TESADUF")
            {
                sure.Enabled = false;
                rastgeletimer.Enabled = false;
                lblSonuc.Text = "TESADUF KELİMESİ BULUNDU!";
            }
            lblDeger.Text = gelendeger;
            sayac++;
            lblSayac.Text = sayac.ToString();
            dosyayaYaz(sayac,gelendeger);
        }

        private static void dosyayaYaz(int sayac,string gelendeger)
        {
            //string dosya_yolu = @"D:\RASTGELE.txt";
            ////İşlem yapacağımız dosyanın yolunu belirtiyoruz.
            //FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            ////Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            ////2.parametre dosya varsa açılacağını yoksa oluşturulacağını belirtir,
            ////3.parametre dosyaya erişimin veri yazmak için olacağını gösterir.
            //StreamWriter sw = new StreamWriter(fs);
            ////Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            //sw.WriteLine("{0}. Deneme = > {1}",sayac,gelendeger);
            ////Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            //sw.Flush();
            //////Veriyi tampon bölgeden dosyaya aktardık.
            //sw.Close();
            ////fs.Close();
            ////İşimiz bitince kullandığımız nesneleri iade ettik.
            ///
            string fileName = @"D:\Logs.txt";

            string writeText = sayac + ". Deneme  = >  " + gelendeger;

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(fileName, Environment.NewLine + writeText);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = ((Convert.ToString(saat) + " : ") + (Convert.ToString(dakika) + " : ") + Convert.ToString(saniye));

            if ((saniye == 59))
            {
                saniye = 0;
                dakika = dakika + 1;
                if (dakika == 60)
                {
                    saniye = 0;
                    dakika = 0;
                    saat = saat + 1;
                }
            }
            saniye = saniye + 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            sure.Enabled = false;
            rastgeletimer.Enabled = false;
        }
    }
}
