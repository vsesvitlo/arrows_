using System;
namespace Arrows_new_new;

public class Arrow
{
    //TODO: use Enums
    public int _arrowhead_type;
    public int _fletching_type;
    public int _length;


    public Arrow(int arrowhead_type, int fletching_type, int length)
    {
        _arrowhead_type = arrowhead_type;
        _fletching_type = fletching_type;
        _length = length;

    }

    //TODO: add GetCost
}

