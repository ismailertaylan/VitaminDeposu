using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaminDeposu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int saniye = 60; //süre için başlangıç saniyesi
        static int suankimeyve=0; //ekrana gelen meyvenin numarası (1-2-3-4-5-6) olabiliyor
        static double toplamagirlik = 0; //sıkacaklarla sıkılan meyvelerin sıkılmış ağırlığının toplamı
        static double toplamvitA = 0; //meyvelerden çıkan A vitamininin toplamı
        static double toplamvitC = 0; //meyvelerden çıkan C vitamininin toplamı
        static double suankiagirlik = 0; //ekranda sıkılan meyvenin sıkılmış ağırlığı
        static double suankivitA = 0; //ekrandaki meyveden çıkan A vitamini
        static double suankivitC = 0; //ekrandaki meyveden çıkan C vitamini
        private void button1_Click(object sender, EventArgs e) //BAŞLA BUTONU
        {
            timer1.Start(); //süre başlar
            button1.Hide(); //buton kaybolur 
            butNarenciye.Visible = true; //sıkacak butonları gelir
            butKatiMeyve.Visible = true;
            panel1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;  //skorlar gelir
            lblTopGr.Visible = true;
            lblvitA.Visible = true;
            lblvitC.Visible = true;
            randomMeyve(); //ilk meyve ekrana gelsin
        }
        public void randomMeyve()
        {
            meyveleriGizle(); //önce varsa ekrandaki tüm meyveler gitsin
            Random r = new Random();
            int inputagirlik = r.Next(51) + 70; //70-120 arasında rastgele bi ağırlık gelsin
            int secim = r.Next(6) + 1; //1-2-3-4-5-6 rastgele bir meyve seçilsin
            suankimeyve = secim;
            switch (secim)
            {
                case 1: 
                    Armut armut = new Armut(inputagirlik); //1 gelirse rastgele bir armut oluşsun ve ilk ham ağırlığı gitsin.
                    picArmut.Visible = true; //armut resmi ekrana gelsin
                    suankiagirlik = armut.Sonagirlik; //armutun son ağırlığı şuanki ağırlığa atansın.
                    suankivitA = armut.VitaminA; //armuttaki A vitamini şuanki A vitaminine atansın
                    suankivitC = armut.VitaminC; //armuttaki C vitamini şuanki C vitaminine atansın
                    break;
                case 2:
                    Cilek cilek = new Cilek(inputagirlik);
                    picCilek.Visible = true;
                    suankiagirlik = cilek.Sonagirlik;
                    suankivitA = cilek.VitaminA;
                    suankivitC = cilek.VitaminC;
                    break;
                case 3:
                    Elma elma = new Elma(inputagirlik);
                    picElma.Visible = true;
                    suankiagirlik = elma.Sonagirlik;
                    suankivitA = elma.VitaminA;
                    suankivitC = elma.VitaminC;
                    break;
                case 4:
                    Greyfurt greyfurt = new Greyfurt(inputagirlik);
                    picGreyfurt.Visible = true;
                    suankiagirlik = greyfurt.Sonagirlik;
                    suankivitA = greyfurt.VitaminA;
                    suankivitC = greyfurt.VitaminC;
                    break;
                case 5:
                    Mandalina mandalina = new Mandalina(inputagirlik);
                    picMandalina.Visible = true;
                    suankiagirlik = mandalina.Sonagirlik;
                    suankivitA = mandalina.VitaminA;
                    suankivitC = mandalina.VitaminC;
                    break;
                case 6:
                    Portakal portakal = new Portakal(inputagirlik);
                    picPortakal.Visible = true;
                    suankiagirlik = portakal.Sonagirlik;
                    suankivitA = portakal.VitaminA;
                    suankivitC = portakal.VitaminC;
                    break;
            }
        }
        private void meyveleriGizle()
        { //TÜM MEYVELER EKRANDAN KAYBOLSUN
            picArmut.Visible = false;
            picCilek.Visible = false;
            picElma.Visible = false;
            picGreyfurt.Visible = false;
            picMandalina.Visible = false;
            picPortakal.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; //1000 ms 1sn olduğu için saniye bazında sayan sayaç
            saniye = saniye - 1;
            lblSaniye.Text = saniye.ToString(); //ekrandaki saniyenin güncellenmesi
            if (saniye == 0)
            { //süre bitince sayaç durur, ekrandaki süre kaybolur, sıkacak butonları kaybolur, game over yazısı gelir, meyveler kaybolur.
                timer1.Stop(); 
                lblSaniye.Visible = false;
                butKatiMeyve.Visible = false;
                butNarenciye.Visible = false;
                gameover.Visible = true;
                meyveleriGizle();
            }
        }

        private void butNarenciye_Click(object sender, EventArgs e)
        {
            //eğer ekrandaki meyve narenciyeyse(4-5-6) 
            if ((suankimeyve == 4) || (suankimeyve == 5) || (suankimeyve == 6))
            {
                toplamagirlik += suankiagirlik; //toplam ağırlığa ekrandaki meyvenin ağırlığı eklensin
                toplamvitA += suankivitA; //toplam A vit miktarına ekrandaki meyvenin A vit miktarı eklensin
                toplamvitC += suankivitC; //toplam C vit miktarına ekrandaki meyvenin C vit miktarı eklensin
                lblTopGr.Text = Math.Round(toplamagirlik, 2).ToString(); //ekrandaki değerler güncellensin
                lblvitA.Text = Math.Round(toplamvitA, 2).ToString(); //değerler 14.23 gibi 2 ondalıklı olarak görünsün
                lblvitC.Text = Math.Round(toplamvitC, 2).ToString();
                randomMeyve(); //doğru butona tıklandığı için sıradaki meyveye geçilsin.
            }
        }

        private void butKatiMeyve_Click(object sender, EventArgs e)
        {
            //eğer ekrandaki meyve katı meyveyse (1-2-3)
            if ((suankimeyve == 1) || (suankimeyve == 2) || (suankimeyve == 3))   
            {
                toplamagirlik += suankiagirlik;
                toplamvitA += suankivitA;
                toplamvitC += suankivitC;
                lblTopGr.Text = Math.Round(toplamagirlik,2).ToString();
                lblvitA.Text = Math.Round(toplamvitA,2).ToString();
                lblvitC.Text = Math.Round(toplamvitC,2).ToString();
                randomMeyve();
            }
           
        }
    }
    public class Meyve
    {
        //en parent class, tüm meyvelerde bulunan özellikler private olarak tanımlandı
        //hepsinin encapsulation (get-set) prensibine uygun olması sağlandı
        private int ilkagirlik;
        private double sonagirlik;
        private int verim;
        private double vitaminA;
        private double vitaminC;
        private bool sıkılabilir;
        public double VitaminA
        {
            get
            {
                return vitaminA;
            }
            set
            {
                vitaminA = value;
            }

        }
        public double VitaminC
        {
            get
            {
                return vitaminC;
            }
            set
            {
                vitaminC = value;
            }

        }
        public int IlkAgirlik
        {
            get
            {
                return ilkagirlik;
            }
            set
            {
                ilkagirlik = value;
            }

        }
        public bool Sıkılabilir
        {
            get
            {
                return sıkılabilir;
            }
            set
            {
                sıkılabilir = value;
            }

        }
        public double Sonagirlik
        {
            get
            {
                return sonagirlik;
            }
            set
            {
                sonagirlik = value;
            }

        }
        public int Verim
        {
            get
            {
                return verim;
            }
            set
            {
                verim = value;
            }

        }
    }
    public interface Iislemler
    {
        void bunedir();
    }
    public class Narenciye :Meyve //narenciye Meyveden miras alır, Meyve parent - Narenciye Child class
    {
        static Random r = new Random();
        public Narenciye()
        {
            //30-70 aralığında rastgele bir verim yüzdesi oluşturuluyor.
            base.Sıkılabilir = true;
            base.Verim = r.Next(41) + 30;
        }
    }
    public class KatiMeyve : Meyve //katı meyve Meyveden miras alır, Meyve parent - KatiMeyyve Child class
    {
        static Random r = new Random();
        public KatiMeyve()
        {
            //80-95 aralığında rastgele bir verim yüzdesi oluşturuluyor.
            base.Sıkılabilir = false;
            base.Verim = r.Next(16) + 80; 
        }
    }
    public class Armut : KatiMeyve,Iislemler  //Armut KatiMeyveden miras alır, KatiMeyve parent - Armut Child class
    {
        public void bunedir()
        {
            Console.WriteLine("Bu bir Armut'tur");
        }
        public Armut()
        {
        }
        public Armut(int input)
        {
            //ham ağırlık ilk ağırlık olarak atanır, son ağırlık verimine göre hesaplanır
            //Vitamin A ve Vitamin C miktarları son ağırlığına göre ilgili meyvenin rastgele oranında belirlenir.
            base.IlkAgirlik = input;
            base.Sonagirlik = base.IlkAgirlik * (base.Verim / 100.0);
            base.VitaminA = Sonagirlik * (25.0 / 100.0);
            base.VitaminC = Sonagirlik * (5.0 / 100.0);
        }
    }
    public class Cilek : KatiMeyve //Cilek KatiMeyveden miras alır, KatiMeyve parent - Cilek Child class
    {
        public Cilek(int input)
        {
            base.IlkAgirlik = input;
            base.Sonagirlik = base.IlkAgirlik * (base.Verim / 100.0);
            base.VitaminA = Sonagirlik * (12.0 / 100.0);
            base.VitaminC = Sonagirlik * (60.0 / 100.0);
        }
    }
    public class Elma : KatiMeyve //Elma KatiMeyveden miras alır, KatiMeyve parent - Elma Child class
    {
        public Elma(int input)
        {
            base.IlkAgirlik = input;
            base.Sonagirlik = base.IlkAgirlik * (base.Verim / 100.0);
            base.VitaminA = Sonagirlik * (54.0 / 100.0);
            base.VitaminC = Sonagirlik * (5.0 / 100.0);
        }
    }
    public class Greyfurt : Narenciye //Greyfurt Narenciyeden miras alır, Narenciye parent - Greyfurt Child class
    {
        public Greyfurt(int input)
        {
            base.IlkAgirlik = input;
            base.Sonagirlik = base.IlkAgirlik * (base.Verim / 100.0);
            base.VitaminA = Sonagirlik * (3.0 / 100.0);
            base.VitaminC = Sonagirlik * (44.0 / 100.0);
        }
    }
    public class Mandalina : Narenciye //Mandalina Narenciyeden miras alır, Narenciye parent - Mandalina Child class
    {
        public Mandalina(int input)
        {
            base.IlkAgirlik = input;
            base.Sonagirlik = base.IlkAgirlik * (base.Verim / 100.0);
            base.VitaminA = Sonagirlik * (681.0 / 100.0);
            base.VitaminC = Sonagirlik * (26.0 / 100.0);
        }
    }
    public class Portakal : Narenciye //Portakal Narenciyeden miras alır, Narenciye parent - Portakal Child class
    {
        public Portakal(int input)
        {
            base.IlkAgirlik = input;
            base.Sonagirlik = base.IlkAgirlik * (base.Verim / 100.0);
            base.VitaminA = Sonagirlik * (225.0 / 100.0);
            base.VitaminC = Sonagirlik * (45.0 / 100.0);
        }
    }
}
