using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanı
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[args.Length];

            for (int i = 0; i < arr.Length; i++)

            {

                arr[i] = Convert.ToInt32(args[i]);

                Console.WriteLine("The index number of Array = " + i.ToString()
                    + " value = " + arr[i].ToString() + "\n");
            }
            Console.WriteLine("BankaX Bankacılık Sistemleri...");
            string isim = "banka2022"; // Veritabanı olmadığı için bir değer belirliyoruz...
            string sifre = "171777"; // Kullanıcı bu isim ve şifreyi girerse kabul edilecek...

            Console.Write("Kullanıcı Adı:");
            string kullanıcı = Console.ReadLine();
            Console.Write("Şifre:");
            string giris = Console.ReadLine();

            Console.WriteLine("Giriş bilgileriniz kontrol ediliyor...");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadKey();

            if (kullanıcı == isim && sifre == giris)  // Kullanıcı ve şifre adresinin dopru olup olmadığını kontrol ediyoruz...
                Console.WriteLine("BankaX Bankacılık Veritabanı Kontrol Sistemine Hoşgeldiniz...");
            else
                Console.WriteLine("Giriş işlemi yapılamadı...");
            int hesap = 1000;
            int secim;
            do
            {
                Console.WriteLine(" 1-Veritabanı Yönetimi \n 2-Yönetici İşlemleri \n 3-Network Şifre İşlemleri \n 4-Kişisel Verilerin Yönetilmesi \n 5-Bankacılık Sistemleri Yönetimi \n 6-Çıkış");
                secim = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("İşlem sayfasına yönlendiriliyorsunuz...");
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(1000);
                }
                Console.ReadKey();

                if (secim == 1)
                {
                    Console.WriteLine(" 7-Veritabanı Şifreleme \n 8-Bilgileri Depola/Yedekle");
                    secim = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("İşleme Yönlendiriliyorsunuz...");
                    for (int i = 1; i < 5; i++)
                    {
                        Console.WriteLine(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.ReadKey();

                    if (secim == 7)
                    {
                        Console.WriteLine("Lütfen yeni veritabanı şifrenizi oluşturun...");
                        string vsifre = "";
                        string vsifret = "";

                        Console.Write("Veritabanı Şifrenizi Giriniz:");
                        string VSİFRE = Console.ReadLine();
                        Console.Write("Şifreyi tekrar giriniz:");
                        string VSİFRET = Console.ReadLine();

                        Console.WriteLine("Şifre değiştirme işleminiz gerçekleştiriliyor...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Şifre değiştirme işleminiz başarıyla gerçekleşti. İyi günler dileriz...");
                    }
                    if (secim == 8)
                    {
                        Console.WriteLine("Bilgi Depolama Alanı Sayfası");
                        Console.WriteLine("Depo Seçimi yapınız:");
                        Console.WriteLine(" 9-Güvenli Depo \n 10-Yedekli Depo \n 11-Veritabanı Deposu");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleme Yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 9)
                        {
                            Console.WriteLine("Güvenli depo için şifre oluşturunuz!");
                            string dsifre = "";
                            string dsifret = "";

                            Console.Write("Depo şifreniz:");
                            string DSİFRE = Console.ReadLine();
                            Console.Write("Şifreyi tekrar giriniz:");
                            string DSİFRET = Console.ReadLine();

                            Console.WriteLine("Depo şifreniz oluşturuluyor.Bilgileriniz depolanıyor.");
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Depo şifreniz başarıyla oluşturuldu.Bilgiler depoda yedeklendi. İyi günler dileriz...");
                        }
                        if (secim == 10)
                        {
                            Console.WriteLine("Yedekli depo için lütfen şifre ve ID oluşturunuz:");
                            string ysifre = "";
                            string ysifret = "";
                            string ıd = "";

                            Console.Write("Yedekli depo şifreniz:");
                            string YSİFRE = Console.ReadLine();
                            Console.Write("Şifre tekrar:");
                            string YSİFRET = Console.ReadLine();
                            Console.Write("Depo ID:");
                            string ID = Console.ReadLine();

                            Console.WriteLine("Yedekli Depo şifreniz ve ID'niz oluşturuluyor.Bilgileriniz depolanıyor.");
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Yedekli deponuz için şifreniz oluşturuldu. Bilgileriniz yedeklendi. İyi günler dileriz...");
                        }
                        if (secim == 11)
                        {
                            Console.WriteLine("Veritabanı Deposu için Şifre oluşturunuz:");
                            Console.WriteLine("!Bilgilendirme: Lütfen oluşturduğunuz şifre ve ID'leri yedekli depoya yedekleyerek şifreleyiniz!.");

                            string vsifre = "";
                            string vsifret = "";
                            string ıd1 = "";

                            Console.Write("Veritabanı Şifreniz:");
                            string VSİFRE = Console.ReadLine();
                            Console.Write("Şifreyi tekrarlayınız:");
                            string VSİFRT = Console.ReadLine();
                            Console.Write("Veritabanı ID:");
                            string ID1 = Console.ReadLine();

                            Console.WriteLine("Veritabanı Depo şifreniz ve ID'niz oluşturuluyor.Bilgileriniz depolanıyor.");
                            for (int i = 1; i < 5; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Veritabanı depo şifreniz oluşturuldu. Bilgileriniz depoda saklandı. İyi günler dileriz...");
                        }
                    }
                }
                if (secim == 2)
                {
                    Console.WriteLine(" Yönetici İşlemleri Sayfası");
                    Console.WriteLine(" 12-Kullanıcı Şifre İşlemleri \n 13-Yönetim Kontrol Paneli");
                    secim = Convert.ToInt16(Console.ReadLine());

                    if (secim == 12)
                    {
                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Lütfen Kullanıcı şifrenizi oluşturunuz.!");
                        string ksifre = "";
                        string ksifret = "";

                        Console.Write("Lütfen şifrenizi giriniz:");
                        string KSFİRE = Console.ReadLine();
                        Console.Write("Lütfen şifreyi tekrarlayınız:");
                        string KSİFRET = Console.ReadLine();

                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Kullanıcı şifreniz başarıyla oluşturuldu. İyi günler dileriz...");
                    }
                    if (secim == 13)
                    {
                        Console.WriteLine("İşleme Yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Yönetim kontrol Paneli ");
                        string pkullanıcı = "ypk2022";
                        string psifre = "784457";

                        Console.Write("Lütfen Kullanıcı adınızı giriniz:");
                        string PKULLANICI = Console.ReadLine();
                        Console.Write("Lütfen Şifrenizi giriniz:");
                        string PSİFRE = Console.ReadLine();

                        Console.WriteLine("İşleme Yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Yönetici Kontrol Paneline Hoşgeldiniz!");
                        Console.WriteLine("Yapmak istediğiniz işlemi seçin!");
                        Console.WriteLine(" 14-Yönetim sayfasını sıfırlama \n 15-Şifre ayarları");
                        secim = Convert.ToInt16(Console.ReadLine());

                        if (secim == 14)
                        {
                            Console.WriteLine("Bu sayfa ilerleyen süreçte tasarlanacak...");
                        }
                        if (secim == 15)
                        {
                            Console.WriteLine("Bu sayfa ilerleyen süreçte tasarlanacak...");
                        }
                    }
                }
                if (secim == 3)
                {
                    Console.WriteLine("Network Ağ İşlemleri Sayfası!");
                    Console.WriteLine(" 16-Banka Network Ağını Şifrele \n 17-Network Ağı İzinleri");
                    secim = Convert.ToInt16(Console.ReadLine());

                    if (secim == 16)
                    {
                        Console.WriteLine("İşleme Yönlendiriliyorsunuz...");
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Lütfen Network Ağı için şifre oluşturunuz!");
                        string nsifre = "";
                        string nsifret = "";
                        string nId = ""; // Id belirlerken karakter 4 ten fazla olmamalıdır...

                        Console.Write("Network Ağı için Şifrenizi giriniz:");
                        string NSİFRE = Console.ReadLine();
                        Console.Write("Lütfen şifreyi tekrarlayınız:");
                        string NSİFRET = Console.ReadLine();
                        for (int i = 1; i < 3; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.Write("ID' nizi belirleyin:");
                        string NID = Console.ReadLine();
                        for (int i = 1; i < 5; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        Console.WriteLine("Network Ağınız için şifreniz ve Id'niz oluşturuldu. İyi günler dileriz...");
                    }
                    if (secim == 17)
                    {
                        Console.WriteLine("Network Ağı için izinler!");
                        Console.WriteLine("Network Ağınız için ID takibi yapılsın mı?");
                        Console.WriteLine(" 18-Evet, ID takibi yapılsın. \n 19-Hayır, ID takibi yapılmasın.");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 18)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleşti. İyi günler dileriz...");
                        }
                        if (secim == 19)
                        {
                            Console.WriteLine("İşleminiz başarıyla gerçekleşti. İyi günler dileriz...");
                        }
                    }
                }
                if (secim == 4)
                {
                    Console.WriteLine("Kişisel Verilerin Yönetim Sayfası");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemleri seçiniz!");
                    Console.WriteLine(" 20-Kişisel verilerin depolanma şekli \n 21-Kişisel verilerin Onay formu");
                    secim = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.ReadKey();

                    if (secim == 20)
                    {
                        Console.WriteLine("Bankanıza ait kişisel veriler bu bölümde depolanmaktadır.");
                        Console.WriteLine("Kişisel verilerin hangi yöntemle depolanmasını istiyorsunuz?");
                        Console.WriteLine(" 22-Güvenli Depo \n 23-Yedekli Depo \n 24-Banka Veritabanı Deposu");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 22)
                        {
                            Console.WriteLine("Bankanıza ait kişisel veriler güvenli depoda şifrelenerek saklanmaktadır.");
                            Console.WriteLine("İyi günler dileriz");
                        }
                        if (secim == 23)
                        {
                            Console.WriteLine("Bankanıza ait kişisel veriler Yedekli depoda şifrelenerek saklanmaktadır.");
                            Console.WriteLine("İyi günler dileriz...");
                        }
                        if (secim == 24)
                        {
                            Console.WriteLine("Bankanıza ait kişisel veriler Bankanızın veritabanında şifrelenerek saklanmaktadır.");
                            Console.WriteLine("İyi günler dileriz...");
                        }
                    }
                    if (secim == 21)
                    {
                        Console.WriteLine("Kişisel verilerin korunmasına ilişkin Onay/Rıza metni!");
                        Console.WriteLine("Metne ulaşmak için:");
                        Console.WriteLine(" 25-BankaX Onay/Rıza Metni");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 25)
                        {
                            Console.WriteLine("Onay formuna /www.bankax.com.tr/ sayfasından ulaşabilirsiniz.");
                            Console.WriteLine("İyi günler dileriz...");
                        }

                    }
                }
                if (secim == 5)
                {
                    Console.WriteLine("Bankacılık Sistemleri Yönetim Sayfası");
                    Console.WriteLine("Sayfaya Ulaşmak için lütfen veritabanı ID'nizi giriniz!");
                    string vId = "0017"; // Kullanıcı bu ID ile giriş yapacaktır...

                    Console.Write("Lütfen veritabanı ID'nizi giriniz:");
                    string VID = Console.ReadLine();

                    Console.WriteLine("Bankacılık Sistemleri sayfasına yönlendiriliyorsunuz...");
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.ReadKey();

                    if (vId == VID) // Kullanıcı ID'sinin doğru olup olmadığını kontrol ediyoruz...
                        Console.WriteLine("Bankacılık Sistemleri sayfasına hoşgeldiniz!");
                    else
                        Console.WriteLine("Giriş işlemi yapılamadı!");

                    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
                    Console.WriteLine(" 26-İnternet Şubesi \n 27-Mobil Uygulama \n 28-Ayarlar");
                    secim = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine(i);
                        System.Threading.Thread.Sleep(1000);
                    }
                    Console.ReadKey();

                    if (secim == 26)
                    {
                        Console.WriteLine("Yapmak istediğiniz ayarlamayı aşağıdan yapabilirsiniz!");
                        Console.WriteLine(" 29-Sistem Ayarları \n 30-Sistem izinleri/kısıtlamaları");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 29)
                        {
                            Console.WriteLine("Sistem Ayarları Sayfasına Hoşgeldiniz!");
                            Console.WriteLine(" 31-Sistemi Kapat \n 32-Sistemi Etkinleştir \n 33-Sistemi Güncelleştir");
                            secim = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("İşleme Yönlendiriliyorsunuz...");
                            for (int i = 1; i < 4; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            if (secim == 31)
                            {
                                Console.WriteLine("Sistem kapatılıyor...");
                                for (int i = 1; i < 7; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                Console.WriteLine("Sistem başarıyla kapatılmıştır.!");
                            }
                            if (secim == 32)
                            {
                                Console.WriteLine("Sistemi etkinleştirme çalışıyor...");
                                for (int i = 1; i < 6; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                Console.WriteLine("Sistem başarılı şekilde etkinleştirildi.");
                                Console.WriteLine("İyi günler dileriz...");
                            }
                            if (secim == 33)
                            {
                                Console.WriteLine("Sistemi güncelleştirmek için veritabanı sağlayıcıları çalışıyor...");
                                for (int i = 1; i < 15; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                Console.WriteLine("Sisteminiz son sürüm şeklinde güncellenmiştir.");
                                Console.WriteLine("İyi günler dileriz...");
                            }
                        }
                        if (secim == 30)
                        {
                            Console.WriteLine("Bankacılık sistemleri izin sayfasına hoşgeldiniz!");
                            Console.WriteLine("Bilgilendirme!İzinler bankanız tarafından otomatik olarak belirlenmiştir.");
                            Console.WriteLine("İyi günler dileriz...");
                        }
                    }
                    if (secim == 27)
                    {
                        Console.WriteLine("Yapmak istediğiniz işlemleri aşağıdan yapabilirsiniz.");
                        Console.WriteLine(" 34-Sistemi kapat \n 35-Sistemi etkinleştir \n 36-Sistemi Güncelleştir");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 34)
                        {
                            Console.WriteLine("Sistem kapatılıyor...");
                            for (int i = 1; i < 7; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Sistem başarıyla kapatılmıştır.!");
                        }
                        if (secim == 35)
                        {
                            Console.WriteLine("Sistemi etkinleştirme çalışıyor...");
                            for (int i = 1; i < 6; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Sistem başarılı şekilde etkinleştirildi.");
                            Console.WriteLine("İyi günler dileriz...");
                        }
                        if (secim == 36)
                        {
                            Console.WriteLine("Sistemi güncelleştirmek için veritabanı sağlayıcıları çalışıyor...");
                            for (int i = 1; i < 15; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            Console.WriteLine("Sisteminiz son sürüm şeklinde güncellenmiştir.");
                            Console.WriteLine("İyi günler dileriz...");
                        }
                    }
                    if (secim == 28)
                    {
                        Console.WriteLine("Bankacılık Sistemleri Yönetim Ayarları");
                        Console.WriteLine("Yapmak istediğiniz ayarlamaları bu sayfadan yapabilirsiniz.!");
                        Console.WriteLine(" 37-Yönetici Bilgileri Kontrolü \n 38-Sistem Güncelleştirmesi \n 39-Banka Veritabanı Kontrol İşlemleri");
                        secim = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine(i);
                            System.Threading.Thread.Sleep(1000);
                        }
                        Console.ReadKey();

                        if (secim == 37)
                        {
                            Console.WriteLine("Veritabanı Yönetici Bilgileri bu sayfada bulunmaktadır!");
                            string a = "Bilgilendirme!";
                            string b = "Bu sayfada bulunan bilgileri sadece veritabanına giriş yapan yöneticiler bilmektedir!";

                            Console.WriteLine(a + b);

                            Console.WriteLine("BankaX Bankacılık Sistemleri Yönetici Bilgileri!");
                            Console.WriteLine("#Banka2022");
                            Console.WriteLine("#1*****");
                            Console.WriteLine("#İstanbul");

                            Console.WriteLine("!Bilgilerin yanlış olduğunu düşünüyorsanız, lütfen ilgili birimle irtibata geçiniz!");
                        }
                        if (secim == 38)
                        {
                            Console.WriteLine("Sistem Güncelleştirme sayfasına hoşgeldiniz!");
                            string a = "Bilgilendirme!";
                            string b = "Bu sayfada tüm sistemin güncellemesini gerekli zamanlarda yapabilirsiniz.!";

                            Console.WriteLine(a + b);

                            Console.WriteLine("Sistemi güncellemek için güncellemeleri denetleyiniz!");
                            Console.WriteLine(" 40-Güncellemeleri Denetle");
                            secim = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                            for (int i = 1; i < 14; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            if (secim == 40)
                            {
                                Console.WriteLine("Sistemi Güncellemek ister misiniz?");
                                Console.WriteLine(" 41-Sistemi Güncelleştir! \n 42-Sistemi saat 22.00'dan sonra güncelleştir!");
                                secim = Convert.ToInt16(Console.ReadLine());

                                Console.WriteLine("Sistem güncelleştirmesine başlanıyor...");
                                for (int i = 1; i < 4; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                if (secim == 41)
                                {
                                    Console.WriteLine("Sisteminiz son sürümü güncelleştiriyor...");
                                    Console.WriteLine("Güncelleme yapılırken bilgileriniz yedeklenerek saklanıyor...");
                                    for (int i = 1; i < 60; i++)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    Console.ReadKey();

                                    Console.WriteLine("Sisteminiz başarılı şekilde güncelleştirilmiştir.");
                                    Console.WriteLine("İyi günler dileriz...");
                                }
                                if (secim == 42)
                                {
                                    Console.WriteLine("Sisteminiz için güncellemeler saat 22.00'dan sonra otomatik olarak yapılacaktır.");
                                    Console.WriteLine("Güncelleme yapıldıktan sonra, sistem kapanacak, işlemler tekrardan ilerleyecektir.");
                                    Console.WriteLine("İyi günler dileriz...");
                                }
                            }
                        }
                        if (secim == 39)
                        {
                            Console.WriteLine("Veritabanı Kontrol Sayfasına Hoşgeldiniz!");
                            Console.WriteLine("Bilgilendirme! Yapmak istediğiniz işlemleri buradan yapabilirsiniz.!");
                            Console.WriteLine(" 43-Veritabanı Kilitleme \n 44-Veritabanı Yedek Dosyaları \n 45-Veritabanı Silme");
                            secim = Convert.ToInt16(Console.ReadLine());

                            Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                            for (int i = 1; i < 4; i++)
                            {
                                Console.WriteLine(i);
                                System.Threading.Thread.Sleep(1000);
                            }
                            Console.ReadKey();

                            if (secim == 43)
                            {
                                Console.WriteLine("Veritabanını kilitlemek ister misiniz?");
                                Console.WriteLine(" 46-Veritabanı Kilitlensin! \n 47-Veritabanı Kilitlenmesin!");
                                secim = Convert.ToInt16(Console.ReadLine());

                                Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                                for (int i = 1; i < 4; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                if (secim == 46)
                                {
                                    Console.WriteLine("Veritabanınız kilitleniyor. Bilgileriniz yedekleniyor...");
                                    for (int i = 1; i < 10; i++)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    Console.ReadKey();

                                    Console.WriteLine("Veritabanınız başarıyla kilitlendi.");
                                    Console.WriteLine("İyi günler dileriz...");
                                }
                                if (secim == 47)
                                {
                                    Console.WriteLine("Veritabanınız kilitlenmiyor. İyi günler dileriz...");
                                }
                            }
                            if (secim == 44)
                            {
                                Console.WriteLine("Veritabanınızın yedeklenmiş dosyaları, veritabanı yedekleme depolarında yedeklenmektedir.!");
                                Console.WriteLine("Yedekli dosyalara ulaşmak için yönetici kontrol sayfasına bakabilirsiniz!");
                                Console.WriteLine("Veritabanı 1 ID:");
                                Console.WriteLine("Veritabanı 2 ID:");
                                Console.WriteLine("Veritabanı 3 ID:");
                                Console.WriteLine("İyi günler dileriz...");
                            }
                            if (secim == 45)
                            {
                                Console.WriteLine("Veritabanı Silme sayfasına Hoşgeldiniz!");
                                Console.WriteLine("Silmek istediğiniz veritabanı için lütfen aşağıdaki işlemleri takip ediniz!");
                                Console.WriteLine("Bilgilendirme!");
                                Console.WriteLine("Bu sayfada yapacağınız işlemler, kayıt altına alınacaktır.");

                                string a = "Lütfen!";
                                string b = "Silmek istediğiniz veritabanını seçiniz!";

                                Console.WriteLine(a + b);

                                Console.WriteLine(" 1-Veritabanı ID: \n 2-Veritabanı ID: \n 3-Veritabanı ID:");
                                secim = Convert.ToInt16(Console.ReadLine());

                                Console.WriteLine("İşleme yönlendiriliyorsunuz...");
                                for (int i = 1; i < 4; i++)
                                {
                                    Console.WriteLine(i);
                                    System.Threading.Thread.Sleep(1000);
                                }
                                Console.ReadKey();

                                if (secim == 1)
                                {
                                    Console.WriteLine("Veritabanı silme işlemi başlatılıyor. Dosyalar sistemden tamamen siliniyor...");
                                    for (int i = 1; i < 10; i++)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    Console.ReadKey();

                                    Console.WriteLine("Veritabanı silme işleminiz başarıyla gerçekleşmiştir.");
                                    Console.WriteLine("İyi günler dileriz...");
                                }
                                if (secim == 2)
                                {
                                    Console.WriteLine("Veritabanı silme işlemi başlatılıyor. Dosyalar sistemden tamamen siliniyor...");
                                    for (int i = 1; i < 10; i++)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    Console.ReadKey();

                                    Console.WriteLine("Veritabanı silme işleminiz başarıyla gerçekleşmiştir.");
                                    Console.WriteLine("İyi günler dileriz...");
                                }
                                if (secim == 3)
                                {
                                    Console.WriteLine("Veritabanı silme işlemi başlatılıyor. Dosyalar sistemden tamamen siliniyor...");
                                    for (int i = 1; i < 10; i++)
                                    {
                                        Console.WriteLine(i);
                                        System.Threading.Thread.Sleep(1000);
                                    }
                                    Console.ReadKey();

                                    Console.WriteLine("Veritabanı silme işleminiz başarıyla gerçekleşmiştir.");
                                    Console.WriteLine("İyi günler dileriz...");
                                }
                            }
                        }
                    }
                }
            }
            while (secim != 6);
            Console.WriteLine("BankaX ailesi olarak sağlıklı günler dileriz");
        }
    }
