using System;
namespace Arrows;

public class Arrow
{
    //TODO: use Enums - done
    public int HeadType;
    public int FletchingType;
    public int _length;


    public Arrow(int arrowhead_type, int fletching_type, int length)
    {
        HeadType = arrowhead_type;
        FletchingType = fletching_type;
        _length = length;
        
    }

    //TODO: add GetCost

    

}

