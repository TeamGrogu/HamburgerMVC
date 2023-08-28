using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Hamburger.DAL.EntityConfigurations
{
    public class MenuCFG : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu { ID = 1, MenuName = "Whopper Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/whopper-menu.png?v=285", Description = "Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Burger klasiği. Enfes patates kızartması ve içeceğiyle birlikte Whopper® Menü keyfini istediğin gibi yaşa!", Price = 189.99M },
           new Menu { ID = 2, MenuName = "Rodeo Whopper Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/rodeo-whopper-menu.png?v=285", Description = "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve cheddar peynirinden oluşan Whopper lezzeti. Enfes patates kızartması ve içeceğiyle birlikte Rodeo Whopper® Menü keyfini istediğin gibi yaşa!", Price = 189.99M },
           new Menu { ID = 3, MenuName = "Whopper Jr. Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/whopper-jr-menu.png?v=285", Description = "Hamburger eti, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan, Whopper lezzetinden vazgeçemeyenlere nefis bir seçim. Enfes patates kızartması ve içeceğiyle birlikte Whopper Jr. Menü keyfini istediğin gibi yaşa!", Price = 159.99M },
           new Menu { ID = 4, MenuName = "Fish Royale Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/fish-royale-menu.png?v=285", Description = "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ve Burger klasiğine lezzetini veren tartar sosun birleşimi olan Fish Royale®, balık eti sevenlerin tercihi olacak. Enfes patates kızartması ve içeceği ile istediğin gibi yaşa!", Price = 169.99M },
           new Menu { ID = 5, MenuName = "King Chicken Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/king-chicken-menu.png?v=285", Description = "King Chicken eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan bu son derece sade alternatifi, enfes patates kızartması ve içeceğiyle birlikte istediğin gibi yaşa!", Price = 169.99M },
           new Menu { ID = 6, MenuName = "Steakhouse Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/bk-steakhouse-burger-menu.png?v=285", Description = "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte BK Steakhouse Burger® Menü keyfini istediğin gibi yaşa!", Price = 209.99M },
           new Menu { ID = 7, MenuName = "Double King Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/double-big-king-menu.png?v=285", Description = "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King sosun birleşimi. Enfes patates kızartması ve içeceğiyle birlikte Double Menü keyfini istediğin gibi yaşa", Price = 219.99M },
           new Menu { ID = 8, MenuName = "Double Whopper Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/double-whopper-menu.png?v=285", Description = "İki adet Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğanla, klasik Whopper® lezzetini ikiye katlamak için ideal. Enfes patates kızartması ve içeceğiyle birlikte Double Whopper Menü keyfini istediğin gibi yaşa!", Price = 210.99M },
           new Menu { ID = 9, MenuName = "Spicy Gurme Tavuk Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/spicy-gurme-tavuk-menu.png?v=285", Description = "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte Spicy Gurme Tavuk Menü keyfini istediğin gibi yaşa!", Price = 170.99M },
           new Menu { ID = 10, MenuName = "Mega Double Cheeseburger Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/mega-double-cheeseburger-menu.png?v=285", Description = "2 adet Whopper eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, cheddar peyniri, hardal ve ketçaptan oluşan oluşan lezzet. Enfes patates kızartması ve içeceğiyle birlikte Mega Double Cheeseburger Menü keyfini istediğin gibi yaşa!", Price = 170.99M },
           new Menu { ID = 11, MenuName = "6 lı Nuggets Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/6li-bk-king-nuggets-menu.png?v=285", Description = "Enfes patates kızartması ve içeceğiyle birlikte 6'lı Nuggets Menü keyfini istediğin gibi yaşa!", Price = 100.99M },
           new Menu { ID = 12, MenuName = "6 lı Tenders Menü", MenuImage = "https://www.burgerking.com.tr/cmsfiles/products/6li-chicken-tenders-menu-1.png?v=285", Description = "Enfes patates kızartması ve içeceğiyle birlikte 9'lu Nuggets Menü keyfini istediğin gibi yaşa!", Price = 130.99M }


                );
           
        }
    }
}
