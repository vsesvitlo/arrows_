using System;
namespace Arrows
{
	public class Trader
    {
        public HeadType _arrowhead_type;
        public FletchingType _fletching_type;
        public float _length;

        public float GetCost()
        {
            int headTypeArrResult = (int)this._arrowhead_type;
            int fletchTypeArrResult = (int)this._fletching_type;
            float sum = headTypeArrResult + fletchTypeArrResult + (_length * 0.05f);
            return sum;
        }
    }
}

