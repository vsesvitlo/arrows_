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


        Arrow check1 = new Arrow(2, 1, 101);
        var condition1 = check1._length == 100;
        Assert.True(condition1);

    }
}
