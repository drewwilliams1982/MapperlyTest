namespace MapperlyTest;

public abstract class Fruit
{
    public string Colour { get; set; }
}
public class Apple : Fruit
{
    public int NumberOfPips { get; set; }
}

public class Banana : Fruit
{
    public int Length { get; set; }
}

public class FruitBowl
{
    public IEnumerable<Fruit> Fruits { get; set; }
}

public class FruitBowlShop
    {
    public IEnumerable<FruitBowl> FruitBowls { get; set; }
}