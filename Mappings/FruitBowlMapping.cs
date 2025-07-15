using Riok.Mapperly.Abstractions;

namespace MapperlyTest.Mappings;

[Mapper]
public partial class FruitBowlMapping
{
    //[MapDerivedType(typeof(Apple), typeof(AppleDto))]
    //[MapDerivedType(typeof(Banana), typeof(BananaDto))]
    public partial FruitBowlDto Map(FruitBowl fruitBowl);
}
