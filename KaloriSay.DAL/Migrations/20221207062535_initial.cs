using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaloriSay.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Boy = table.Column<double>(type: "float", maxLength: 3, nullable: false),
                    Kilo = table.Column<double>(type: "float", maxLength: 3, nullable: false),
                    Yas = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GunlukKalori = table.Column<double>(type: "float", nullable: false),
                    KayitOlmaTarihi = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2022, 12, 7, 9, 25, 34, 941, DateTimeKind.Local).AddTicks(4000)),
                    Aktivite = table.Column<int>(type: "int", nullable: false),
                    Statu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjeYoneticileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statu = table.Column<int>(type: "int", nullable: false),
                    KayitOlmaTarihi = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2022, 12, 7, 9, 25, 34, 941, DateTimeKind.Local).AddTicks(5712))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjeYoneticileri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yöneticiler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statu = table.Column<int>(type: "int", nullable: false),
                    KayitOlmaTarihi = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2022, 12, 7, 9, 25, 34, 941, DateTimeKind.Local).AddTicks(3245))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yöneticiler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Besinler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<double>(type: "float", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Porsiyon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Yag = table.Column<double>(type: "float", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    BesinResmiUzantisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BesinResim = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Besinler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalepSikayetler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Talep_Sikayet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OkunduMu = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalepSikayetler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TalepSikayetler_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciEtkilesim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    BesinID = table.Column<int>(type: "int", nullable: false),
                    AlınanMiktar = table.Column<double>(type: "float", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlınanKalori = table.Column<double>(type: "float", nullable: false),
                    Ogun = table.Column<int>(type: "int", nullable: false),
                    OgunEklenmeTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciEtkilesim", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KullaniciEtkilesim_Besinler_BesinID",
                        column: x => x.BesinID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciEtkilesim_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "ID", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "TAHIL VE EKMEK URUNLERI" },
                    { 2, "SUT VE SUT URUNLERI" },
                    { 3, "MEYVELER" },
                    { 4, "CİG SEBZELER" },
                    { 5, "YAGLI TOHUMLAR VE ATISTIRMALIKLAR" },
                    { 6, "YAGLAR" },
                    { 7, "ET URUNLERI" },
                    { 8, "KUMES HAYVANLARI" },
                    { 9, "DENIZ URUNLERI" },
                    { 10, "CORBALAR" },
                    { 11, "SALATALAR" },
                    { 12, "SEBZE YEMEKLERI" },
                    { 13, "BUHARDA VEYA HASLAMA OLARAK TUKETILECEK SEBZELER" },
                    { 14, "KAHVALTILIKLAR" },
                    { 15, "TAHIL VE KURU BAKLAGIL YEMEKLERI" }
                });

            migrationBuilder.InsertData(
                table: "ProjeYoneticileri",
                columns: new[] { "ID", "Ad", "Email", "Sifre", "Soyad", "Statu" },
                values: new object[] { 1, "projeyonetici", "projeyonetici@projeyonetici.com", "721F1B96DC57739BC6EA2F471667D7A2821BB69644F1DCC4F0599ECB6624C4D3", "projeyonetici", 1 });

            migrationBuilder.InsertData(
                table: "Yöneticiler",
                columns: new[] { "ID", "Ad", "Email", "Sifre", "Soyad", "Statu" },
                values: new object[] { 1, "admin", "admin@admin.com", "721F1B96DC57739BC6EA2F471667D7A2821BB69644F1DCC4F0599ECB6624C4D3", "admin", 1 });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Adi", "BesinResim", "BesinResmiUzantisi", "Birim", "Kalori", "Karbonhidrat", "KategoriID", "Miktar", "Porsiyon", "Protein", "Yag" },
                values: new object[,]
                {
                    { 1, "Tam Buğday Ekmeği", null, null, "g", 63.0, 1068.0, 1, 25.0, "1 dilim", 311.0, 88.0 },
                    { 2, "Çavdar Ekmeği", null, null, "g", 65.0, 1207.0, 1, 25.0, "1 dilim", 212.0, 82.0 },
                    { 3, "Tahıllı Ekmek", null, null, "g", 66.0, 1084.0, 1, 25.0, "1 dilim", 334.0, 106.0 },
                    { 4, "Kepekli Ekmek", null, null, "g", 62.0, 1195.0, 1, 25.0, "1 dilim", 22.0, 85.0 },
                    { 5, "Beyaz Ekmek", null, null, "g", 72.0, 1362.0, 1, 25.0, "1 dilim", 255.0, 1.0 },
                    { 6, "Mısır Ekmeği", null, null, "g", 62.0, 1145.0, 1, 25.0, "1 dilim", 108.0, 131.0 },
                    { 7, "Sandviç Ekmeği (Beyaz)", null, null, "g", 216.0, 4086.0, 1, 75.0, "3 dilim beyaz ekmek", 765.0, 3.0 },
                    { 8, "Sandviç Ekmeği (Tahıllı)", null, null, "g", 198.0, 3252.0, 1, 75.0, "3 dilim tahıllı ekmek", 1002.0, 318.0 },
                    { 9, "Simit", null, null, "g", 434.0, 69.0, 1, 100.0, "1 adet", 1.0, 17.0 },
                    { 10, "Yulaf Gevreği (Musli)", null, null, "g", 141.0, 3028.0, 1, 40.0, "2 yemek kaşığı", 448.0, 132.0 },
                    { 11, "Sade Mısır Gevreği (Cornﬂakes)", null, null, "g", 101.0, 2428.0, 1, 30.0, "1 su bardağı", 188.0, 3.0 },
                    { 12, "Tam Tahıllı Gevrek", null, null, "g", 124.0, 274.0, 1, 33.0, "1 su bardağı", 239.0, 112.0 },
                    { 13, "Yulaf Ezmesi", null, null, "g", 73.0, 134.0, 1, 20.0, "2 yemek kaşığı", 32.0, 126.0 },
                    { 14, "Patates", null, null, "g", 77.0, 1749.0, 1, 100.0, "1 orta boy", 205.0, 9.0 },
                    { 15, "İnek Sütü(Tam Yaglı)", null, null, "ml", 110.0, 864.0, 2, 200.0, "1 su bardağı", 567.0, 585.0 },
                    { 16, "İnek Sütü (Yarım Yaglı)", null, null, "ml", 92.0, 1084.0, 2, 200.0, "1 su bardağı", 666.0, 208.0 },
                    { 17, "İnek Sütü (Yagsız)", null, null, "ml", 76.0, 10.0, 2, 200.0, "1 su bardağı", 666.0, 1.0 },
                    { 18, "Keçi Sütü", null, null, "ml", 124.0, 10.0, 2, 200.0, "1 su bardağı", 666.0, 666.0 },
                    { 19, "Soya Sütü", null, null, "ml", 112.0, 176.0, 2, 200.0, "1 su bardağı", 4.0, 24.0 },
                    { 20, "Hindistan Cevizi Sütü", null, null, "ml", 200.0, 769.0, 2, 100.0, "1 çay bardağı", 154.0, 1849.0 },
                    { 21, "Beyaz Peynir(Yarım Yaglı İnek)", null, null, "g", 60.0, 244.0, 2, 30.0, "2 parmak kalınlığında", 235.0, 458.0 },
                    { 22, "Süzme Peynir", null, null, "g", 69.0, 105.0, 2, 30.0, "2 parmak kalınlığında", 405.0, 54.0 },
                    { 23, "Lor Peyniri", null, null, "g", 43.0, 92.0, 2, 50.0, "3 yemek kaşığı", 86.0, 21.0 },
                    { 24, "Light Kaşar Peyniri", null, null, "g", 753.0, 12.0, 2, 30.0, "2 parmak kalınlığında", 915.0, 375.0 },
                    { 25, "Labne Peyniri", null, null, "g", 955.0, 225.0, 2, 50.0, "2 yemek kaşığı", 245.0, 85.0 },
                    { 26, "Örgü Peynir", null, null, "g", 972.0, 45.0, 2, 30.0, "2 parmak kalınlığında", 8.0, 705.0 },
                    { 27, "Dil Peyniri", null, null, "g", 81.0, 6.0, 2, 30.0, "2 parmak kalınlığında", 678.0, 57.0 },
                    { 28, "Mozarella", null, null, "g", 90.0, 66.0, 2, 30.0, "2 parmak kalınlığında", 661.0, 671.0 },
                    { 29, "Hellim Peyniri", null, null, "g", 915.0, 25.0, 2, 30.0, "2 parmak kalınlığında", 713.0, 69.0 },
                    { 30, "Kefir (Yaglı)", null, null, "ml", 120.0, 10.0, 2, 200.0, "1 su bardağı", 56.0, 6.0 },
                    { 31, "Kefir (Yagsız)", null, null, "ml", 74.0, 806.0, 2, 200.0, "1 su bardağı", 682.0, 167.0 },
                    { 32, "Meyveli Kefir", null, null, "ml", 156.0, 20.0, 2, 200.0, "1 su bardağı", 54.0, 6.0 },
                    { 33, "Süzme Yoğurt", null, null, "ml", 95.0, 45.0, 2, 100.0, "1 çay bardağı", 504.0, 63.0 },
                    { 34, "Yoğurt (Yaglı)", null, null, "ml", 87.0, 358.0, 2, 100.0, "1 çay bardağı", 81.0, 45.0 },
                    { 35, "Yoğurt (Yagsız)", null, null, "ml", 53.0, 324.0, 2, 100.0, "1 çay bardağı", 917.0, 35.0 },
                    { 36, "Meyveli Yoğurt", null, null, "ml", 95.0, 1106.0, 2, 100.0, "1 çay bardağı", 66.0, 27.0 },
                    { 37, "Ayran", null, null, "ml", 76.0, 56.0, 2, 200.0, "1 su bardağı", 4.0, 4.0 },
                    { 38, "Cacık", null, null, "ml", 115.0, 11.0, 2, 200.0, "1 su bardağı", 666.0, 486.0 },
                    { 39, "Badem Sütü", null, null, "ml", 48.0, 6.0, 2, 200.0, "1 su bardağı", 1.0, 22.0 },
                    { 40, "Elma", null, null, "g", 95.0, 2513.0, 3, 182.0, "1 orta boy", 47.0, 31.0 },
                    { 41, "Armut", null, null, "g", 101.0, 2711.0, 3, 178.0, "1 orta boy", 64.0, 25.0 },
                    { 42, "Portakal", null, null, "g", 62.0, 1539.0, 3, 130.0, "1 orta boy", 123.0, 16.0 }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Adi", "BesinResim", "BesinResmiUzantisi", "Birim", "Kalori", "Karbonhidrat", "KategoriID", "Miktar", "Porsiyon", "Protein", "Yag" },
                values: new object[,]
                {
                    { 43, "Greyfurt", null, null, "g", 74.0, 1845.0, 3, 246.0, "1 orta boy", 135.0, 25.0 },
                    { 44, "Ayva", null, null, "g", 57.0, 153.0, 3, 100.0, "1 küçük boy", 4.0, 1.0 },
                    { 45, "Mandalina", null, null, "g", 40.0, 1014.0, 3, 76.0, "1 küçük boy", 62.0, 24.0 },
                    { 46, "Kivi", null, null, "g", 42.0, 1012.0, 3, 69.0, "1 orta boy", 79.0, 36.0 },
                    { 47, "Muz", null, null, "g", 105.0, 2695.0, 3, 118.0, "1 orta boy", 129.0, 39.0 },
                    { 48, "Kayısı", null, null, "g", 17.0, 389.0, 3, 35.0, "1 küçük boy", 49.0, 14.0 },
                    { 49, "Çilek", null, null, "g", 46.0, 1106.0, 3, 144.0, "1 kase", 96.0, 43.0 },
                    { 50, "Trabzon hurması", null, null, "g", 60.0, 1596.0, 3, 80.0, "1 orta boy", 48.0, 17.0 },
                    { 51, "Kiraz", null, null, "g", 87.0, 2209.0, 3, 138.0, "1 kase", 146.0, 28.0 },
                    { 52, "Vişne", null, null, "g", 52.0, 1255.0, 3, 103.0, "1 kase", 103.0, 31.0 },
                    { 53, "Kavun", null, null, "g", 54.0, 1306.0, 3, 160.0, "1 kase", 134.0, 3.0 },
                    { 54, "Karpuz", null, null, "g", 46.0, 1163.0, 3, 154.0, "1 kase", 94.0, 23.0 },
                    { 55, "Ananas", null, null, "g", 28.0, 735.0, 3, 56.0, "1 ince dilim", 3.0, 7.0 },
                    { 56, "Avakado", null, null, "g", 106.0, 563.0, 3, 66.0, "1/3 orta boy", 132.0, 968.0 },
                    { 57, "Mango", null, null, "g", 99.0, 2472.0, 3, 165.0, "1 kase", 135.0, 63.0 },
                    { 58, "Ahududu", null, null, "g", 64.0, 1469.0, 3, 123.0, "1 kase", 148.0, 8.0 },
                    { 59, "Böğürtlen", null, null, "g", 62.0, 1384.0, 3, 144.0, "1 kase", 2.0, 71.0 },
                    { 60, "Yaban Mersini", null, null, "g", 84.0, 2145.0, 3, 148.0, "1 kase", 11.0, 49.0 },
                    { 61, "Yeşil Erik", null, null, "g", 76.0, 1884.0, 3, 165.0, "1 kase", 115.0, 46.0 },
                    { 62, "Kumkuat", null, null, "g", 13.0, 302.0, 3, 13.0, "1 adet", 36.0, 16.0 },
                    { 63, "Kırmızı Erik", null, null, "g", 81.0, 2101.0, 3, 135.0, "1 kase", 97.0, 31.0 },
                    { 64, "Yenidünya", null, null, "g", 70.0, 1809.0, 3, 148.0, "1 kase", 64.0, 3.0 },
                    { 65, "İncir", null, null, "g", 37.0, 959.0, 3, 50.0, "1 orta boy", 38.0, 15.0 },
                    { 66, "Dut", null, null, "g", 60.0, 1372.0, 3, 140.0, "1 kase", 202.0, 55.0 },
                    { 67, "Üzüm", null, null, "g", 104.0, 2733.0, 3, 151.0, "1 kase", 109.0, 24.0 },
                    { 68, "Nar", null, null, "g", 72.0, 1627.0, 3, 87.0, "1/2 kase", 145.0, 102.0 },
                    { 69, "Şeftali", null, null, "g", 58.0, 1431.0, 3, 150.0, "1 orta boy", 136.0, 38.0 },
                    { 70, "Limon", null, null, "g", 17.0, 541.0, 3, 58.0, "1 orta boy", 64.0, 17.0 },
                    { 71, "Kuru İncir", null, null, "g", 47.0, 1214.0, 3, 15.0, "1 orta boy", 63.0, 18.0 },
                    { 72, "Kuru üzüm", null, null, "g", 897.0, 2375.0, 3, 30.0, "1.5 yemek kaşığı", 92.0, 14.0 },
                    { 73, "Kuru kayısı", null, null, "g", 16.0, 438.0, 3, 10.0, "1 orta boy", 24.0, 4.0 },
                    { 74, "Kuru mürdüm eriği", null, null, "g", 20.0, 537.0, 3, 10.0, "1 orta boy", 18.0, 3.0 },
                    { 75, "Kuru yaban mersini", null, null, "g", 91.0, 2413.0, 3, 30.0, "1.5 yemek kaşığı", 12.0, 4.0 },
                    { 76, "Hurma", null, null, "g", 23.0, 623.0, 3, 10.0, "1 orta boy", 2.0, 3.0 },
                    { 77, "Kuru dut", null, null, "g", 676.0, 1698.0, 3, 40.0, "2 yemek kaşığı", 88.0, 36.0 },
                    { 78, "Taze Sıkılmış Meyve Suyu", null, null, "ml", 124.0, 295.0, 3, 200.0, "1 su bardağı", 44.0, 0.0 },
                    { 79, "Domates", null, null, "g", 22.0, 478.0, 4, 123.0, "1 orta boy", 108.0, 25.0 },
                    { 80, "Çeri Domates", null, null, "g", 27.0, 58.0, 4, 149.0, "1 kase", 131.0, 3.0 },
                    { 81, "Salatalık ", null, null, "g", 15.0, 363.0, 4, 100.0, "1 orta boy", 65.0, 11.0 },
                    { 82, " Marul Kıvırcık", null, null, "g", 5.0, 1.03, 4, 36.0, " 1 kase doğranmış", 0.48999999999999999, 0.050000000000000003 },
                    { 83, "Çarliston Biber", null, null, "g", 12.0, 246.0, 4, 46.0, "1 orta boy", 76.0, 21.0 },
                    { 84, "Kırmızı Biber", null, null, "g", 37.0, 718.0, 4, 119.0, "1 orta boy", 118.0, 36.0 }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Adi", "BesinResim", "BesinResmiUzantisi", "Birim", "Kalori", "Karbonhidrat", "KategoriID", "Miktar", "Porsiyon", "Protein", "Yag" },
                values: new object[,]
                {
                    { 85, "Nane", null, null, "g", 1.0, 24.0, 4, 5.0, "1 yemek kaşığı", 6.0, 1.0 },
                    { 86, "Reyhan/Fesleğen", null, null, "g", 1.0, 23.0, 4, 10.0, "2 yemek kaşığı", 13.0, 3.0 },
                    { 87, "Dereotu", null, null, "g", 1.0, 23.0, 4, 10.0, "2 yemek kaşığı", 13.0, 3.0 },
                    { 88, "Kişniş", null, null, "g", 5.0, 99.0, 4, 5.0, "1 yemek kaşığı", 22.0, 32.0 },
                    { 89, "Biberiye", null, null, "g", 4.0, 77.0, 4, 5.0, "1 yemek kaşığı", 6.0, 18.0 },
                    { 90, "Maydanoz", null, null, "g", 1.0, 24.0, 4, 5.0, "1 yemek kaşığı", 11.0, 3.0 },
                    { 91, "Turp", null, null, "g", 19.0, 394.0, 4, 116.0, "1 kase doğranmış", 79.0, 12.0 },
                    { 92, "Roka", null, null, "g", 5.0, 73.0, 4, 20.0, "1 kase", 52.0, 13.0 },
                    { 93, "Kereviz Yaprağı", null, null, "g", 16.0, 3.0, 4, 101.0, "1 kase", 7.0, 17.0 },
                    { 94, "Karnabahar", null, null, "g", 27.0, 532.0, 4, 107.0, "1 kase doğranmış", 205.0, 3.0 },
                    { 95, "Brokoli", null, null, "g", 31.0, 604.0, 4, 91.0, "1 kase doğranmış", 257.0, 34.0 },
                    { 96, "Brüksel Lahanası", null, null, "g", 38.0, 788.0, 4, 88.0, "1 kase", 297.0, 26.0 },
                    { 97, "Beyaz Lahana", null, null, "g", 22.0, 516.0, 4, 90.0, "1 kase", 114.0, 9.0 },
                    { 98, "Kırmızı Lahana", null, null, "g", 28.0, 656.0, 4, 90.0, "1 kase", 127.0, 14.0 },
                    { 99, "Havuç", null, null, "g", 25.0, 584.0, 4, 61.0, "1 orta boy", 57.0, 15.0 },
                    { 100, "Sarımsak", null, null, "g", 4.0, 99.0, 4, 5.0, "1 diş", 19.0, 2.0 },
                    { 101, "Soğan", null, null, "g", 44.0, 1027.0, 4, 110.0, "1 orta boy", 121.0, 11.0 },
                    { 102, "Yeşil Soğan", null, null, "g", 2.0, 44.0, 4, 5.0, "1 yemek kaşığı kıyılmış", 11.0, 1.0 },
                    { 103, "Semizotu", null, null, "g", 9.0, 146.0, 4, 43.0, "1 kase", 87.0, 15.0 },
                    { 104, "Pazı", null, null, "g", 7.0, 135.0, 4, 36.0, "1 kase", 65.0, 7.0 },
                    { 105, "Kabak", null, null, "g", 33.0, 61.0, 4, 196.0, "1 orta boy", 237.0, 63.0 },
                    { 106, "Kestane (Haşlama veya Izgara)", null, null, "g", 98.0, 2209.0, 5, 50.0, "1/2 kase", 81.0, 62.0 },
                    { 107, "Patlamış Mısır (Yagsız/Tuzsuz)", null, null, "g", 76.0, 1558.0, 5, 20.0, "1 su bardağı", 24.0, 84.0 },
                    { 108, "Sarı Leblebi", null, null, "g", 71.0, 117.0, 5, 20.0, "1 çay bardağı", 373.0, 125.0 },
                    { 109, "Beyaz Leblebi", null, null, "g", 72.0, 119.0, 5, 20.0, "1 çay bardağı", 379.0, 12.0 },
                    { 110, "Fındık", null, null, "g", 97.0, 257.0, 5, 15.0, "10-12 adet", 23.0, 936.0 },
                    { 111, "Badem", null, null, "g", 97.0, 362.0, 5, 17.0, "12-14 adet", 355.0, 839.0 },
                    { 112, "Ceviz", null, null, "g", 52.0, 11.0, 5, 10.0, "1 tam adet", 122.0, 522.0 },
                    { 113, "Kabak Çekirdeği", null, null, "g", 1044.0, 268.0, 5, 20.0, "2 yemek kaşığı", 66.0, 842.0 },
                    { 114, "Çiğ Kaju", null, null, "g", 111.0, 604.0, 5, 20.0, "1 yemek kaşığı", 364.0, 877.0 },
                    { 115, "Galeta", null, null, "g", 32.0, 52.0, 5, 7.0, "1 adet", 66.0, 76.0 },
                    { 116, "Grissini", null, null, "g", 22.0, 38.0, 5, 6.0, "1 adet", 52.0, 48.0 },
                    { 117, "Grissini(ince)", null, null, "g", 22.0, 38.0, 5, 6.0, "2 adet", 52.0, 48.0 },
                    { 118, "Köfte", null, null, "g", 59.0, 24.0, 7, 30.0, "1 yumurta kadar ", 63.0, 27.0 },
                    { 119, "Biftek", null, null, "g", 756.0, 0.0, 7, 30.0, " 1 yumurta kadar", 82.0, 45.0 },
                    { 120, "Dana Antrikot ", null, null, "g", 82.0, 0.0, 7, 50.0, "1.5 yumurta kadar", 10.73, 4.0999999999999996 },
                    { 121, "Dana Kuşbaşı", null, null, "g", 651.0, 0.0, 7, 30.0, "1 yumurta kadar", 744.0, 37.0 },
                    { 122, "Yagsız Koyun Eti", null, null, "g", 70.0, 2.0, 7, 30.0, "1 yumurta kadar", 1003.0, 333.0 },
                    { 123, "Tavşan ", null, null, "g", 68.0, 0.0, 8, 50.0, "1.5 yumurta kadar ", 10.029999999999999, 2.77 },
                    { 124, "Hindi (Göğüs)", null, null, "g", 63.0, 0.0, 8, 50.0, "1.5 yumurta kadar", 1108.0, 173.0 },
                    { 125, "Hindi (But)", null, null, "g", 62.0, 0.0, 8, 30.0, "1 yumurta kadar", 836.0, 295.0 },
                    { 126, " Tavuk (Göğüs)", null, null, "g", 76.0, 0.0, 8, 50.0, " 1.5 yumurta kadar", 15.27, 1.5800000000000001 }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Adi", "BesinResim", "BesinResmiUzantisi", "Birim", "Kalori", "Karbonhidrat", "KategoriID", "Miktar", "Porsiyon", "Protein", "Yag" },
                values: new object[,]
                {
                    { 127, "Tavuk (But)", null, null, "g", 66.0, 0.0, 8, 30.0, "1 yumurta kadar", 725.0, 388.0 },
                    { 128, "Tavuk (Kanat)", null, null, "g", 61.0, 0.0, 8, 30.0, "1 yumurta kadar", 914.0, 244.0 },
                    { 129, "Yumurta (Haşlanmış)", null, null, "g", 70.0, 5.0, 8, 45.0, "1 orta boy", 566.0, 477.0 },
                    { 130, "Somon", null, null, "g", 76.0, 0.0, 9, 50.0, "1.5 yumurta kadar", 1229.0, 264.0 },
                    { 131, "Somon (Füme)", null, null, "g", 103.0, 0.0, 9, 50.0, "1.5 yumurta kadar", 1759.0, 363.0 },
                    { 132, "Light Ton Balığı", null, null, "g", 86.0, 0.0, 9, 100.0, "3 yumurta kadar", 1944.0, 96.0 },
                    { 133, "Alabalık", null, null, "g", 119.0, 0.0, 9, 71.0, "2.5 yumurta kadar", 169.0, 524.0 },
                    { 134, "Istakoz", null, null, "g", 129.0, 0.0, 9, 145.0, " 1 kase pişmiş", 2755.0, 125.0 },
                    { 135, "Levrek ", null, null, "g", 125.0, 0.0, 9, 101.0, "3 yumurta kadar ", 2387.0, 259.0 },
                    { 136, "Çupra ", null, null, "g", 120.0, 0.0, 9, 110.0, "3.5 yumurta kadar", 21.710000000000001, 3.0 },
                    { 137, "Karides", null, null, "g", 128.0, 0.0, 9, 128.0, "1 kase pişmiş", 2614.0, 174.0 },
                    { 138, "Sazan ", null, null, "g", 138.0, 0.0, 9, 85.0, "3 yumurta kadar", 1943.0, 609.0 },
                    { 139, " Mezgit", null, null, "g", 99.0, 0.0, 9, 85.0, "3 yumurta kadar ", 19.960000000000001, 1.4399999999999999 },
                    { 140, "İstavrit", null, null, "g", 156.0, 0.0, 9, 85.0, "3 yumurta kadar", 2542.0, 534.0 },
                    { 141, "Hamsi", null, null, "g", 42.0, 0.0, 9, 20.0, "5 adet", 578.0, 194.0 },
                    { 142, "Palamut", null, null, "g", 231.0, 0.0, 9, 90.0, "3 yumurta kadar", 2099.0, 1567.0 },
                    { 143, "Barbun", null, null, "g", 128.0, 0.0, 9, 85.0, "3 yumurta kadar", 2109.0, 413.0 },
                    { 144, "Kalkan", null, null, "g", 104.0, 0.0, 9, 85.0, "3 yumurta kadar", 1749.0, 321.0 },
                    { 145, "Fener", null, null, "g", 82.0, 0.0, 9, 85.0, "3 yumurta kadar", 1578.0, 166.0 },
                    { 146, "Ahtapot", null, null, "g", 139.0, 0.0, 9, 85.0, "3 yumurta kadar", 2535.0, 177.0 },
                    { 147, "Dil Balığı", null, null, "g", 73.0, 0.0, 9, 85.0, "3 yumurta kadar", 1295.0, 201.0 },
                    { 148, "Mercimek Çorbası", null, null, "g", 99.0, 963.0, 10, 180.0, "1 su bardağı/1 kepçe", 361.0, 52.0 },
                    { 149, "Tavuk Çorbası", null, null, "g", 56.0, 7.0, 10, 180.0, "1 su bardağı/1 kepçe", 302.0, 183.0 },
                    { 150, "Tarhana Çorbası ", null, null, "g", 1476.0, 265.0, 10, 180.0, "1 su bardağı/1 kepçe ", 441.0, 252.0 },
                    { 151, "Sebze Çorbası ", null, null, "g", 59.0, 10.91, 10, 180.0, "1 su bardağı/1 kepçe 1 ", 1.98, 0.81000000000000005 },
                    { 152, "Ezogelin Çorbası", null, null, "g", 936.0, 1683.0, 10, 180.0, "su bardağı/1 kepçe 1", 621.0, 3.0 },
                    { 153, "Yayla Çorbası ", null, null, "g", 117.0, 943.0, 10, 180.0, "su bardağı/1 kepçe 1", 329.0, 738.0 },
                    { 154, "Balkabağı Çorbası ", null, null, "g", 53.0, 81.0, 10, 180.0, "su bardağı/1 kepçe 1", 185.0, 183.0 },
                    { 155, "Mantar çorbası", null, null, "g", 123.0, 1032.0, 10, 180.0, "su bardağı/1 kepçe", 44.0, 715.0 },
                    { 156, "Brokoli Çorbası", null, null, "g", 156.0, 136.0, 10, 180.0, "1 su bardağı/1 kepçe", 619.0, 903.0 },
                    { 157, "Lahana Çorbası", null, null, "g", 53.0, 565.0, 10, 180.0, "1 su bardağı/1 kepçe", 288.0, 239.0 },
                    { 158, "Domates Çorbası", null, null, "g", 68.0, 1291.0, 10, 180.0, "1 su bardağı/1 kepçe", 167.0, 11.0 },
                    { 159, "Sade Salata(karışık yeşillik)", null, null, "g", 9.0, 176.0, 11, 55.0, "1 kase doğranmış", 84.0, 13.0 },
                    { 160, "Mercimekli Lor Peynirli Salata", null, null, "g", 180.0, 28.0, 11, 255.0, "1 porsiyon", 27.0, 51.0 },
                    { 161, "Tavuklu Salata", null, null, "g", 225.0, 528.0, 11, 255.0, "1 porsiyon", 3138.0, 829.0 },
                    { 162, "Etli Salata", null, null, "g", 267.0, 528.0, 11, 260.0, "1 porsiyon", 2484.0, 1649.0 },
                    { 163, "Ton Balıklı Salata", null, null, "g", 215.0, 528.0, 11, 270.0, "1 porsiyon", 2196.0, 635.0 },
                    { 164, "Kısır", null, null, "g", 108.0, 1584.0, 11, 60.0, "4 yemek kaşığı", 271.0, 464.0 },
                    { 165, "Mercimek Köftesi", null, null, "g", 70.0, 995.0, 11, 30.0, "2 yemek kaşığı", 275.0, 241.0 },
                    { 166, "Tabule Salatası", null, null, "g", 588.0, 51.0, 11, 370.0, "1 porsiyon", 144.0, 333.0 },
                    { 167, "Lor Peynirli Yumurtalı Salata", null, null, "g", 225.0, 67.0, 11, 260.0, "1 porsiyon", 1678.0, 981.0 },
                    { 168, "Ispanak Yemeği (Pirinçli veya Bulgurlu)", null, null, "g", 115.0, 509.0, 12, 100.0, "5 yemek kaşığı", 211.0, 103.0 }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Adi", "BesinResim", "BesinResmiUzantisi", "Birim", "Kalori", "Karbonhidrat", "KategoriID", "Miktar", "Porsiyon", "Protein", "Yag" },
                values: new object[,]
                {
                    { 169, "Ispanak Yemeği (Etli,Kıymalı,Yumurtalı)", null, null, "g", 1445.0, 629.0, 12, 130.0, "6 yemek kaşığı", 526.0, 1165.0 },
                    { 170, "ZeytinYaglı Semizotu (Pirinçli veya Bulgurlu)", null, null, "g", 112.0, 498.0, 12, 100.0, "5 yemek kaşığı", 129.0, 1026.0 },
                    { 171, "Semizotu Yemeği (Etli veya Kıymalı)", null, null, "g", 1415.0, 618.0, 12, 130.0, "6 yemek kaşığı", 444.0, 1100.0 },
                    { 172, "ZeytinYaglı Pazı (Pirinçli veya Bulgurlu)", null, null, "g", 131.0, 1189.0, 12, 100.0, "5 yemek kaşığı", 374.0, 718.0 },
                    { 173, "Pazı Yemeği (Etli veya Kıymalı)", null, null, "g", 160.0, 1309.0, 12, 130.0, "6 yemek kaşığı", 689.0, 853.0 },
                    { 174, "ZeytinYaglı Taze Fasülye", null, null, "g", 151.0, 2139.0, 12, 100.0, "5 yemek kaşığı", 554.0, 515.0 },
                    { 175, "Taze Fasulye Yemeği (Etli veya Kıymalı)", null, null, "g", 1805.0, 2259.0, 12, 130.0, "6 yemek kaşığı", 869.0, 65.0 },
                    { 176, "ZeytinYaglı Pırasa(Pirinçli ya da Nohutlu)", null, null, "g", 120.0, 725.0, 12, 100.0, "5 yemek kaşığı", 91.0, 1027.0 },
                    { 177, "Bezelye Yemeği (Havuçlu)", null, null, "g", 147.0, 1107.0, 12, 100.0, "5 yemek kaşığı", 348.0, 1038.0 },
                    { 178, "Bezelye Yemeği (Etli/Tavuklu/Kıymalı)", null, null, "g", 1765.0, 1227.0, 12, 130.0, "6 yemek kaşığı", 663.0, 1173.0 },
                    { 179, "ZeytinYaglı Brokoli", null, null, "g", 80.0, 714.0, 12, 100.0, "5 yemek kaşığı", 237.0, 541.0 },
                    { 180, "Brokoli Yemeği (Etli/Kıymalı)", null, null, "g", 110.0, 834.0, 12, 130.0, "6 yemek kaşığı", 552.0, 676.0 },
                    { 181, "Karnabahar Yemeği", null, null, "g", 115.0, 529.0, 12, 100.0, "5 yemek kaşığı", 148.0, 1041.0 },
                    { 182, "Karnabahar Yemeği (Etli/Tavuklu/Kıymalı)", null, null, "g", 1445.0, 645.0, 12, 130.0, "6 yemek kaşığı", 463.0, 1176.0 },
                    { 183, "Bamya Yemeği", null, null, "g", 113.0, 468.0, 12, 100.0, "5 yemek kaşığı", 106.0, 1057.0 },
                    { 184, "Bamya Yemeği (Etli/Kıymalı)", null, null, "g", 1425.0, 588.0, 12, 130.0, "6 yemek kaşığı", 421.0, 1192.0 },
                    { 185, "ZeytinYaglı Türlü", null, null, "g", 112.0, 868.0, 12, 100.0, "5 yemek kaşığı", 133.0, 887.0 },
                    { 186, "Etli Türlü Yemeği", null, null, "g", 1415.0, 988.0, 12, 130.0, "6 yemek kaşığı", 448.0, 1022.0 },
                    { 187, "ZeytinYaglı Bakla", null, null, "g", 145.0, 976.0, 12, 100.0, "5 yemek kaşığı", 332.0, 1069.0 },
                    { 188, "ZeytinYaglı Kereviz", null, null, "g", 90.0, 714.0, 12, 100.0, "5 yemek kaşığı", 192.0, 637.0 },
                    { 189, "ZeytinYaglı Enginar", null, null, "g", 146.0, 1209.0, 12, 100.0, "5 yemek kaşığı", 293.0, 1071.0 },
                    { 190, "Mantar sote (Etli/Tavuklu)", null, null, "g", 118.0, 595.0, 12, 130.0, "5 yemek kaşığı", 167.0, 1042.0 },
                    { 191, "Sebze Sote (Havuç,Yeşil kabak,brokoli)", null, null, "g", 90.0, 455.0, 12, 200.0, "10 yemek kaşığı", 94.0, 1019.0 },
                    { 192, "ZeytinYaglı Sebze Dolması", null, null, "g", 258.0, 1359.0, 12, 200.0, "1 kase kadar", 56.0, 1359.0 },
                    { 193, "ZeytinYaglı yaprak Sarma", null, null, "g", 108.0, 832.0, 12, 60.0, "3 adet", 133.0, 815.0 },
                    { 194, "Etli Sebze Dolması", null, null, "g", 358.0, 83.0, 12, 200.0, "1 kase kadar", 1867.0, 2817.0 },
                    { 195, "Etli Yaprak Sarma", null, null, "g", 176.0, 1124.0, 12, 100.0, "5-6 adet", 623.0, 1232.0 },
                    { 196, "ZeytinYaglı Kabak", null, null, "g", 111.0, 519.0, 12, 100.0, "5 yemek kaşığı", 81.0, 1018.0 },
                    { 197, "Kabak Yemeği(Etli/Kıymalı)", null, null, "g", 1405.0, 639.0, 12, 130.0, "6 yemek kaşığı", 396.0, 1153.0 },
                    { 198, "Yeşil Kabak", null, null, "g", 15.0, 269.0, 13, 100.0, "1 küçük boy", 114.0, 36.0 },
                    { 199, "Ispanak", null, null, "g", 7.0, 109.0, 13, 180.0, "1 kase haşlanmış", 86.0, 12.0 },
                    { 200, "Semizotu", null, null, "g", 7.0, 147.0, 13, 180.0, "1 kase haşlanmış", 56.0, 4.0 },
                    { 201, "Pazı", null, null, "g", 39.0, 789.0, 13, 144.0, "1 kase kıyılmış", 37.0, 28.0 },
                    { 202, "Karnabahar", null, null, "g", 29.0, 51.0, 13, 124.0, "1 kase haşlanmış", 228.0, 56.0 },
                    { 203, "Brokoli", null, null, "g", 55.0, 112.0, 13, 156.0, "1 kase haşlanmış", 371.0, 64.0 },
                    { 204, "Brüksel Lahanası", null, null, "g", 56.0, 1108.0, 13, 156.0, "1 kase haşlanmış", 398.0, 78.0 },
                    { 205, "Taze Fasülye", null, null, "g", 44.0, 985.0, 13, 125.0, "1 kase haşlanmış", 236.0, 35.0 },
                    { 206, "Havuç", null, null, "g", 55.0, 1282.0, 13, 156.0, "1 kase haşlanmış", 119.0, 28.0 },
                    { 207, "Peynirli omlet", null, null, "g", 254.0, 205.0, 14, 130.0, "2 yumurta + 1 peynir", 1537.0, 149.0 },
                    { 208, "Mantarlı omlet", null, null, "g", 205.0, 369.0, 14, 150.0, "2 yumurta", 1246.0, 99.0 },
                    { 209, "Menemen", null, null, "g", 205.0, 369.0, 14, 150.0, "2 yumurta", 1246.0, 99.0 },
                    { 210, "Kaşarlı omlet", null, null, "g", 2603.0, 22.0, 14, 130.0, "2 yumurta + 1 kaşar", 2027.0, 1329.0 }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "ID", "Adi", "BesinResim", "BesinResmiUzantisi", "Birim", "Kalori", "Karbonhidrat", "KategoriID", "Miktar", "Porsiyon", "Protein", "Yag" },
                values: new object[,]
                {
                    { 211, "Sebzeli omlet", null, null, "g", 205.0, 369.0, 14, 150.0, "2 yumurta", 1246.0, 99.0 },
                    { 212, "Yulaﬂı omlet", null, null, "g", 258.0, 144.0, 14, 120.0, "2 yumurta + 2 y.k yulaf ezmesi", 1452.0, 108.0 },
                    { 213, "Omlet Sade", null, null, "g", 185.0, 1.0, 14, 95.0, "2 yumurta", 1132.0, 149.0 },
                    { 214, "Mercimek Yemeği", null, null, "g", 1002.0, 854.0, 15, 60.0, "3 yemek kaşığı", 329.0, 622.0 },
                    { 215, "Mercimek Yemeği(Etli/Kıymalı)", null, null, "g", 160.0, 1094.0, 15, 90.0, "4 yemek kaşığı", 959.0, 892.0 },
                    { 216, "Nohut Yemeği", null, null, "g", 1014.0, 937.0, 15, 60.0, "3 yemek kaşığı", 193.0, 647.0 },
                    { 217, "Nohut Yemeği(Etli/Kıymalı)", null, null, "g", 1604.0, 1177.0, 15, 90.0, "4 yemek kaşığı", 823.0, 917.0 },
                    { 218, "Kuru Fasülye Yemeği", null, null, "g", 1014.0, 937.0, 15, 60.0, "3 yemek kaşığı", 193.0, 647.0 },
                    { 219, "Kuru Fasülye Yemeği (Etli/Kıymalı)", null, null, "g", 1604.0, 1177.0, 15, 90.0, "4 yemek kaşığı", 823.0, 917.0 },
                    { 220, "Bulgur Pilavı", null, null, "g", 80.0, 1343.0, 15, 60.0, "3 yemek kaşığı", 22.0, 157.0 },
                    { 221, "Bulgur Pilavı (Sebzeli)", null, null, "g", 108.0, 1893.0, 15, 90.0, "4 yemek kaşığı", 325.0, 207.0 },
                    { 222, "Pirinç Pilavı", null, null, "g", 75.0, 1294.0, 15, 60.0, "3 yemek kaşığı", 124.0, 194.0 },
                    { 223, "Pirinç Pilavı(Sebzeli)", null, null, "g", 103.0, 1844.0, 15, 90.0, "4 yemek kaşığı", 229.0, 244.0 },
                    { 224, "Şehriye Pilavı", null, null, "g", 774.0, 1467.0, 15, 60.0, "3 yemek kaşığı", 2.0, 196.0 },
                    { 225, "Makarna (Haşlama ve Yagsız)", null, null, "g", 744.0, 1507.0, 15, 60.0, "3 yemek kaşığı", 262.0, 58.0 },
                    { 226, "Makarna (Kıymalı)", null, null, "g", 1334.0, 1747.0, 15, 90.0, "4 yemek kaşığı", 892.0, 328.0 },
                    { 227, "Makarna(Peynirli)", null, null, "g", 1174.0, 1599.0, 15, 90.0, "4 yemek kaşığı", 1122.0, 79.0 },
                    { 228, "ZeytinYaglı Barbunya", null, null, "g", 1014.0, 937.0, 15, 60.0, "3 yemek kaşığı", 193.0, 647.0 },
                    { 229, "ZeytinYagı", null, null, "g", 45.0, 0.0, 6, 5.0, "1 tatlı kaşığı", 0.0, 5.0 },
                    { 230, "Fındık Yagı", null, null, "g", 45.0, 0.0, 6, 5.0, "1 tatlı kaşığı", 0.0, 5.0 },
                    { 231, "Ceviz Yagı", null, null, "g", 45.0, 0.0, 6, 5.0, "1 tatlı kaşığı", 0.0, 5.0 },
                    { 232, "TereYag", null, null, "g", 36.0, 0.0, 6, 5.0, "1 tatlı kaşığı", 4.0, 406.0 },
                    { 233, "Zeytin (Yeşil/Siyah)", null, null, "g", 45.0, 248.0, 6, 40.0, "4-5 adet", 33.0, 423.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_KategoriID",
                table: "Besinler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciEtkilesim_BesinID",
                table: "KullaniciEtkilesim",
                column: "BesinID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciEtkilesim_KullaniciID",
                table: "KullaniciEtkilesim",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_Email",
                table: "Kullanicilar",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjeYoneticileri_Email",
                table: "ProjeYoneticileri",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TalepSikayetler_KullaniciID",
                table: "TalepSikayetler",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Yöneticiler_Email",
                table: "Yöneticiler",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KullaniciEtkilesim");

            migrationBuilder.DropTable(
                name: "ProjeYoneticileri");

            migrationBuilder.DropTable(
                name: "TalepSikayetler");

            migrationBuilder.DropTable(
                name: "Yöneticiler");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
