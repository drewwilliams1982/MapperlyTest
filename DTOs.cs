namespace MapperlyTest;

public abstract class FruitDto
{
    // Nullable for the AllowNullPropertyAssignment feature
    public string? Colour { get; set; }
}

public abstract class PippedFruitDto : FruitDto
{
    public int NumberOfPips { get; set; }
}

public class AppleDto : PippedFruitDto
{
    public string Variety { get; set; }
}

public class PearDto : PippedFruitDto
{
    public bool CiderQuality { get; set; }
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