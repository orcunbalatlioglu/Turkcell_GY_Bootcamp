# Kidega Clone

Bu projede ASP .NET Core MVC kullanarak çok katmanlı bir web uygulaması yapılmıştır. Çok katmanlı mimari yapısı olarak "Onion Architecture" kullanılmıştır. Varlıkların oluşumu "Code First" yaklaşımı ile Entity Framework ile sağlanmıştır. Veri yönetimi için "Repository Pattern" kullanılmıştır. Arayüz basit şekilde Bootstrap ile oluşturulmuştur.

## Kullanıcı Rolleri

Uygulama içerisinde authentication ve authorization mekanizmaları bulunmaktadır. Site içerisindeki özellikler rollere göre ayrılmıştır. Kullanılan roller aşağıdaki gibidir.
- Client (Müşteri): Sitede istediği kitap ve yazarları inceleyebilir. Giriş yaptıktan sonra istediği ürünleri sepetine ekleyebilir ve sipariş verebilir.
- Editor: Sitedeki ürünleri inceleyebilir ama sepetine ekleyemez ve sipariş veremez. Kayıtlı olan bütün siparişleri liste halinde görüntüleyebilir. 
- Admin: Sitedeki ürünleri inceleyebilir ama sepetine ekleyemez ve sipariş veremez. Kayıtlı olan bütün siparişleri liste halinde görüntüleyebilir. Aynı zamanda bütün kullanıcıları listeleyebilir, bilgilerini görüntüleyebilir, düzenleyebilir ve kullanıcıları silebilir.

## Site Ekran Görüntüleri

Siteye ilk giriş yaptığımızda çıkan sayfa. Yan taraftan kategoriler seçerek istediğimiz kategoriden kitaplara bakabiliyoruz. Hiçbir şey yapmazsak ilk açıldığı şekilde en yüksek puanı almış 10 kitabı listeliyor. Detay Gör butonlarını kullanarak kitapların detaylarına bakabiliyoruz.
[Açılış](./Screenshots/A%C3%A7%C4%B1l%C4%B1%C5%9F.png)
Kitap detaylarını görebildiğimiz sayfa. Yazarın ismine tıkladığımızda bizi yazarın biyografisi ve kitaplarının bulunduğu sayfaya yönlendiriyor. Giriş yapılmadan sepete ekle butonuna basılırsa bizi giriş yapma sayfasına yönlendiriyor.
[Kitap Detay](./Screenshots/KitapDetay.png)
Yazar detay sayfası.
[Yazar Detay](./Screenshots/YazarDetay.png)
Giriş yapma sayfası.
[Giriş](./Screenshots/Giri%C5%9F.png)
Giriş yapmış olan kullanıcı sepet sayfasına erişim kazanıyor. Kitapları sepetine ekleyebiliyor. Sepet sayfasından adresini seçerek siparişini verebiliyor.
[Sepet Boş](./Screenshots/SepetBo%C5%9F.png)
[Sepet Adressiz](./Screenshots/SepetAdressiz.png)
[Sepet Adresli](./Screenshots/SepetAdresli.png)
Kullanıcı giriş yaptıktan sonra profil sayfasına girerek profil bilgilerini görüntüleyebiliyor.
[Profil](./Screenshots/Profil.png)
Admin olarak giriş yapmış olan kullanıcı siparişler ve kullanıcı işlemleri sayfalarına erişim sağlayabiliyor.
[Siparişler](./Screenshots/Sipari%C5%9Fler.png)
Kullanıcı işlemlerinde ilk açıldığında kullanıcı listesi bulunuyor. Bu sayfa üzerinden kullanıcı ekleme, düzenleme ve silme işlemleri yapılabiliyor.
[Kullanıcı Liste](./Screenshots/Kullan%C4%B1c%C4%B1Liste.png)
[Kullanıcı Ekleme](./Screenshots/Kullan%C4%B1c%C4%B1Ekleme.png)
[Kullanıcı Düzenleme](./Screenshots/Kullan%C4%B1c%C4%B1D%C3%BCzenleme.png)