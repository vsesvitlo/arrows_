using System;
namespace Arrows;

public class Trader
{
    Arrow[] arrows;
    
    public Trader(Arrow[] initialArrow)
    {
        arrows = initialArrow;
    }

    public float GetCost(Arrow arrow)
    {
        float sum = (int)arrow._arrowhead_type + (int)arrow._fletching_type + (arrow._length * 0.05f);
        return sum;
    }

    public static bool Match(Arrow arrow, HeadType arrowhead, FletchingType fletching, float leng)
    {
        return arrow._arrowhead_type == arrowhead &&
        arrow._fletching_type == fletching &&
        arrow._length == leng;
    }

    public bool HasArrow(HeadType arrowhead, FletchingType fletching, float leng)
    {
        for (int i = 0; i < arrows.Length; i++)
        {

            Arrow arrow = arrows[i];
            bool check = Trader.Match(arrow, arrowhead, fletching, leng);
            if (check)
            {
                return true;
            }
            
         }
            return false;
    }
}




