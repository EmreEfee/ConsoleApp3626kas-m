using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3626kasım
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Linq sorgulama yöntei .NET Framework 3.5 ile birlikte gelen bir teknolojidir.

            //Linq yöntemi ile koleksiyonlar içerisindeki verileri filtreleyebilir,sıralayabilir
            // gruplayabilir vb..
            // İçerisinde string veriler barındıran bir koleksiyon oluşturalım.

            List<string> sehirler = new List<string>()
            {

                "Istanbul", "Izmir", "Ankara","Manisa","Adıyaman","Edirne","Bursa","Antalya","Muş","Hatay","Mersin"

            };
            /*
            #region Select

            //Koleksiyon içerisindeki verileri linq sorgusu ile çekelim.
            var list = from s
                       in sehirler
                       select s;
            //from => Seçilen koleksiyona sorgu işlemleri esnasında takma isim vermemizi sağlar.
            // in => Linq sorgulama işlemlerinde hangi koleksiyon baz alınacak ise o koleksiyonu 
            //seçmemizi sağlar.
            // select => Sorgulama işlemleri tamamlandıktan sonra geriye hangi veriyi döndüreceğimizi belirtir
            // Sorgulama işlemi tamamlandıktan sonra geriye IEnumerable<?> tipinde bir koleksiyon döndürür
            foreach (var sehir in list)
            {
                Console.WriteLine(sehir);
            }



            #endregion
            #region OrderBy
            //Linq sorgulama yöntemi ile koleksiyonlar içerisindeki verileri küçükten büyüğe 
            // (Aynı zamanda alfabetik olarak) sıralama işlemi yapmamızı sağlar.
            var kbSehirler = from s
                 in sehirler
                             orderby s ascending
                             select s;

            // orderby => koleksiyon içerisindeki verileri sıralama işlemi yapmamızı sağlar
            // orderby komutundan sonra hangi  veriye sıralama işlemi uygulayacak isek onu 
            //belirtme gerekmektedir.Sonrasında "ascending" komutu ile küçükten büyüpe 
            //doğru sıralayabiliriz.
            //Select komutundan önce kullanılması gerekmektedir.
            // Geriye IOrderedEnumerable<?> tipinde veri döndürür.

            Console.WriteLine();
            Console.WriteLine("OrderBy");
            Console.WriteLine("--------------");
            foreach (var sehir in kbSehirler)
            {
                Console.WriteLine(sehir);
            }





            #endregion
            #region OrderBy Descending 
            //Linq sorgulama işlemi esnasında verileri büyükten küçüğe (aynı zamanda ters alfabetik)
            //sırlama işlemi yapmamızı sağlar.

            var bkSehirler = from s
                             in sehirler
                             orderby s descending
                             select s;
            //orderby => koleksiyon içerisindeki verileri sıralama işlemi yapmamızı sağlar.
            //orderby komutundan sonra hangi veriye sıralama işlemi uygulayacaksak onu belirtmemiz
            // gerekmektedir.Sonrasında descending komutu ile büyükten küçüğe doğru sıralayabiliriz.

            //Select komutundan önce kullanılır.

            //Geriye I0rderedEnumerable<?> tipinde veri döndürür.
            Console.WriteLine();
            Console.WriteLine("OrderBy Descending");
            Console.WriteLine("----------------------");
            foreach (var sehir in bkSehirler)
            {
                Console.WriteLine(sehir);
            }


            #endregion
            #region Where
            // Linq sorgulama işlemi esnasında baz alınan koleksiyon içerisindeki verileri filtrelemek
            //için kullanılır.

            //Filtreleme işlemlerini "where" komutu ile yaparız.
            //Where komutunu "orderby" ve "select"komutlarından önce kullanmalıyız.
            // Where komutundan sonra karşılaştırma operatörleri aracılığı ile koleksiyon içerisindeki 
            //veriler baz alınarak filtreleme işlemleri uygulanır.

            var fSehirler = from x
                            in sehirler
                            where x[0].ToString().ToLower() == "a"
                            orderby x ascending
                            select x;
            Console.WriteLine();
            Console.WriteLine("Where - A alfabetik");
            Console.WriteLine("-----------------------");
            foreach (var sehir in fSehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();
            Console.WriteLine("Where - A ters alfabetik");
            var sSehirler = from x
                            in sehirler
                            where x[0].ToString().ToLower() == "a"
                            orderby x descending
                            select x;



            foreach (var sehir in sSehirler)
            {
                Console.WriteLine(sehir);
            }



                            #endregion
            */




            /*
            List<int> sayilar = new List<int>()
            {
                25,6,38,456,2,63,754,23,45,67,12,78,41,-5,641,3


            };

            // Koleksiyon içerisindeki verileri linq yöntemi ile çekip ekrana yazalım.
            //koleksiyon içerisindeki verileri küçükten büyüğe doğru sıralı ekrana yazdıralım
            //Koleksiyon içerisindeki verileri büyükten küçüğe doğru sıralı ekrana yazdıralım
            //Koleksiyon içerisindeki verilerden 4'e bölünüp 7'ye bölünmeyenleri küçükten büyüğe yazdıralım
            //Koleksiyon içerisindeki verilerden 3'e tam bölünebilen sayıların en büyüğünü ve en küçüğü ekrana yazalım.

            var cekilenVeriler = from x
                                 in sayilar
                                 select x;                  

            foreach (var veri in cekilenVeriler)
            {
                Console.WriteLine(veri);
            }

            var siraliListe1 = from x
                               in sayilar
                               orderby x ascending
                               select x;
            Console.WriteLine("Küçükten büyüğe sıralı liste");
            foreach (var veri in siraliListe1)
            {
                Console.WriteLine(veri + "");
            }
            var siraliListe2 = from x
                               in sayilar
                               orderby x descending
                               select x;

            Console.WriteLine("\n\nBüyükten küçüğe sıralı liste");
            foreach (var veri in siraliListe2)
            {
                Console.WriteLine(veri + "");
            }

            var filtreliListe = from x
                                in sayilar
                                where x % 4 == 0 && x % 7 != 0
                                orderby x
                                select x;
            Console.WriteLine("\n\n4'e bölünüp 7'ye bölünmeyenler:");
            foreach (var veri in filtreliListe)
            {
                Console.WriteLine(veri + "");
            }
            var bolunen3 = (from x
                                  in sayilar
                                   where x % 3 == 0
                                   orderby x ascending
                                   select x).ToList();

            Console.WriteLine("3'e bölünebilen en küçük sayı: "+ bolunen3[0]);
            Console.WriteLine("3 ' e bölünebilen en büyük sayı : "+bolunen3[bolunen3.Count-1]);

            //İkinci yöntem


            var bolunen32 = from x
                            in sayilar
                            where x % 3 == 0
                            select x;

            Console.WriteLine("3' e bölünebilen en küçük sayı : " + bolunen32.Min());
            Console.WriteLine("3 ' e bölünebilen en büyük sayı : " +bolunen32.Max());
            */

            List<string> isimler = new List<string>()
            { "Mustafa","Ahmet","Yiğithan","Selim","Umut","Ömer","Oğuzhan","Özge","Aybüke","Kemal","Halil","Taha","Erdem","Maxim","Demir","Ensar","Enes", "Altar"


            };

            //koleksiyon içerisindeki isimleri alfabetik sırayla listeleyelim
            // "A" harfi ile başlayan kişilerin sayısını ekrana yazalım
            //"A" harfi ile başlayan kişilerden isminin karakter uzunluğu en fazla olan kişiyi ekrana yazdıralım

            var alfabetiksira = from x
                                in isimler
                                orderby x ascending
                                select x;

            foreach (var veri in alfabetiksira)
            {
                Console.WriteLine(veri);
            }

            
            var ailebaslayan = from x
                               in isimler
                               where x[0].ToString().ToLower() == "a"
                               select x;
            int aSayisi = 0;
            foreach (var veri in ailebaslayan)
            {
                aSayisi++;
            }
            Console.WriteLine("ismi 'a' ile başlayan kişi sayısı: "+aSayisi);
            var ailebaslayanenbuyuk = (from x
                               in isimler
                                       where x[0].ToString().ToLower() == "a"
                                       orderby x.Length descending
                                       select x).ToList();
            Console.WriteLine("a ile baslayan en uzun kelime: "+ailebaslayanenbuyuk[0]);

            var listUzunA = from a
                            in isimler
                            where a[0].ToString().ToLower() == "a"
                            select a;
            int enUzunKarakter = 0;
            string enUzunIsim = string.Empty;
            foreach (var isim1 in listUzunA)
            {
                if (enUzunKarakter<isim1.Length)
                {
                    enUzunKarakter = isim1.Length;
                    enUzunIsim = isim1;
                }



            }
            Console.WriteLine("A ile başlayıp karakter uzunluğu en fazal olan kişi : " + enUzunIsim);



                    Console.ReadKey();
        }
    }
}
