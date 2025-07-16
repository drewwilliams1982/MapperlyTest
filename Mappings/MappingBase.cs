namespace MapperlyTest.Mappings;

public class MappingBase
{
    public static IEnumerable<FruitDto> FruitsMapping(IEnumerable<Fruit> fruits)
    {
        FruitMapping fruitMapping = new();

        return fruits.Select(fruit => fruitMapping.Map(fruit));
    }

    public static IEnumerable<FruitBowlDto> XYZFruitBowlsMapping(IEnumerable<FruitBowl> fruitBowls)
    {
        FruitBowlMapping fruitBowlMapping = new();

        return fruitBowls.Select(fruitBowlMapping.Map);
    }
}
