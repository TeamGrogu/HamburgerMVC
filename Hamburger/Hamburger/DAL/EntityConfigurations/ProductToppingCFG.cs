using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
    public class ProductToppingCFG : IEntityTypeConfiguration<ProductTopping>
    {
        public void Configure(EntityTypeBuilder<ProductTopping> builder)
        {
            builder.HasData(
                new ProductTopping { ID=1,ProductID=101,ToppingID=1},
                new ProductTopping { ID=2,ProductID=101,ToppingID=2},
                new ProductTopping { ID=3,ProductID=101,ToppingID=3},
                new ProductTopping { ID=4,ProductID=101,ToppingID=4},
                new ProductTopping { ID=5,ProductID=101,ToppingID=8},
                new ProductTopping { ID=6,ProductID=101,ToppingID=9},
                new ProductTopping { ID=7,ProductID=102,ToppingID=4},
                new ProductTopping { ID=8,ProductID=102,ToppingID=9},
                new ProductTopping { ID=9,ProductID=103,ToppingID=1},
                new ProductTopping { ID=10,ProductID=103,ToppingID=9},
                new ProductTopping { ID=11,ProductID=103,ToppingID=5},
                new ProductTopping { ID=12,ProductID=103,ToppingID=4},
                new ProductTopping { ID=13,ProductID=103,ToppingID=7},
                new ProductTopping { ID=14,ProductID=103,ToppingID=10},
                new ProductTopping { ID=15,ProductID=104,ToppingID=5},
                new ProductTopping { ID=16,ProductID=104,ToppingID=2},
                new ProductTopping { ID=17,ProductID=104,ToppingID=4},
                new ProductTopping { ID=18,ProductID=104,ToppingID=3},
                new ProductTopping { ID=19,ProductID=104,ToppingID=11},
                new ProductTopping { ID=20,ProductID=105,ToppingID=4},
                new ProductTopping { ID=21,ProductID=105,ToppingID=9},
                new ProductTopping { ID=22,ProductID=105,ToppingID=12},
                new ProductTopping { ID=23,ProductID=105,ToppingID=13},
                new ProductTopping { ID=24,ProductID=105,ToppingID=5},
                new ProductTopping { ID=25,ProductID=106,ToppingID=2},
                new ProductTopping { ID=26,ProductID=106,ToppingID=8},
                new ProductTopping { ID=27,ProductID=106,ToppingID=9},
                new ProductTopping { ID=28,ProductID=106,ToppingID=4},
                new ProductTopping { ID=29,ProductID=106,ToppingID=1},
                new ProductTopping { ID=30,ProductID=106,ToppingID=3},
                new ProductTopping { ID=31,ProductID=107,ToppingID=2},
                new ProductTopping { ID=32,ProductID=107,ToppingID=8},
                new ProductTopping { ID=33,ProductID=107,ToppingID=9},
                new ProductTopping { ID=34,ProductID=107,ToppingID=4},
                new ProductTopping { ID=35,ProductID=107,ToppingID=1},
                new ProductTopping { ID=36,ProductID=107,ToppingID=3},
                new ProductTopping { ID=37,ProductID=108,ToppingID=1},
                new ProductTopping { ID=38,ProductID=108,ToppingID=14},
                new ProductTopping { ID=39,ProductID=108,ToppingID=4},
                new ProductTopping { ID=40,ProductID=109,ToppingID=4},
                new ProductTopping { ID=41,ProductID=109,ToppingID=15},
                new ProductTopping { ID=42,ProductID=110,ToppingID=2},
                new ProductTopping { ID=43,ProductID=110,ToppingID=16},
                new ProductTopping { ID=44,ProductID=110,ToppingID=5},
                new ProductTopping { ID=45,ProductID=110,ToppingID=8}
                );
        }
    }
}
