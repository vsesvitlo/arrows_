using System;
namespace Arrows;

public class Arrow
{
    //TODO: use Enums - done


    public HeadType _arrowhead_type;
    public FletchingType _fletching_type;
    public float _length;


    public Arrow(HeadType arrowhead_type, FletchingType fletching_type, float length)
    {
        _arrowhead_type = arrowhead_type;
        _fletching_type = fletching_type;
        _length = length;
    }

    //TODO: add GetCost - done

   public float GetCost()
    {
        //Arrow arrow = new Arrow(HeadType._arrowhead_type, this.FletchingType, _length);

        Console.WriteLine((this._arrowhead_type, this._fletching_type, _length));
        int headTypeArrResult = (int)this._arrowhead_type;
        int fletchTypeArrResult = (int)this._fletching_type;

        float sum = headTypeArrResult + fletchTypeArrResult + _length;
        //Console.WriteLine(sum);
        return sum;
    }
}



