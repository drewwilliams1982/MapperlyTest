using Riok.Mapperly.Abstractions;

namespace MapperlyTest.Mappings;

[Mapper(AllowNullPropertyAssignment = false)]
public partial class FruitMapping
{
    [MapDerivedType(typeof(Apple), typeof(AppleDto))]
    [MapDerivedType(typeof(Pear), typeof(PearDto))]
    [MapDerivedType(typeof(Banana), typeof(BananaDto))]
    public partial FruitDto Map(Fruit fruit);

    [MapDerivedType(typeof(AppleDto), typeof(Apple))]
    [MapDerivedType(typeof(PearDto), typeof(Pear))]
    [MapDerivedType(typeof(BananaDto), typeof(Banana))]
    public partial void Map(FruitDto fruit, Fruit destination);
}
