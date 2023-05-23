using System;
namespace Arrows
{
    public class Trader
    {
        //Arrow[] arrows;
        Arrow[] arrows = new[]
        {
            new Arrow( HeadType.Steel, FletchingType.Goose, 100 ),
            new Arrow( HeadType.Wood, FletchingType.Plastic, 60 ),
            new Arrow( HeadType.Obsidian, FletchingType.Turkey, 78 )
        };
        public Trader(Arrow[] initialArrow)
        {
            arrows = initialArrow;
        }

        public float GetCost(Arrow arrow)
        {
            float sum = (int)arrow._arrowhead_type + (int)arrow._fletching_type + (arrow._length * 0.05f);
            return sum;
        }


        public bool HasArrow(HeadType arrowhead, FletchingType fletching, float leng)
        {
            for (int i = 0; i < arrows.Length - 1; i++)
            {

                Arrow arrow = arrows[i];
                bool check = Matching.Match(arrow,
                  arrows[i]._arrowhead_type,
                  arrows[i]._fletching_type,
                  arrows[i]._length);
                if (check)
                {
                    return check;
                }
                //Match;
                //Arrow arrow = arrows[i];
                /*if(arrow._arrowhead_type == arrowhead &&
                   arrow._fletching_type == fletching &&
                   arrow._length == leng)
                {
                    return true;
                }*/
                //return check;
             }
                return false;
        }
    }

    public class Matching
    {
        public static bool Match(Arrow arrow, HeadType arrowhead, FletchingType fletching, float leng)
        {

            if (arrow._arrowhead_type == arrowhead &&
            arrow._fletching_type == fletching &&
            arrow._length == leng)
            {
                return true;
            }
            return false;
        }

    }
}


