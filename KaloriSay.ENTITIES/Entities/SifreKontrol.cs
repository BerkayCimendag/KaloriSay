using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KaloriSay.ENTITIES.Entities
{
    public class SifreKontrol
    {
        private static int Minumum_Uzunluk = 8;
        private static int Buyuk_Harf_Adedi = 2;
        private static int Kucuk_Harf_Adedi = 3;
        private static int Ozel_Karakter_Adedi = 2;

        public static bool SifreGecerliMi(string Sifre)
        {
            if (Sifre.Length < Minumum_Uzunluk)
                return false;
            if (BuyukHarfSayisi(Sifre) < Buyuk_Harf_Adedi)
                return false;
            if (KucukHarfSayisi(Sifre) < Kucuk_Harf_Adedi)
                return false;
            if (OzelKarakterSayisi(Sifre) < Ozel_Karakter_Adedi)
                return false;
            return true;
        }
        private static int BuyukHarfSayisi(string Sifre)
        {
            return Regex.Matches(Sifre, "[A-Z]").Count;
        }
        private static int KucukHarfSayisi(string Sifre)
        {
            return Regex.Matches(Sifre, "[a-z]").Count;
        }
        private static int OzelKarakterSayisi(string Sifre)
        {
            return Regex.Matches(Sifre, @"[^0-9a-zA-Z\._]").Count;
        }
    }
}
