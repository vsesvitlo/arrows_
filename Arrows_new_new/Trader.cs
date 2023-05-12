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
                //arrows[i];
                i++;

                // for (int j = 0; j < 2; j++)
                {
                    foreach (Arrow j in arrows)
                    {
                        i == j;
                    
                }
                   
                {
                    //Console.WriteLine(arrows[i, j]);

                   // if (arrowhead == HeadType )
                    {

                    }
                }
                       // for (int j = 0; j < arrows.GetLength(1); j++)
               // {
                    //Console.WriteLine(arrows[i, j]);
               // }
                // for (int j = 0; j < arrows.GetLength(1); j++)
                //{
                    //Console.WriteLine(arrows[i, j]);
                //}
                    /*foreach (int i in arrows)
                    {

                    }*/
                }

                    return false;
            }

public float GetCost()
            {
                int headTypeArrResult = (int)this._arrowhead_type;
                int fletchTypeArrResult = (int)this._fletching_type;
                float sum = headTypeArrResult + fletchTypeArrResult + (_length * 0.05f);
                return sum;
            }
        }
    }

