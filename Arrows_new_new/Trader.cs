using System;
namespace Arrows
{
	public class Trader
	{
       
        public float GetCost(HeadType _arrowhead_type, FletchingType _fletching_type, float _length)
        {

            int headTypeArrResult = (int)_arrowhead_type;
            int fletchTypeArrResult = (int)_fletching_type;
            float sum = headTypeArrResult + fletchTypeArrResult + (_length * 0.05f);
            return sum;
        }
    }
}

