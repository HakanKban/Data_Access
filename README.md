# Data_Access
Uygulama ve veritabanı arasındaki veri alışverişidir. ADO.NET ve Entity Framework gibi Framework yapıları ile veri erişiminin sağlanması uygulanmıştır.
## ADO.NET 
ADO.NET, veri tabanlarındaki  bilgileri elde etmek ve ya veritabanındaki bulunan verileri değiştirmek için geliştirilmiş veri erişim aracıdır.
.NET Platformu için geliştirilmiş,offline çalışma sistemini destekleyen web uygulamaları gibi n-katmanlı uygulamalarda kolaylık sağlayan veri erişim aracıdır.

<img align="Center" height="394" width="864" src="https://github.com/HakanKban/Data_Access/blob/main/ADO.NET/G%C3%B6rseller/2022-02-13%20(6).png" width="auto">


### Görselde genel olarak ADO.NET mimarisi gösterilmiştir
## Disconected Mimari
System.Data.SqlClient kütüphanesi eklenerek SqlConnection sınıfı yardımıyla veritabanı ile bağlantı kurulmuştur. WindowsForm projesi olan örneğimizde NORTWND database olarak
kullanılmıştır. SqlDataAdapter sınıfından nesne türetilerek tablomuzu seçiyoruz. Ardından DataTable nesnesi oluşturup seçilen tabloyu DataTable üzerinde fill metodu ile Adaptere ekleyerek oluşturuyoruz. Daha sonra DataSet ile nesnesine tabloyu add metodu ile ekliyoruz. DataSet üzerinde bulunan tablolar asıl veri kaynağından bağımsız çalışır.Bağlantı kesilse bile yinede işlemler yapılabilir. İşte Disconnected çalışma modeli tam olarak budur.




<img align="Center" height="394" width="864" src="https://github.com/HakanKban/Data_Access/blob/main/ADO.NET/G%C3%B6rseller/2022-02-13%20(8).png" width="auto">

## Conected Mimari
Veri tabanına bağlantıyı sembolize eden sınıf Sql.connection sınıfıdır. SqlCommand sınıfından command nesnesi türetilerek ise sql cümleciği kullanılarak sorgu yapmamız sağlanır.
UrunEkle isim metodumuzda bu sorguyu yaptıktan sonra  AddwithValue metodu ile parametleri tanımlarız. Ardından ExecuteNonQuery metodu ile veritabanına ekleme işlemi yapılır.
Bu metod veritabanındaki kayıtları silmek,değiştirmek, ya da yeni kayıt eklemek için kullanılır.
UrunListele metodunda ise SqlDataReader sınıfından türetilen nesne ile sorgu ExecuteReader metoduyla okunur ve while döngüsü ile listeye eklenir.

<img align="Center" height="344" width="664" src="https://github.com/HakanKban/Data_Access/blob/main/ADO.NET/G%C3%B6rseller/2022-02-13%20(4).png" width="auto">




# ENTİTY FRAMEWORK

Bir ORM (Object Relational Mapping) Frameworküdür.Veritabanından çekilen verileri C# classlarına dönüştürür. ORM aynı zamanda LINQ sağlayıcısıdır.
Bu LINQ(Language Integrated Query ) yardımıyla üçüncü bir bileşene ihtiyaç duymadan dilin kendi söz dizimi ile veriye erişimi ve veri üzerindeki işlemleri kolaylaştırmaktadır.



Entity Framework'un genel olarak içeriğini görselden inceleyebilirsiniz.

<img align="Center" height="344" width="664" src="https://github.com/HakanKban/Data_Access/blob/main/EF_CODEFIRST_WFA/EF_CODEFIRST_WFA/G%C3%B6rseller/2022-02-13%20(15).png" width="auto">




## ORM KULLANIMININ AVANTAJLARI 
- Programcı nesnel düşünmekten feragat etmeden, veri erişim işlemlerini gerçekleştirebilecek.Üst düzey tip güvenliği kazanır aynı zamanda.
- Veri Tabanına bağlanıldığında nesneler açıkça oluşturulduğunda hatalı yazım işlemleri yapılamaz çünkü derleme zamanı hatası alınır.
- Veri tabanı bağımlılığı yoktur,geçiş yapılabilir.

## ORM KULLANIMININ DEZAVANTAJLARI
- ADO.NET göre performansı düşüktür.
- Nesneler üzerinden modellendiğinden, veri tabanı bağlantısında bilinçsiz müdahaleler sorunlara açıktır.



ORM' nin yapısı.
<img align="Center" height="394" width="664" src="https://github.com/HakanKban/Data_Access/blob/main/EF_CODEFIRST_WFA/EF_CODEFIRST_WFA/G%C3%B6rseller/2022-02-13%20(12).png" width="auto">

## Entity FrameWork Yaklaşımları

### DataBase Yaklaşımı 
Var olan database üzerinden model oluşturulur.Model.edmx adlı dosyada tutulaur ve etkileşime geçilen classlar bu dosya üzerinden otomatik oluşturulur.


### CodeFirst Yaklaşımı
Bu yaklaşımda hazır database yoktur. Geliştirici veritabanıyla ilgili tüm işlemleri kod yazarak gerçekleştirir.Bu yüzden hakimiyet tamamen geliştiricidedir.
Dosyalarda bu yaklaşım ile hazırlanan bir wfa projesi yüklenmiştir. Kısaca bahsedersek Models klasöründe tablolarımız class yapısında oluşturulmuştur. Burada propetyler 
tablolarımızın kolonları olarak düşünülebilir. Classlarımızda bire çok ilişkiler için virtual sınıf tipinde property ve  foreignkey için int tipinde property 
oluşturukurken, ilişkide bulunduğu sınıfta; sınıf tipinde koleksiyon property ile ilişki kurulmuştur.(bknz: Product ve Category sınıfları)
Birebir ilişkiler içinse Classlarda karşılıklı class tiplerinde virtual propertyler oluşturulmuş, OnModelCreating metoduyla bağlantı kurulmuştur. (bknz: MyContext sınıfı)
ÇokaÇok ilişki içinse 3. bir class açılarak id'ler tanımlanmış ve yine aynı metodun içinde HasKey metodu ile ilişki database'e aktarım esnasında kurulmuştur.
DbContext sınıfından miras alan MyContext sınıfında Dbsetler ile classlarımız database'e tablo olarak aktarılır.

### ModelFirst Yaklaşımı
Sık Kullanılan bir yaklaşım olmadığından değinilmemiştir.

<img align="Center" height="344" width="664" src="https://github.com/HakanKban/Data_Access/blob/main/EF_CODEFIRST_WFA/EF_CODEFIRST_WFA/G%C3%B6rseller/2022-02-13%20(17).png" width="auto">


# LINQ (Language Integrated Query)
Dile entegre edilmiş Sorgu yapısıdır. C# 3.0 daki en önemli yenilik denebilir. LINQ merkezinde yeni özellikler geliştirilmiştir. Genel olarak LINQ mimarisini görselde inceleyebilirsiniz.


<img align="Center" height="344" width="664" src="https://github.com/HakanKban/Data_Access/blob/main/EF_CODEFIRST_WFA/EF_CODEFIRST_WFA/G%C3%B6rseller/2022-02-15%20(11).png" width="auto">

### LINQ VERİ SAĞLAYICILARI
- Linq To Object 
  Hafızada bulunan List<T> gibi koleksiyon yapılarının sorgulanması ve işlenmesi amacı ile gelişmiştir.
  
- Linq To Sql 
  Sql Server gibi ilişkisel veri formatlarında veriyi tutan ortamlardaki verilere erişmek ve veriler üzerinde işlem yapmak için kullanabileceğimiz bir LINQ sağlayıcısıdır.
  Kısaca bu LINQ sağlayıcısı ilişkisel veriyi nesnel ortamda temsil edebilmemizi sağlıyor. Bu yaklaşıma ORM denilmektedir.
  
- Linq TO Xml 
  XML veri kaynaklarına harhangi bir parser (ayıklayıcı) kullanmadan hızlı bir şekilde erişmek için kullanılmaktadır. Temel amacı XML tipi verilerle çalışırken üretkenliği 
  artırmaktıt.
  
  
  
 LINQ metotları ve sql sorgu yapıları Nortwind veri tabanı üzerinden yüklenen dosyada uygulanmıştır.




























































































































