using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
    public class ProductCFG : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { ID = 101, ProductName = "Whopper Burger", CategoryID = 1, Description = "Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Burger King® klasiği.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/whopper.png?v=285", Price = 134.99M },
                new Product { ID = 102, ProductName = "King Chicken Burger", CategoryID = 1, Description = "King Chicken eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan son derece sade bir lezzet alternatifi.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/king-chicken-1.png?v=285", Price = 124.99M },
                new Product { ID = 103, ProductName = "Steakhouse Burger", CategoryID = 1, Description = "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/bk-steakhouse-burger.png?v=285", Price = 174.99M },
                new Product { ID = 104, ProductName = "Double Big King Burger", CategoryID = 1, Description = "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King® sosun birleşimi", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/double-big-king.png?v=285", Price = 184.99M },
                new Product { ID = 105, ProductName = "Rodeo Whopper Burger", CategoryID = 1, Description = "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve 2 adet cheddar peynirinden oluşan Whopper® lezzeti.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/rodeo-whopper.png?v=285", Price = 159.99M },
                new Product { ID = 106, ProductName = "Double Whopper Burger", CategoryID = 1, Description = "İki adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğanla klasik Whopper® lezzetini ikiye katlamak için ideal.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/double-whopper-1.png?v=285", Price = 194.99M },
                new Product { ID = 107, ProductName = "Whopper Jr. Burger", CategoryID = 1, Description = "Hamburger eti, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan, Whopper® lezzetinden vazgeçemeyenlere nefis bir seçim.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/whopper-jr.png?v=285", Price = 119.99M },
                new Product { ID = 108, ProductName = "Spicy Gurme Burger", CategoryID = 1, Description = "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir lezzet.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/spicy-gurme-tavuk.png?v=285", Price = 129.99M },
                new Product { ID = 109, ProductName = "Fish Royale Burger", CategoryID = 1, Description = "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ile burger klasiğine lezzetini veren tartar sosun birleşimi.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/fish-royale-1.png?v=285", Price = 159.99M },
                new Product { ID = 110, ProductName = "Mega Double CheeseBurger", CategoryID = 1, Description = "2 adet Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, 4 adet cheddar peyniri, hardal ve ketçaptan oluşan lezzet.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mega-double-cheeseburger.png?v=285", Price = 159.99M },
                new Product { ID = 201, ProductName = "Patates", CategoryID = 2, Description = "Doğal, soyulmuş, gevrek kızarmış patates", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/patates.png?v=285", Price = 59.99M },
                new Product { ID = 202, ProductName = "Tırtıklı  Patates", CategoryID = 2, Description = "Çıtır Mı Çıtır Altın Sarısı Tırtıklı Patates", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/tirtikli-patates.png?v=285", Price = 69.99M },
                new Product { ID = 203, ProductName = "Soğan Halkası", CategoryID = 2, Description = "Çıtır çıtır 8’li, 12’li ya da 16’lı Soğan Halka lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/sogan-halkasi.png?v=285", Price = 79.99M },
                new Product { ID = 204, ProductName = "Çıtır Peynir", CategoryID = 2, Description = "Dışı çıtır çıtır, içi sıcacık peyniriyle Çıtır Peynir!", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/citir-peynir.png?v=285", Price = 75.99M },
                new Product { ID = 205, ProductName = "Çıtır Nuggets", CategoryID = 2, Description = "Dışı çıtır çıtır Nuggets...", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/bk-king-nuggets-1.png?v=285", Price = 75.99M },
                new Product { ID = 206, ProductName = "Çıtır Tavuk Tenders", CategoryID = 2, Description = "Özel harcıyla nar gibi kızarmış  beyaz tavuk eti.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/chicken-tenders.png?v=285", Price = 85.99M },
                new Product { ID = 301, ProductName = "Fuse Tea", CategoryID = 3, Description = "Şeftalili Fuse Tea ve Limonlu Fuse Tea seçenekleri ile", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/fuse-tea.png?v=285", Price = 35.99M },
                new Product { ID = 302, ProductName = "Coca Cola", CategoryID = 3, Description = "Cola cola ", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/coca-cola.png?v=285", Price = 35.99M },
                new Product { ID = 303, ProductName = "Coca Cola Zero", CategoryID = 3, Description = "Cola cola Zero ", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/coca-cola-zero-sugar.png?v=285", Price = 35.99M },
                new Product { ID = 304, ProductName = "Fanta", CategoryID = 3, Description = "Fanta", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/fanta.png?v=285", Price = 35.99M },
                new Product { ID = 305, ProductName = "Sprite", CategoryID = 3, Description = "Sprite", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/sprite.png?v=285", Price = 35.99M },
                new Product { ID = 306, ProductName = "Ayran", CategoryID = 3, Description = "Ayran", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/ayran-300-ml.png?v=285", Price = 35.99M },
                new Product { ID = 307, ProductName = "Cappy Elma Suyu", CategoryID = 3, Description = "Elma Suyu", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/elma-suyu.png?v=285", Price = 35.99M },
                new Product { ID = 308, ProductName = "Cappy Atom", CategoryID = 3, Description = "Atom Suyu", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/cappy-atom-200-ml.png?v=285", Price = 35.99M },
                new Product { ID = 309, ProductName = "Espresso", CategoryID = 3, Description = "Kahve Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/espresso.png?v=285", Price = 35.99M },
                new Product { ID = 310, ProductName = "Filtre Kahve", CategoryID = 3, Description = "Kahve Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/nescafe-black.png?v=285", Price = 35.99M },
                new Product { ID = 311, ProductName = "Çay", CategoryID = 3, Description = "Karadeniz Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/cay.png?v=285", Price = 35.99M },
                new Product { ID = 312, ProductName = "Cappuccino", CategoryID = 3, Description = "İtalyan Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/vanilyali-cappuccino.png?v=285", Price = 35.99M },
                new Product { ID = 313, ProductName = "Sıcak Çikolata", CategoryID = 3, Description = "Çikolata Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/nestle-sicak-cikolata.png?v=285", Price = 35.99M },
                new Product { ID = 401, ProductName = "Çikolatalı Cookie", CategoryID = 4, Description = "Çikolata Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/cikolatali-cookie.png?v=285", Price = 45.99M },
                new Product { ID = 402, ProductName = "Sufle", CategoryID = 4, Description = "Çikolata Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/sufle.png?v=285", Price = 45.99M },
                new Product { ID = 403, ProductName = "Vişneli Tatlı", CategoryID = 4, Description = "Vişne Lezzeti", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/visneli-tatli.png?v=285", Price = 55.99M },
                new Product { ID = 404, ProductName = "Espresso Milkshake", CategoryID = 4, Description = "Vanilyalı, Çilekli, Çikolatalı, Espressolu, Limonlu çeşitleriyle.", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/espressolu-milkshake.png?v=285", Price = 55.99M },
                
                new Product { ID = 405, ProductName = "King Sundae", CategoryID = 4, Description = "Vanilyalı, Çikolata Soslu, Böğürtlen Soslu, Karamel Soslu, Çilek Soslu, Limonlu", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/king-sundae.png?v=285", Price = 65.99M },
                new Product { ID = 406, ProductName = "Bkool", CategoryID = 4, Description = "Çikolata Parçacıklı, Renkli Çikolata Drajeleri, Limonlu", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/bkool.png?v=285", Price = 75.99M },
                new Product { ID = 501, ProductName = "Mini Acı Sos", CategoryID = 5, Description = "Acı Sos", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mini-aci-sos.png?v=285", Price = 10.99M },
                new Product { ID = 502, ProductName = "Mayonez", CategoryID = 5, Description = "Mayonez", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mini-mayonez.png?v=285", Price = 10.99M },
                new Product { ID = 503, ProductName = "Mini Ranch", CategoryID = 5, Description = "Ranch Sos", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mini-ranch.png?v=285", Price = 10.99M },
                new Product { ID = 504, ProductName = "Sarımsaklı Sos", CategoryID = 5, Description = "Sarımsaklı Sos", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mini-sarimsakli-mayonez-1.png?v=285", Price = 10.99M },
                new Product { ID = 505, ProductName = "Mini Ketçap", CategoryID = 5, Description = "Mini Ketçap", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mini-ketcap.png?v=285", Price = 10.99M },
                new Product { ID = 506, ProductName = "Buffalo Sos", CategoryID = 5, Description = "Buffalo Sos", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mini-buffalo-1.png?v=285", Price = 10.99M },
                new Product { ID = 507, ProductName = "Mini BBQ", CategoryID = 5, Description = "Mini BBQ", ProductImage = "https://www.burgerking.com.tr/cmsfiles/products/mini-bbq.png?v=285", Price = 10.99M }




                );
        }
    }
}
