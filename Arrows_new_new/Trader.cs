using System;
namespace Arrows
{
	public class Trader
    {
        public HeadType _arrowhead_type;
        public FletchingType _fletching_type;
        public float _length;
      
        //Arrow[];
        
        int[,] arrows = {
            { 1, 2, 100 },
            { 2, 1, 88 },
            { 3, 3, 60 },
        };

  
    public Trader(HeadType arrowhead, FletchingType fletching, float leng)
        {
            _arrowhead_type = arrowhead;
            _fletching_type = fletching;
            _length = leng;
        }
        public float HasArrow()
        {
            for (int i = 0; i < arrows.GetLength(0); i++)
            {
                for (int j = 0; j < arrows.GetLength(1); j++)
                {
                    Console.WriteLine(arrows[i, j]);
                }
                /*foreach (int i in arrows)
                {

                }*/
            }

                return GetCost();
        }
        //   public Trader (HeadType arrowhead_type, FletchingType fletching_type, float length)
        //{
        //_arrowhead_type = arrowhead_type;
        //_fletching_type = fletching_type;
        //_length = length;
        //}

        public float GetCost()
        {
            int headTypeArrResult = (int)this._arrowhead_type;
            int fletchTypeArrResult = (int)this._fletching_type;
            float sum = headTypeArrResult + fletchTypeArrResult + (_length * 0.05f);
            return sum;
        }
    }
}

