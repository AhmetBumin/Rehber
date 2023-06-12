using System;
namespace TelefonRehberiUygulamasi
{
	public class Kisiler
	{
		private string isim;
		private string soyIsim;
		private string telefonNo;

        public Kisiler(string isim, string soyIsim, string telefonNo)
		{
			this.Isim = isim;
			this.SoyIsim = soyIsim;
			this.TelefonNo = telefonNo;
		}

		public string Isim
		{
			get=>isim;
			set=>isim=value;
        }
		public string SoyIsim
		{
			get=>soyIsim;
            		set => soyIsim = value;
		}
		public string TelefonNo
		{
			get=>telefonNo;
			set=>telefonNo=value;
		}
	}
}

