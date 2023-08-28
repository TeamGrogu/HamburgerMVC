using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
    public class MenuProductCFG : IEntityTypeConfiguration<MenuProduct>
    {
        public void Configure(EntityTypeBuilder<MenuProduct> builder)
        {
            builder.HasData(
                new MenuProduct { ID=1,MenuID=1,ProductID=101},
                new MenuProduct { ID=2,MenuID=1,ProductID=201},
                new MenuProduct { ID=3,MenuID=1,ProductID=302},
                new MenuProduct { ID=4,MenuID=2,ProductID=105},
                new MenuProduct { ID=5,MenuID=2,ProductID=201},
                new MenuProduct { ID=6,MenuID=2,ProductID=302},
                new MenuProduct { ID=7,MenuID=3,ProductID=107},
                new MenuProduct { ID=8,MenuID=3,ProductID=201},
                new MenuProduct { ID=9,MenuID=3,ProductID=302},
                new MenuProduct { ID=10,MenuID=4,ProductID=109},
                new MenuProduct { ID=11,MenuID=4,ProductID=201},
                new MenuProduct { ID=12,MenuID=4,ProductID=302},
                new MenuProduct { ID=13,MenuID=5,ProductID=102},
                new MenuProduct { ID=14,MenuID=5,ProductID=201},
                new MenuProduct { ID=15,MenuID=5,ProductID=302},
                new MenuProduct { ID=16,MenuID=6,ProductID=103},
                new MenuProduct { ID=17,MenuID=6,ProductID=201},
                new MenuProduct { ID=18,MenuID=6,ProductID=302},
                new MenuProduct { ID=19,MenuID=7,ProductID=104},
                new MenuProduct { ID=20,MenuID=7,ProductID=201},
                new MenuProduct { ID=21,MenuID=7,ProductID=302},
                new MenuProduct { ID=22,MenuID=8,ProductID=106},
                new MenuProduct { ID=23,MenuID=8,ProductID=201},
                new MenuProduct { ID=24,MenuID=8,ProductID=302},
                new MenuProduct { ID=25,MenuID=9,ProductID=108},
                new MenuProduct { ID=26,MenuID=9,ProductID=201},
                new MenuProduct { ID=27,MenuID=9,ProductID=302},
                new MenuProduct { ID=28,MenuID=10,ProductID=110},
                new MenuProduct { ID=29,MenuID=10,ProductID=201},
                new MenuProduct { ID=30,MenuID=10,ProductID=302},
                new MenuProduct { ID=31,MenuID=11,ProductID=205},
                new MenuProduct { ID=32,MenuID=11,ProductID=201},
                new MenuProduct { ID=33,MenuID=11,ProductID=302},
                new MenuProduct { ID=34,MenuID=12,ProductID=206},
                new MenuProduct { ID=35,MenuID=12,ProductID=201},
                new MenuProduct { ID=36,MenuID=12,ProductID=302}              
                
                );
        }
    }
}
