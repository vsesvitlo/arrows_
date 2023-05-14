using System;
namespace Arrows
{
    public class Trader
    {
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

        public float GetCost(HeadType arrowhead, FletchingType fletching, float leng)
                    {
            float sum = (int)arrowhead + (int)fletching + (leng * 0.05f);
                        return sum;
                    }
                }
    }


