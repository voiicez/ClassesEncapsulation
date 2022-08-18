namespace ClassesEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri()
            {
                Adi = "Behlül",
                Soyadi = "Şahin",
                ErkekMi = true,
                KartNo = "1234 5678 9101 1213",
                DogumTarihi = new DateTime(1998,5,1)


            };
            Console.WriteLine("Adı: "+musteri.TamAdi+"\n"+"Cinsiyeti: "
                +musteri.Cinsiyet+"\n"+"Kart No : "
                +musteri.KartNo+"\nDoğum Tarihi: "+musteri.DogumTarihi.ToShortDateString());
            musteri.AlisverisYap("iPhone 13");
            
        }
    }

    class Musteri
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string TamAdi => Adi + " " + Soyadi; //veya

        //public int TamAdi 
        //{
        //    get
        //    {
        //        return Adi + " " + Soyadi;
        //    }
        //        }

        public DateTime DogumTarihi { get; set; }

        public string _kartNo;
        public string KartNo 
        {
            get
            {
                //1234 5678 9101 1213
                //**** **** **** 1213
                string gizliKartNo ="**** **** **** "+ _kartNo.Substring(15);
                return gizliKartNo;
            }
            set
            {
                _kartNo = value;
            }
        }
        public bool ErkekMi { get; set; }
        public string Cinsiyet 
        {
            get
            {
                return ErkekMi ? "Erkek" : "Kadın";
            }
        }

        public void AlisverisYap(string urun)
        {
            Console.WriteLine(TamAdi+" "+KartNo+" "+" ile "+urun+" aldı.");
        }
    }
}