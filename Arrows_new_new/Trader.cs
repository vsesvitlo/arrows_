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

        //HeadType arrowhead, FletchingType fletching, float leng
        public Trader(Arrow[] initialArrow)
            {
                arrows = initialArrow;
            }
        
public bool HasArrow(HeadType arrowhead, FletchingType fletching, float leng)
            {
            for (int i = 0; i < this.arrows.Length; i++)
            {
              

                for (int j = 0; j < arrows[i].Length; j++)
                {

                }

            }
                    return false;
            }

/*public float GetCost()
            {
                int headTypeArrResult = (int)this._arrowhead_type;
                int fletchTypeArrResult = (int)this._fletching_type;
                float sum = headTypeArrResult + fletchTypeArrResult + (_length * 0.05f);
                return sum;
            }
        }*/
    }

