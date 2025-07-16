using Riok.Mapperly.Abstractions;

namespace MapperlyTest.Mappings;

[Mapper]
public partial class FruitBowlMapping : MappingBase
{
    public partial FruitBowlDto Map(FruitBowl fruitBowl);
}
