using System;
namespace Arrows;

public class Arrow
{
    public HeadType _arrowhead_type;
    public FletchingType _fletching_type;
    public float _length;

    public Arrow(HeadType arrowhead_type, FletchingType fletching_type, float length)
    {
        _arrowhead_type = arrowhead_type;
        _fletching_type = fletching_type;
        _length = length;
    }
}





