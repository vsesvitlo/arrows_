using Arrows;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

        Arrow check = new Arrow(1, 1, 60);
        var condition = check._length == 60;
        Assert.True(condition);

        
    }
}
