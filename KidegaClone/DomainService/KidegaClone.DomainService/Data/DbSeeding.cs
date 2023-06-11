using KidegaClone.Domain.Entities;
using KidegaClone.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace KidegaClone.DomainService.Data
{
    public static class DbSeeding
    {
        
        public static void SeedDatabase(KidegaCloneDbContext context)
        {
            seedCategoryIfNotExist(context);
            seedAuthorIfNotExist(context);
            seedUserIfNotExist(context);
            seedAddressIfNotExist(context);            
            seedPublisherIfNotExist(context);
            seedBookIfNotExist(context);
            seedOrderIfNotExist(context);
            seedReviewIfNotExist(context);
            //seedObjects(context);
        }

        private static void seedAddressIfNotExist(KidegaCloneDbContext context)
        {
            if (!context.Addresses.Any())
            {
                var addresses = new List<Address>()
                {
                    new Address
                    {
                        Name = "Ev 1",
                        City = "İstanbul",
                        District = "Kadıköy",
                        Neighbourhood = "Moda",
                        Street = "Örnek Sokak",
                        BuildingNo = "123",
                        FlatNo = 4,
                        UserID = 1
                    },
                    new Address
                    {
                        Name = "Ev 2",
                        City = "İstanbul",
                        District = "Beşiktaş",
                        Neighbourhood = "Levent",
                        Street = "Başka Sokak",
                        BuildingNo = "456",
                        FlatNo = 10,
                        UserID = 1
                    },
                    new Address
                    {
                        Name = "Ev 3",
                        City = "Ankara",
                        District = "Çankaya",
                        Neighbourhood = "Kızılay",
                        Street = "Öteki Sokak",
                        BuildingNo = "789",
                        FlatNo = 5,
                        UserID = 2
                    },
                    new Address
                    {
                        Name = "Ev 4",
                        City = "İzmir",
                        District = "Bornova",
                        Neighbourhood = "Göztepe",
                        Street = "Bir Başka Sokak",
                        BuildingNo = "321",
                        FlatNo = 8,
                        UserID = 2
                    },
                    new Address
                    {
                        Name = "Ev 5",
                        City = "Bursa",
                        District = "Osmangazi",
                        Neighbourhood = "Merkez",
                        Street = "Deneme Sokak",
                        BuildingNo = "654",
                        FlatNo = 3,
                        UserID = 3
                    },
                    new Address
                    {
                        Name = "Ev 6",
                        City = "Adana",
                        District = "Seyhan",
                        Neighbourhood = "Yüreğir",
                        Street = "Bir Yer Sokak",
                        BuildingNo = "987",
                        FlatNo = 12,
                        UserID = 3
                    },
                    new Address
                    {
                        Name = "Ev 7",
                        City = "Antalya",
                        District = "Muratpaşa",
                        Neighbourhood = "Lara",
                        Street = "Test Sokak",
                        BuildingNo = "741",
                        FlatNo = 6,
                        UserID = 4
                    },
                    new Address
                    {
                        Name = "Ev 8",
                        City = "Eskişehir",
                        District = "Tepebaşı",
                        Neighbourhood = "İstiklal",
                        Street = "Deneme2 Sokak",
                        BuildingNo = "852",
                        FlatNo = 9,
                        UserID = 4
                    },
                    new Address
                    {
                        Name = "Ev 9",
                        City = "Mersin",
                        District = "Akdeniz",
                        Neighbourhood = "Yenişehir",
                        Street = "Test2 Sokak",
                        BuildingNo = "963",
                        FlatNo = 2,
                        UserID = 5
                    },
                    new Address
                    {
                        Name = "Ev 10",
                        City = "Trabzon",
                        District = "Ortahisar",
                        Neighbourhood = "Meydan",
                        Street = "Deneme3 Sokak",
                        BuildingNo = "159",
                        FlatNo = 7,
                        UserID = 5
                    },
                    new Address
                    {
                        Name = "Ev 11",
                        City = "Diyarbakır",
                        District = "Bağlar",
                        Neighbourhood = "Konak",
                        Street = "Test3 Sokak",
                        BuildingNo = "357",
                        FlatNo = 1,
                        UserID = 6
                    },
                    new Address
                    {
                        Name = "Ev 12",
                        City = "Konya",
                        District = "Selçuklu",
                        Neighbourhood = "Türkmenbaşı",
                        Street = "Deneme4 Sokak",
                        BuildingNo = "753",
                        FlatNo = 11,
                        UserID = 6
                    },
                    new Address
                    {
                        Name = "Ev 13",
                        City = "Samsun",
                        District = "İlkadım",
                        Neighbourhood = "Atakum",
                        Street = "Test4 Sokak",
                        BuildingNo = "951",
                        FlatNo = 5,
                        UserID = 7
                    },
                    new Address
                    {
                        Name = "Ev 14",
                        City = "Kayseri",
                        District = "Melikgazi",
                        Neighbourhood = "Yeşilhisar",
                        Street = "Deneme5 Sokak",
                        BuildingNo = "258",
                        FlatNo = 10,
                        UserID = 7
                    },
                    new Address
                    {
                        Name = "Ev 15",
                        City = "Malatya",
                        District = "Yeşilyurt",
                        Neighbourhood = "Yeni Mahalle",
                        Street = "Test5 Sokak",
                        BuildingNo = "654",
                        FlatNo = 4,
                        UserID = 8
                    },
                    new Address
                    {
                        Name = "Ev 16",
                        City = "Gaziantep",
                        District = "Şahinbey",
                        Neighbourhood = "Güneş",
                        Street = "Deneme6 Sokak",
                        BuildingNo = "852",
                        FlatNo = 9,
                        UserID = 8
                    },
                    new Address
                    {
                        Name = "Ev 17",
                        City = "Şanlıurfa",
                        District = "Haliliye",
                        Neighbourhood = "Karaköprü",
                        Street = "Test6 Sokak",
                        BuildingNo = "357",
                        FlatNo = 3,
                        UserID = 9
                    },
                    new Address
                    {
                        Name = "Ev 18",
                        City = "Erzurum",
                        District = "Yakutiye",
                        Neighbourhood = "Kanlıca",
                        Street = "Deneme7 Sokak",
                        BuildingNo = "753",
                        FlatNo = 8,
                        UserID = 9
                    },
                    new Address
                    {
                        Name = "Ev 19",
                        City = "Van",
                        District = "İpekyolu",
                        Neighbourhood = "Bahçıvan",
                        Street = "Test7 Sokak",
                        BuildingNo = "951",
                        FlatNo = 2,
                        UserID = 10
                    },
                    new Address
                    {
                        Name = "Ev 20",
                        City = "Rize",
                        District = "Merkez",
                        Neighbourhood = "Fındıklı",
                        Street = "Deneme8 Sokak",
                        BuildingNo = "258",
                        FlatNo = 7,
                        UserID = 10
                    },
                };

                context.Addresses.AddRange(addresses);
                context.SaveChanges();
            }
        }


        private static void seedAuthorIfNotExist(KidegaCloneDbContext context)
        {
            if (!context.Authors.Any())
            {
                var authors = new List<Author>()
                {
                    new() { Name = "Ayfer", Surname = "Tunç", Biography = "Ayfer Tunç 3 Mart 1964 yılında Adapazarı'nda dünyaya geldi. İstanbul Üniversitesi Siyasal Bilgiler Fakültesinden mezun oldu. Üniversitede bir çok edebiyat ve kültür dergilerine yazılar yazdı.1989 yılında Cumhuriyet Gazetesinin düzenlediği Yunus Nadi Öykü armağanı'na katılarak Saklı isimli yapıtı ile birincilik ödülünü aldı.1999-2004 yılları arasında Yapı Kredi Yayınlarında yayın yönetmeni olarak görev yaptı. 2001 senesinde yayınlanan ve büyük bir ilgi gören Bir Maniniz Yoksa Annemler Size Gelecek isimli yapıtı Balkan ülkelerinin katıldığı Uluslararası Balkanika ödülünü aldı. Balkan dillerine çevrilmesinin yanı sıra Suriye ve Lübnan'da Arapça olarak yayınlandı.", Picture = "https://loremflickr.com/320/240/book,girl,writer/all" },
                    new() { Name = "Annie", Surname = "Ernaux", Biography="Annie Ernaux, Edebiyat, Fransız Edebiyatı kategorilerinde eserler yazmış bir yazardır.Başlıca kitapları alfabetik sırayla; Babam, Kürtaj olarak sayılabilir.Annie Ernaux kitapları; İletişim Yayınevi aracılığıyla kitapseverlerle buluşmuştur.Annie Ernaux tarafından yazılan son kitap Babam, İletişim Yayınevi tarafından okurların beğenisine sunulmuştur.", Picture = "https://loremflickr.com/320/240/book,girl,writer"},
                    new() { Name = "Matt", Surname = "Haig", Biography = "Matt Haig 3 Temmuz 1975 yılında İngiltere'de dünyaya geldi. Hull üniversitesinde İngiliz tarihi alanında eğitim aldı. Haig hem çocuklar hemde gençler için kurgusal ve kurgusal olmayan romanların yazarıdır. Kurgusal olmayan Hayatta Kalma Sebepleri kitabı Sunday Times'ın en çok satan kitabı oldu. Bu kitabı İngiltere'de 46 hafta boyunca ilk 10 içerisinde yer aldı. Yazarın en çok satan romanı Noel Baba ve Ben film için uyarlandı. Matt Haig romanları genellikle karanlık ve ilginç aile hayatını konu alır. Kitapları 25 dile çevrildi ve bir çok edebiyat alanındaki ödülün sahibi oldu. ", Picture = "https://loremflickr.com/320/240/book,boy,man,writer/all"},
                    new() { Name = "Zülfü", Surname = "Livaneli", Biography = "20 Haziran 1946 yılında Konya’da doğan yazarın gerçek adı Ömer Zülfü Livaneli’dir. Küçük yaşlarından itibaren müziğe ilgi duymaya başladı ve saz çalmayı öğrendi. 1964 yılında Ülker Tunçay ile evlenmiştir ve bu evlilikten Aylin Livaneli dünyaya gelmiştir.Müziği sayesinde yurt içinde ve yurt dışında birçok ödül almıştır. John Baez, Maria Farandouri gibi sanatçılar tarafından bazı eserleri yorumlanmıştır. Özgün film müzikleri de yapan Zülfü Livaneli çeşitli konserler vermiştir.", Picture="https://loremflickr.com/320/240/book,boy,man,writer,glasses/all"}
                };
                context.Authors.AddRange(authors);
                context.SaveChanges();
            }
        }

        private static void seedBookIfNotExist(KidegaCloneDbContext context)
        {
            if (!context.Books.Any())
            {
                var books = new List<Book>()
                {
                    new Book
                    {
                        Name = "Kitap 1",
                        AuthorID = 1,                        
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 1 },
                            new BookCategory { CategoryID = 2 }
                        },
                        Price = 29.99m,                        
                        PublishDate = new DateTime(2022, 1, 1),
                        Rating = 4.5m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 1 açıklaması",
                        ShortExcerpt = "Kitap 1 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 300,
                        Width = 14,
                        Height = 21,
                        Barcode = 1234567890123
                    },
                    new Book
                    {
                        Name = "Kitap 2",
                        AuthorID = 2,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 3 },
                            new BookCategory { CategoryID = 4 }
                        },
                        Price = 19.99m,

                        PublishDate = new DateTime(2021, 12, 15),
                        Rating = 4.2m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 2 açıklaması",
                        ShortExcerpt = "Kitap 2 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 250,
                        Width = 13,
                        Height = 19,
                        Barcode = 9876543210987
                    },
                    new Book
                    {
                        Name = "Kitap 3",
                        AuthorID = 3,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 2},
                            new BookCategory { CategoryID = 4}
                        },
                        Price = 24.99m,
                        PublishDate = new DateTime(2023, 3, 10),
                        Rating = 4.8m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 3 açıklaması",
                        ShortExcerpt = "Kitap 3 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 400,
                        Width = 16,
                        Height = 23,
                        Barcode = 9876543210123
                    },
                    new Book
                    {
                        Name = "Kitap 4",
                        AuthorID = 4,
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 1 },
                            new BookCategory { CategoryID = 3 }
                        },
                        Price = 18.99m,
                        PublishDate = new DateTime(2022, 5, 5),
                        Rating = 4.0m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 4 açıklaması",
                        ShortExcerpt = "Kitap 4 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 280,
                        Width = 12,
                        Height = 18,
                        Barcode = 1234567890876
                    },
                    new Book
                    {
                        Name = "Kitap 5",
                        AuthorID = 1,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 5 }
                        },
                        Price = 14.99m,
                        PublishDate = new DateTime(2020, 9, 20),
                        Rating = 4.3m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 5 açıklaması",
                        ShortExcerpt = "Kitap 5 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 320,
                        Width = 15,
                        Height = 22,
                        Barcode = 9876543210345
                    },
                    new Book
                    {
                        Name = "Kitap 6",
                        AuthorID = 2,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 7 },
                            new BookCategory { CategoryID = 8 }
                        },
                        Price = 21.99m,
                        PublishDate = new DateTime(2021, 7, 1),
                        Rating = 4.7m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 6 açıklaması",
                        ShortExcerpt = "Kitap 6 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 350,
                        Width = 13,
                        Height = 20,
                        Barcode = 1234567890654
                    },
                    new Book
                    {
                        Name = "Kitap 7",
                        AuthorID = 3,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 4 }
                        },
                        Price = 16.99m,
                        PublishDate = new DateTime(2023, 2, 28),
                        Rating = 4.4m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 7 açıklaması",
                        ShortExcerpt = "Kitap 7 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 300,
                        Width = 14,
                        Height = 21,
                        Barcode = 9876543210765
                    },
                    new Book
                    {
                        Name = "Kitap 8",
                        AuthorID = 4,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 6 }
                        },
                        Price = 32.99m,
                        PublishDate = new DateTime(2022, 11, 15),
                        Rating = 4.9m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 8 açıklaması",
                        ShortExcerpt = "Kitap 8 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 420,
                        Width = 16,
                        Height = 24,
                        Barcode = 1234567890456
                    },
                    new Book
                    {
                        Name = "Kitap 9",
                        AuthorID = 1,
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 5 }
                        },
                        Price = 27.99m,
                        PublishDate = new DateTime(2021, 9, 10),
                        Rating = 4.6m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 9 açıklaması",
                        ShortExcerpt = "Kitap 9 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 380,
                        Width = 15,
                        Height = 22,
                        Barcode = 9876543210234
                    },
                    new Book
                    {
                        Name = "Kitap 10",
                        AuthorID = 2,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 4 }
                        },
                        Price = 19.99m,
                        PublishDate = new DateTime(2023, 5, 1),
                        Rating = 4.2m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 10 açıklaması",
                        ShortExcerpt = "Kitap 10 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 250,
                        Width = 13,
                        Height = 19,
                        Barcode = 1234567890321
                    },
                    new Book
                    {
                        Name = "Kitap 11",
                        AuthorID = 3,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 1 },
                            new BookCategory { CategoryID = 3 }
                        },
                        Price = 24.99m,
                        PublishDate = new DateTime(2022, 3, 20),
                        Rating = 4.8m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 11 açıklaması",
                        ShortExcerpt = "Kitap 11 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 400,
                        Width = 16,
                        Height = 23,
                        Barcode = 9876543210210
                    },
                    new Book
                    {
                        Name = "Kitap 12",
                        AuthorID = 4,
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 2 },
                            new BookCategory { CategoryID = 4 }
                        },
                        Price = 18.99m,
                        PublishDate = new DateTime(2023, 6, 5),
                        Rating = 4.0m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 12 açıklaması",
                        ShortExcerpt = "Kitap 12 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 280,
                        Width = 12,
                        Height = 18,
                        Barcode = 1234567890789
                    },
                    new Book
                    {
                        Name = "Kitap 13",
                        AuthorID = 1,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 1 },
                            new BookCategory { CategoryID = 8 }
                        },
                        Price = 29.99m,
                        PublishDate = new DateTime(2020, 12, 1),
                        Rating = 4.5m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 13 açıklaması",
                        ShortExcerpt = "Kitap 13 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 320,
                        Width = 14,
                        Height = 21,
                        Barcode = 9876543210567
                    },
                    new Book
                    {
                        Name = "Kitap 14",
                        AuthorID = 2,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 3 }
                        },
                        Price = 16.99m,
                        PublishDate = new DateTime(2021, 8, 10),
                        Rating = 4.4m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 14 açıklaması",
                        ShortExcerpt = "Kitap 14 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 300,
                        Width = 13,
                        Height = 20,
                        Barcode = 1234567890678
                    },
                    new Book
                    {
                        Name = "Kitap 15",
                        AuthorID = 3,
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 6 }
                        },
                        Price = 32.99m,
                        PublishDate = new DateTime(2022, 10, 15),
                        Rating = 4.9m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 15 açıklaması",
                        ShortExcerpt = "Kitap 15 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 420,
                        Width = 15,
                        Height = 22,
                        Barcode = 9876543210909
                    },
                    new Book
                    {
                        Name = "Kitap 16",
                        AuthorID = 4,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 2 },
                            new BookCategory { CategoryID = 3 }
                        },
                        Price = 27.99m,
                        PublishDate = new DateTime(2023, 4, 28),
                        Rating = 4.6m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 16 açıklaması",
                        ShortExcerpt = "Kitap 16 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 350,
                        Width = 14,
                        Height = 21,
                        Barcode = 1234567890432
                    },
                    new Book
                    {
                        Name = "Kitap 17",
                        AuthorID = 1,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 7 }
                        },
                        Price = 14.99m,
                        PublishDate = new DateTime(2021, 7, 15),
                        Rating = 4.3m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 17 açıklaması",
                        ShortExcerpt = "Kitap 17 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 320,
                        Width = 13,
                        Height = 19,
                        Barcode = 9876543210123
                    },
                    new Book
                    {
                        Name = "Kitap 18",
                        AuthorID = 2,
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 2 }
                        },
                        Price = 21.99m,
                        PublishDate = new DateTime(2022, 6, 1),
                        Rating = 4.7m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 18 açıklaması",
                        ShortExcerpt = "Kitap 18 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 300,
                        Width = 14,
                        Height = 21,
                        Barcode = 1234567890654
                    },
                    new Book
                    {
                        Name = "Kitap 19",
                        AuthorID = 3,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 3 }
                        },
                        Price = 19.99m,
                        PublishDate = new DateTime(2023, 3, 10),
                        Rating = 4.2m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 19 açıklaması",
                        ShortExcerpt = "Kitap 19 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 250,
                        Width = 13,
                        Height = 20,
                        Barcode = 9876543210987
                    },
                    new Book
                    {
                        Name = "Kitap 20",
                        AuthorID = 4,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 1 },
                            new BookCategory { CategoryID = 4 }
                        },
                        Price = 24.99m,
                        PublishDate = new DateTime(2022, 5, 5),
                        Rating = 4.8m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 20 açıklaması",
                        ShortExcerpt = "Kitap 20 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 400,
                        Width = 16,
                        Height = 23,
                        Barcode = 1234567890876
                    },
                    new Book
                    {
                        Name = "Kitap 21",
                        AuthorID = 1,
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 7 }
                        },
                        Price = 18.99m,
                        PublishDate = new DateTime(2021, 12, 1),
                        Rating = 4.0m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 21 açıklaması",
                        ShortExcerpt = "Kitap 21 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 280,
                        Width = 12,
                        Height = 18,
                        Barcode = 9876543210765
                    },
                    new Book
                    {
                        Name = "Kitap 22",
                        AuthorID = 2,
                        PublisherID = 3,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 3 }
                        },
                        Price = 32.99m,
                        PublishDate = new DateTime(2023, 10, 15),
                        Rating = 4.9m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 22 açıklaması",
                        ShortExcerpt = "Kitap 22 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 420,
                        Width = 15,
                        Height = 22,
                        Barcode = 1234567890654
                    },
                    new Book
                    {
                        Name = "Kitap 23",
                        AuthorID = 3,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 1 },
                            new BookCategory { CategoryID = 4 }
                        },
                        Price = 27.99m,
                        PublishDate = new DateTime(2022, 9, 10),
                        Rating = 4.6m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 23 açıklaması",
                        ShortExcerpt = "Kitap 23 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 350,
                        Width = 14,
                        Height = 21,
                        Barcode = 9876543210765
                    },
                    new Book
                    {
                        Name = "Kitap 24",
                        AuthorID = 4,
                        PublisherID = 1,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 2 }
                        },
                        Price = 14.99m,
                        PublishDate = new DateTime(2021, 7, 1),
                        Rating = 4.3m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 24 açıklaması",
                        ShortExcerpt = "Kitap 24 kısa alıntı",
                        IsHardcover = false,
                        PageNumber = 320,
                        Width = 13,
                        Height = 19,
                        Barcode = 1234567890654
                    },
                    new Book
                    {
                        Name = "Kitap 25",
                        AuthorID = 1,
                        PublisherID = 2,
                        Categories = new List<BookCategory>
                        {
                            new BookCategory { CategoryID = 3 }
                        },
                        Price = 19.99m,
                        PublishDate = new DateTime(2023, 2, 28),
                        Rating = 4.4m,
                        Picture = "https://loremflickr.com/320/240",
                        Description = "Kitap 25 açıklaması",
                        ShortExcerpt = "Kitap 25 kısa alıntı",
                        IsHardcover = true,
                        PageNumber = 300,
                        Width = 14,
                        Height = 21,
                        Barcode = 9876543210765
                    }
                };
                context.Books.AddRange(books);
                context.SaveChanges();
            }
        }

        private static void seedCategoryIfNotExist(KidegaCloneDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>() {
                    new() { Name = "Edebiyat"},
                    new() { Name = "Tarih"},
                    new() { Name = "Türk Edebiyatı"},
                    new() { Name = "Kurgu"},
                    new() { Name = "Bilim Kurgu"},
                    new() { Name = "Felsefe"},
                    new() { Name = "Bilim"},
                    new() { Name = "Sanat"}
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }

        private static void seedOrderIfNotExist(KidegaCloneDbContext context)
        { 
            if (!context.Orders.Any())
            {
                var orders = new List<Order>()
                {
                    new() {
                        AddressID = 1,
                        UserID = 1,
                        IsSuccesfullyPaid = true,
                        TotalPrice = 0,
                        Books = new List<BookOrder>() { new() { BookID= 1}, new() { BookID = 2 }, new() { BookID = 3 } }
                    },
                    new() {
                        AddressID = 3,
                        UserID = 2,
                        IsSuccesfullyPaid = true,
                        TotalPrice = 0,
                        Books = new List<BookOrder>() { new() { BookID= 4}, new() { BookID = 5 }, new() { BookID = 6 } }
                    },
                    new() {
                        AddressID = 5,
                        UserID = 3,
                        IsSuccesfullyPaid = true,
                        TotalPrice = 0,
                        Books = new List<BookOrder>() { new() { BookID= 7}, new() { BookID = 8 }, new() { BookID = 9 } }
                    }
                };
            
                context.Orders.AddRange(orders);
                context.SaveChanges();
            }

        }

        private static void seedPublisherIfNotExist(KidegaCloneDbContext context)
        {
            if (!context.Orders.Any())
            {
                var publishers = new List<Publisher>()
                {
                    new Publisher
                    {
                        Name = "Doğan Kitap"
                    },
                    new Publisher
                    {
                        Name = "İthaki Yayınları"
                    },
                    new Publisher
                    {
                        Name = "Yapı Kredi Yayınları"
                    }
                };
                context.Publishers.AddRange(publishers);
                context.SaveChanges();
            }
        }

        private static void seedReviewIfNotExist(KidegaCloneDbContext context)
        {
            if (!context.Reviews.Any())
            {
                var reviews = new List<Review>()
                {
                    new Review
                    {
                        UserID = 1,
                        BookID = 1,
                        Title = "Harika Kitap!",
                        Comment = "Bu kitap gerçekten harika. Sürükleyici bir hikayesi var ve karakterler çok etkileyici. Kesinlikle tavsiye ederim!",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 2,
                        BookID = 2,
                        Title = "Çok beğendim",
                        Comment = "Yazarın üslubu çok güzel. Kitapta anlatılan olaylar beni çok etkiledi. Okumanızı tavsiye ederim.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 3,
                        BookID = 3,
                        Title = "Mükemmel!",
                        Comment = "Bu kitap benim favorim oldu. Hiç sıkılmadan okudum ve bir solukta bitirdim. Kesinlikle almalısınız.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 4,
                        BookID = 4,
                        Title = "Başarılı Yazar",
                        Comment = "Yazarın kalemi gerçekten başarılı. Kitapta karakterlerin duygularını çok iyi yansıtmış.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 5,
                        BookID = 5,
                        Title = "İnanılmaz bir kitap",
                        Comment = "Bu kitabı okurken zamanın nasıl geçtiğini anlamadım. Harika bir hikaye ve akıcı bir anlatımı var.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 6,
                        BookID = 6,
                        Title = "Etkileyici",
                        Comment = "Kitabın konusu çok etkileyici. Okuduktan sonra uzun süre etkisinden çıkamadım.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 7,
                        BookID = 7,
                        Title = "Sürükleyici",
                        Comment = "Bu kitap sizi içine çekiyor ve sayfaları çevirmekten kendinizi alamıyorsunuz. Kesinlikle okunmalı.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 8,
                        BookID = 8,
                        Title = "Heyecan dolu",
                        Comment = "Kitapta bol bol aksiyon ve gerilim var. Sürekli merakla ne olacağını bekledim.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 9,
                        BookID = 9,
                        Title = "Büyüleyici",
                        Comment = "Yazarın diline hayran kaldım. Kitapta anlatılan dünya büyüleyici bir şekilde canlandırılmış.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 10,
                        BookID = 10,
                        Title = "Bağımlılık yaptı",
                        Comment = "Bu kitabı okurken kendimi kaybettim. Her boş vaktimde kitabı elime alıp okudum. Kesinlikle tavsiye ederim.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 1,
                        BookID = 11,
                        Title = "İlginç bir kurgu",
                        Comment = "Kitapta ilginç bir kurgu var. Sıradışı karakterler ve olaylarla dolu bir macera.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 2,
                        BookID = 12,
                        Title = "Beklentilerimi karşıladı",
                        Comment = "Bu kitabı uzun süredir bekliyordum ve beklentilerimi karşıladı. Harika bir finali var.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 3,
                        BookID = 13,
                        Title = "Eğlenceli bir kitap",
                        Comment = "Bu kitap beni güldürdü ve eğlendirdi. Yazarın mizah anlayışı çok hoşuma gitti.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 4,
                        BookID = 14,
                        Title = "Kesinlikle okunmalı",
                        Comment = "Bu kitabı okumadan geçmeyin. Sizi etkileyecek ve düşündürecek bir hikayesi var.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 5,
                        BookID = 15,
                        Title = "Büyülü bir dünya",
                        Comment = "Kitapta anlatılan dünya büyülü bir atmosfere sahip. Karakterler ve olaylar çok iyi işlenmiş.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 6,
                        BookID = 16,
                        Title = "Hızlı tempolu",
                        Comment = "Bu kitap hızlı tempolu bir macera sunuyor. Sıkılmadan okuyabilirsiniz.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 7,
                        BookID = 17,
                        Title = "Bir solukta okudum",
                        Comment = "Kitabı elime aldığımda bir daha bırakamadım. Akıcı bir anlatımı var ve sizi içine çekiyor.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 8,
                        BookID = 18,
                        Title = "Harika bir seri",
                        Comment = "Bu kitap bir serinin parçası ve seri genelindeki tüm kitapları tavsiye ederim.",
                        Rating = 5
                    },
                    new Review
                    {
                        UserID = 9,
                        BookID = 19,
                        Title = "Sıra dışı bir kitap",
                        Comment = "Bu kitap farklı bir perspektif sunuyor. Okurken düşündüm ve sorguladım.",
                        Rating = 4
                    },
                    new Review
                    {
                        UserID = 10,
                        BookID = 20,
                        Title = "Heyecan verici",
                        Comment = "Kitapta bol bol heyecan var. Olaylar birbirini hızla takip ediyor ve merak uyandırıyor.",
                        Rating = 4
                    }
                };

                context.Reviews.AddRange(reviews);
                context.SaveChanges();
            }
        }


        private static void seedUserIfNotExist(KidegaCloneDbContext context)
        {
            if (!context.Users.Any())
            {
                var users = new List<User>()
                {
                    new User
                    {
                        Name = "Ahmet",
                        Surname = "Yılmaz",
                        Email = "ahmet@example.com",
                        Password = "ahmet123",
                        Role = Role.Client,
                        PhoneNumber = "5551234567"                        
                    },
                    new User
                    {
                        Name = "Ayşe",
                        Surname = "Kaya",
                        Email = "ayse@example.com",
                        Password = "ayse123",
                        Role = Role.Client,
                        PhoneNumber = "5559876543"

                    },
                    new User
                    {
                        Name = "Mehmet",
                        Surname = "Demir",
                        Email = "mehmet@example.com",
                        Password = "mehmet123",
                        Role = Role.Client,
                        PhoneNumber = "5555678910"
                    },
                    new User
                    {
                        Name = "Zeynep",
                        Surname = "Çelik",
                        Email = "zeynep@example.com",
                        Password = "zeynep123",
                        Role = Role.Client,
                        PhoneNumber = "5551098765"
                    },
                    new User
                    {
                        Name = "Ali",
                        Surname = "Yıldırım",
                        Email = "ali@example.com",
                        Password = "ali123",
                        Role = Role.Client,
                        PhoneNumber = "5558765432"
                    },
                    new User
                    {
                        Name = "Fatma",
                        Surname = "Arslan",
                        Email = "fatma@example.com",
                        Password = "fatma123",
                        Role = Role.Client,
                        PhoneNumber = "5554321098"
                    },
                    new User
                    {
                        Name = "Mustafa",
                        Surname = "Öztürk",
                        Email = "mustafa@example.com",
                        Password = "mustafa123",
                        Role = Role.Client,
                        PhoneNumber = "5552109876"
                    },
                    new User
                    {
                        Name = "Emine",
                        Surname = "Taş",
                        Email = "emine@example.com",
                        Password = "emine123",
                        Role = Role.Client,
                        PhoneNumber = "5557654321"
                    },
                    new User
                    {
                        Name = "Hüseyin",
                        Surname = "Aksoy",
                        Email = "huseyin@example.com",
                        Password = "huseyin123",
                        Role = Role.Client,
                        PhoneNumber = "5550987654"
                    },
                    new User
                    {
                        Name = "Selin",
                        Surname = "Güneş",
                        Email = "selin@example.com",
                        Password = "selin123",
                        Role = Role.Client,
                        PhoneNumber = "5556543210"
                    },
                    new User
                    {
                        Name = "Orçun",
                        Surname = "Balatlıoğlu",
                        Email = "orcun@example.com",
                        Password = "orcun123",
                        Role = Role.Admin
                    }
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }

        private static void seedObjects(KidegaCloneDbContext context)
        {

        }

    }
}
