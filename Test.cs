using MapperlyTest.Mappings;
using Xunit;

namespace MapperlyTest;

public class Test
{
    [Fact]
    public void Properties_Should_Be_Mapped_To_An_Existing_Object() 
    {
        var banana = new Banana
        {
            CurveDegrees = 30,
            Colour = "Yellow",
            Length = 20
        };

        var dto = new BananaDto
        {
            Length = 10
        };

        var m = new FruitMapping();
        m.Map(dto, banana);

        Assert.Equal(30, banana.CurveDegrees);
        Assert.Equal(10, banana.Length);
        Assert.Equal("Yellow", banana.Colour);
    }
}
