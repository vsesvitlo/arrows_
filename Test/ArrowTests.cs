using Arrows;

namespace Test;

public class ArrowTests
{
    [Fact]
    public void TestLength60()
    {
        //TODO: one check in one method
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Goose, 60);
        Assert.Equal(60, check._length);
    }

    [Fact]
    public void TestLength100()
    {
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Goose, 100);
        Assert.Equal(100, check._length);
    }

    [Fact]
    public void TestLength90()
    {
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Goose, 90);
        Assert.Equal(90, check._length);
    }
    [Fact]
    public void TestHeadWood()
    {
        Arrow check = new Arrow(HeadType.Wood, FletchingType.Turkey, 96);
        Assert.Equal(HeadType.Wood, check._arrowhead_type);
    }
    [Fact]
    public void TestHeadSteel()
    {
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Turkey, 97);
        Assert.Equal(HeadType.Steel, check._arrowhead_type);
    }
    [Fact]
    public void TestHeadObsidian()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Turkey, 65);
        Assert.Equal(HeadType.Obsidian, check._arrowhead_type);
    }
    [Fact]
    public void TestFletchPlactic()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Plastic, 76);
        Assert.Equal(FletchingType.Plastic, check._fletching_type);
    }
    [Fact]
    public void TestFletchTurkey()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Turkey, 78);
        Assert.Equal(FletchingType.Turkey, check._fletching_type);
    }
    [Fact]
    public void TestFletchGoose()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Goose, 88);
        Assert.Equal(FletchingType.Goose, check._fletching_type);
    }
}
