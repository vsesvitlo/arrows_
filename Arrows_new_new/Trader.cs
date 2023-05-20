using System;
namespace Arrows
{
    public class Trader
    {
        Arrow[] arrows;
        public Trader(Arrow[] initialArrow)
        {
            arrows = initialArrow;
        }

        public bool HasArrow(HeadType arrowhead, FletchingType fletching, float leng)
        {
            for (int i = 0; i < this.arrows.Length; i++)
            {
                Arrow arrow = arrows[i];
                if(arrow._arrowhead_type == arrowhead &&
                   arrow._fletching_type == fletching &&
                   arrow._length == leng)
                {
                    return true;
                }
            }
            return false;
        }

        public float GetCost(Arrow arrow)
                    {
            float sum = (int)arrow._arrowhead_type + (int)arrow._fletching_type + (arrow._length * 0.05f);
                        return sum;
                    }


        public static bool Equals(
        Arrow[] arrows,
        HeadType arrowhead,
        FletchingType fletching,
        float leng)
        {
            return false;
        }
    }
}


