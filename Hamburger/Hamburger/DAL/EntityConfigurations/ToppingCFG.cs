using Hamburger.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hamburger.DAL.EntityConfigurations
{
    public class ToppingCFG : IEntityTypeConfiguration<Topping>
    {
        public void Configure(EntityTypeBuilder<Topping> builder)
        {
            builder.HasData(
                new Topping { ID=1,ToppingName="Domates",Price=4.99M},
                new Topping { ID=2,ToppingName="Salatalık Turşusu",Price=5.99M},
                new Topping { ID=3,ToppingName="Soğan",Price=3.99M},
                new Topping { ID=4,ToppingName="Marul",Price=2.99M},
                new Topping { ID=5,ToppingName="Cheddar Peyniri",Price=6.99M},
                new Topping { ID=6,ToppingName="Trüf Mantarı",Price=7.99M},
                new Topping { ID=7,ToppingName="Çıtır Soğan",Price=5.99M},
                new Topping { ID=8,ToppingName="Ketçap",Price=1.99M},
                new Topping { ID=9,ToppingName="Mayonez",Price=1.99M},                
                new Topping { ID=10,ToppingName="Steakhouse Burger Sos",Price=1.99M},                
                new Topping { ID=11,ToppingName="BigKing Burger Sos",Price=1.99M},                
                new Topping { ID=12,ToppingName="Soğan Halkaları",Price=3.99M},                
                new Topping { ID=13,ToppingName="Barbekü Sos",Price=2.99M},                
                new Topping { ID=14,ToppingName="Spicy Sos",Price=2.99M},                
                new Topping { ID=15,ToppingName="Tartar Sos",Price=2.99M},                
                new Topping { ID=16,ToppingName="Hardal Sos",Price=2.99M}   
                
                );
        }
    }
}
