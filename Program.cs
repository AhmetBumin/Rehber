namespace TelefonRehberiUygulamasi;
class Program
{
    public static void Menu()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
        Console.WriteLine(""
            + "(1) Yeni Numara Kaydetmek \n"
            + "(2) Varolan Numarayı Silmek \n"
            + "(3) Varolan Numarayı Güncelleme \n"
            + "(4) Rehberi Listelemek \n"
            + "(5) Rehberde Arama Yapmak \n"
            + "(6) Çıkış");
    }
    static void Main(string[] args)
    {
        Aksiyon aksiyon = new Aksiyon();
        bool kontrol = true;
        do
        {
            Console.Clear();
            Menu();
            try
            {
                int cevap = Convert.ToInt32(Console.ReadLine());
                switch (cevap)
                {
                    case 1:
                        aksiyon.RehbereEkleme();
                        break;
                    case 2:
                        aksiyon.RehberdenSilme();
                        break;
                    case 3:
                        aksiyon.RehberGuncelleme();
                        break;
                    case 4:
                        aksiyon.RehberSiralama();
                        break;
                    case 5:
                        aksiyon.RehberdeArama();
                        break;
                    case 6:
                        Console.WriteLine("Programdan çıkış yapılıyor...");
                        kontrol = false;
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz seçim yaptınız lütfen tekrar seçiniz.. ");
            }
            System.Threading.Thread.Sleep(2000);
        } while (kontrol);
    }
}