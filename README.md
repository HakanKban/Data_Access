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

## ENTİTY FRAMEWORK











































































































































