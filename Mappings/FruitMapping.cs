using Riok.Mapperly.Abstractions;

namespace MapperlyTest.Mappings;

[Mapper]
public partial class FruitMapping
{
    [MapDerivedType(typeof(Apple), typeof(AppleDto))]
    [MapDerivedType(typeof(Banana), typeof(BananaDto))]
    public partial FruitDto Map(Fruit fruit);
}
