using System;
using System.Collections;
using System.ComponentModel;
namespace TelefonRehberiUygulamasi
{
	public class Aksiyon
	{
		List<Kisiler> rehber = new List<Kisiler>();
		public Aksiyon()
		{
			rehber.Add(new Kisiler("kaan", "lokum", "123456"));
			rehber.Add(new Kisiler("batuhan", "sofu", "456789"));
			rehber.Add(new Kisiler("sofu", "bayram", "345678"));
			rehber.Add(new Kisiler("kaan", "kural", "678901"));
			rehber.Add(new Kisiler("korhan", "sezer", "234567"));
		}
		public void RehbereEkleme()
		{
			Console.Clear();
			Console.Write("Lüften eklemek istediğiniz kişinin adını giriniz: ");
			string isim = Console.ReadLine().ToLower();
			Console.Write("Lütfen eklemek istediğiniz kişinin soyismini giriniz: ");
			string soyIsim = Console.ReadLine().ToLower();
			Console.Write("Lütfen eklemek istediğiniz kişinin telefon numarasını giriniz: ");
			string telefonNo = Console.ReadLine().ToLower();

			Kisiler YeniKisi = new Kisiler(isim,soyIsim,telefonNo);
			rehber.Add(YeniKisi);
			Console.WriteLine("{0} {1} adlı kişi rehbere eklenmiştir. ",isim,soyIsim);
		}
		public void RehberdenSilme()
		{
			yanlissecim3:
			Console.Clear();
			Console.Write("Lütfen rehberden silmek istediğiniz kişinin adını veya soyadını giriniz: ");
			string SilinecekKisi = Console.ReadLine().ToLower();

			for (int i = 0; i < rehber.Count; i++)
			{
			yanlissecim:
				Console.Clear();
               		 	try
				{
                    if (rehber[i].Isim.Equals(SilinecekKisi) || rehber[i].SoyIsim.Equals(SilinecekKisi)) // rehberdeki isim veya soyisim kontrol edilir
                    {
                        Console.Write("{0} {1} kişiyi silmek istiyorsanız (1), silmek istemiyorsanız(2) ", rehber[i].Isim, rehber[i].SoyIsim);
                        int secim1 = Convert.ToInt16(Console.ReadLine());
                        if (secim1 == 1)
                        {
                            Console.WriteLine("{0} {1} rehberden silinmiştir.", rehber[i].Isim, rehber[i].SoyIsim);
                            rehber.RemoveAt(i);
                            break;
                        }
			else if (secim1==2)
			{
                            Console.WriteLine("Rehberde başka kişi kontrol ediliyor");
                            System.Threading.Thread.Sleep(2000);
                            continue;
                        }
                        else // 1 veya 2 hariç int değer seçilirse
                        {
                            Console.WriteLine("Yanlış tuşlama yaptınız lütfen seçim yapınız..");
                            System.Threading.Thread.Sleep(2000);
							goto yanlissecim;
                        }
                    }
                }
				catch (FormatException) // int değer hariç seçim yapılırsa
				{
                    Console.WriteLine("Geçersiz tuşlama yaptınız lütfen seçim yapınız..");
                    System.Threading.Thread.Sleep(2000);
					goto yanlissecim;
                }
				if (i==rehber.Count-1) // son eleman bile uyuşmuyorsa
				{
					Console.Clear();
					yanlissecim2:
					Console.Write("Aranan kişi rehberde bulunamamıştır. Silme işlemini sonlandırmak için (1), yeniden denemek için (2) seçin");
					try
					{
						int secim2 = Convert.ToInt16(Console.ReadLine());
						if (secim2==1)
						{
							Console.WriteLine("Silme işleminden çıkış yapılıyor");
							System.Threading.Thread.Sleep(2000);
							break;
						}
						else if (secim2==2)
						{
							goto yanlissecim3;//silme işlemine baştan başlar
						}
                        else //1 veya 2 hariç int değer seçilirse
                        {
							Console.WriteLine("Yanlış seçim yaptınız tekrar deneyiniz..");
                            System.Threading.Thread.Sleep(2000);
                            goto yanlissecim2;
						}
					}
					catch (FormatException)
					{
                        Console.WriteLine("Geçersiz seçim yaptınız tekrar deneyiniz..");
                        System.Threading.Thread.Sleep(2000);
						goto yanlissecim2;
                    }
				}
			}
		}
		public void RehberGuncelleme()
		{
			yanlissecim6:
			Console.Clear();
			Console.Write("Lütfen rehberde numarasını değiştirmek istediğiniz kişinin adını veya soyadını giriniz: ");
			string GuncellenecekKisi = Console.ReadLine().ToLower();
			for (int i = 0; i < rehber.Count; i++)
			{
				if (rehber[i].Isim.Equals(GuncellenecekKisi) || rehber[i].SoyIsim.Equals(GuncellenecekKisi))
				{
				yanlissecim4:
					Console.Clear();
                    Console.Write("{0} {1} kişinin numarasını değiştirmek istiyorsanız (1), değiştirmek istemiyorsanız(2) ", rehber[i].Isim, rehber[i].SoyIsim);
					try
					{
                        int secim1 = Convert.ToInt16(Console.ReadLine());
						if (secim1==1)
						{
							Console.Write("Güncel telefon numarasını giriniz: ");
							string GuncelTelefonNo = Console.ReadLine();
							rehber[i].TelefonNo = GuncelTelefonNo;
							Console.WriteLine("{0} {1} kişinin güncel telefon numarası: {2}", rehber[i].Isim, rehber[i].SoyIsim, rehber[i].TelefonNo);
							System.Threading.Thread.Sleep(2000);
							break;
						}
						else if (secim1==2)
						{
							Console.WriteLine("Rehberde başka kişi kontrol ediliyor");
							System.Threading.Thread.Sleep(2000);
							continue;
						}
                        else // 1 veya 2 hariç int değer seçilirse
                        {
                            Console.WriteLine("Yanlış seçim yaptınız, lütfen tekrar deneyiniz.");
                            goto yanlissecim4;
                        }
                    }
					catch (FormatException) // format hatası olursa
					{
						Console.WriteLine("Geçersiz seçim yaptınız, lütfen tekrar deneyiniz.");
						goto yanlissecim4;
					}
				}
				if (i==rehber.Count-1) // son eleman bile uyuşmuyorsa
				{
                yanlissecim5:
                    Console.Clear();
                    Console.Write("Aranan kişi rehberde bulunamamıştır. Güncelleme işlemini sonlandırmak için (1), yeniden denemek için (2) seçiniz: ");
					try
					{
						int secim2 = Convert.ToInt16(Console.ReadLine());
						if (secim2==1)
						{
							Console.WriteLine("Güncelleme işleminden çıkış yapılıyor...");
							System.Threading.Thread.Sleep(2000);
							break;
						}
						else if (secim2 == 2)
						{
							goto yanlissecim6; // güncelleme işlemine tekrar başlar
						}
						else // 1 veya 2 hariç int değer seçilirse
						{
                            Console.WriteLine("Yanlış seçim yaptınız, lütfen tekrar deneyiniz.");
                            System.Threading.Thread.Sleep(2000);
                            goto yanlissecim5;
                        }
					}
					catch (FormatException) // format hatası olursa
                    {
                        Console.WriteLine("Geçersiz seçim yaptınız, lütfen tekrar deneyiniz.");
						System.Threading.Thread.Sleep(2000);
                        goto yanlissecim5;
					}
                }
			}
		}
		public void RehberSiralama()
		{
			yanlissecim6:
			Console.Clear();
			Console.Write("A/Z ye sıralama için (1), Z/A sıralama için (2) ye basınız: ");
            try
			{
				int secim1 = Convert.ToInt16(Console.ReadLine());
				if (secim1==1)
				{
					rehber = rehber.OrderBy(x => x.Isim).ToList();
                    for (int i = 0; i < rehber.Count; i++)
					{
						Console.WriteLine(rehber[i].Isim +" "+ rehber[i].SoyIsim + " Telefon no: " + rehber[i].TelefonNo);
					}
					System.Threading.Thread.Sleep(2000);
                }
				else if(secim1==2)
				{
					rehber = rehber.OrderByDescending(x => x.Isim).ToList();
                    for (int i = 0; i < rehber.Count; i++)
                    {
                        Console.WriteLine(rehber[i].Isim + " " + rehber[i].SoyIsim + " Telefon no: " + rehber[i].TelefonNo);
                    }
                    System.Threading.Thread.Sleep(2000);
                }
				else
				{
                    Console.WriteLine("Yanlış seçim yaptınız, lütfen tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto yanlissecim6;
                }
			}
			catch (FormatException)
			{
                Console.WriteLine("Geçersiz seçim yaptınız, lütfen tekrar deneyiniz.");
                System.Threading.Thread.Sleep(2000);
                goto yanlissecim6;
            }
		}
		public void RehberdeArama()
		{
			yanlissecim7:
			Console.Clear();
			Console.Write("İsme göre arama için (1), soyisme göre arama için (2), telefon numarasına göre arama yapmak için (3) tuşlayınız: ");
			try
			{
				int secim = Convert.ToInt16(Console.ReadLine());
				if (secim==1)
				{
                    bool y = true;// rehberde öyle isim kayıtlı değilse
                    Console.Clear();
					Console.Write("Lütfen ismi giriniz: ");
					string isim = Console.ReadLine();
					for (int i = 0; i < rehber.Count; i++)
					{
						if (rehber[i].Isim==isim)
						{
							Console.WriteLine("Adı: {0}, Soyadı: {1} ve Telefon Numarası: {2}", rehber[i].Isim, rehber[i].SoyIsim, rehber[i].TelefonNo);
							y = false;
						}
					}
					if (y)
					{
						Console.WriteLine("Rehberde {0} isimli kişi kayıtlı değildir.",isim);
					}
					System.Threading.Thread.Sleep(2000);
				}
				else if (secim==2)
				{
                    bool y = true;// rehberde öyle soyisim kayıtlı değilse
                    Console.Clear();
                    Console.Write("Lütfen soyismi giriniz: ");
                    string soyisim = Console.ReadLine();
                    for (int i = 0; i < rehber.Count; i++)
                    {
                        if (rehber[i].SoyIsim == soyisim)
                        {
                            Console.WriteLine("Adı: {0}, Soyadı: {1} ve Telefon Numarası: {2}", rehber[i].Isim, rehber[i].SoyIsim, rehber[i].TelefonNo);
                            y = false;
                        }
                    }
                    if (y)
                    {
                        Console.WriteLine("Rehberde {0} isimli kişi kayıtlı değildir.", soyisim);
                    }
                    System.Threading.Thread.Sleep(2000);
                }
				else if (secim==3)
				{
                    bool y = true;// rehberde öyle numara kayıtlı değilse
                    Console.Clear();
                    Console.Write("Lütfen numarayı giriniz: ");
                    string numara = Console.ReadLine();
                    for (int i = 0; i < rehber.Count; i++)
                    {
                        if (rehber[i].TelefonNo == numara)
                        {
                            Console.WriteLine("Adı: {0}, Soyadı: {1} ve Telefon Numarası: {2}", rehber[i].Isim, rehber[i].SoyIsim, rehber[i].TelefonNo);
                            y = false;
                        }
                    }
                    if (y)
                    {
                        Console.WriteLine("Rehberde {0} isimli kişi kayıtlı değildir.", numara);
                    }
                    System.Threading.Thread.Sleep(2000);
                }
				else
				{
                    Console.WriteLine("Yanlış seçim yaptınız, lütfen tekrar deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto yanlissecim7;
                }
			}
			catch (FormatException)
			{
                Console.WriteLine("Geçersiz seçim yaptınız, lütfen tekrar deneyiniz.");
                System.Threading.Thread.Sleep(2000);
                goto yanlissecim7;
            }
		}
	}
}
