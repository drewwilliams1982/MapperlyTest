namespace MapperlyTest;

public abstract class FruitDto
{
    public string Colour { get; set; }
}

public class AppleDto : FruitDto
{
    public int NumberOfPips { get; set; }
}

public class BananaDto : FruitDto
{
    public int Length { get; set; }
}

public class FruitBowlDto
{
    public IEnumerable<FruitDto> Fruits { get; set; }
}

public class FruitBowlShopDto
{
    public IEnumerable<FruitBowlDto> FruitBowls { get; set; }
}