using Arrows;

namespace Test;

public class ArrowTests
{
    [Fact]
    public void TestLength60()
    {
        //TODO: one check in one method
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Goose, 60);
        var condition = check._length == 60;
        Assert.True(condition);
    }

    [Fact]
    public void TestLength100()
    {
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Goose, 100);
        var condition = check._length == 100;
        Assert.True(condition);
    }

    [Fact]
    public void TestLength90()
    {
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Goose, 90);
        var condition = check._length == 90;
        Assert.True(condition);
    }
    [Fact]
    public void TestHeadWood()
    {
        Arrow check = new Arrow(HeadType.Wood, FletchingType.Turkey, 96);
        var condition = check._arrowhead_type == HeadType.Wood;
        Assert.True(condition);
    }
    [Fact]
    public void TestHeadSteel()
    {
        Arrow check = new Arrow(HeadType.Steel, FletchingType.Turkey, 97);
        var condition = check._arrowhead_type == HeadType.Steel;
        Assert.True(condition);
    }
    [Fact]
    public void TestHeadObsidian()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Turkey, 65);
        var condition = check._arrowhead_type == HeadType.Obsidian;
        Assert.True(condition);
    }
    [Fact]
    public void TestFletchPlactic()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Plastic, 76);
        var condition = check._fletching_type == FletchingType.Plastic;
        Assert.True(condition);
    }
    [Fact]
    public void TestFletchTurkey()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Turkey, 78);
        var condition = check._fletching_type == FletchingType.Turkey;
        Assert.True(condition);
    }
    [Fact]
    public void TestFletchGoose()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Goose, 88);
        var condition = check._fletching_type == FletchingType.Goose;
        Assert.True(condition);
    }
    /*[Fact]
    public void TestSum()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Goose, 88);
        var condition = check.GetCost() == 12.4f; // 5 + 3 + 88 * 0.05f; 
        Assert.True(condition);
    }
    [Fact]
    public void TestSum60()
    {
        Arrow check = new Arrow(HeadType.Obsidian, FletchingType.Goose, 60);
        var condition = check.GetCost() == 11f; // 5 + 3 + 60 * 0.05f; 
        Assert.True(condition);
    }*/
}
