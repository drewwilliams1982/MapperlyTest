using Riok.Mapperly.Abstractions;

namespace MapperlyTest.Mappings;

[Mapper]
public partial class FruitBowlShopMapping : MappingBase
{
    public partial FruitBowlShopDto Map(FruitBowlShop fruitBowlShop);
}
