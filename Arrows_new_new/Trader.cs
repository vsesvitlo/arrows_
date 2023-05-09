using System;
namespace Arrows
{


    public class Trader
    {
   
        public HeadType _arrowhead_type;
        public FletchingType _fletching_type;
        public float _length;

       
public Trader(HeadType arrowhead, FletchingType fletching, float leng)
            {
                _arrowhead_type = arrowhead;
                _fletching_type = fletching;
                _length = leng;
            }





        Arrow[] arrows = {
            new Array[] { HeadType.Steel, FletchingType.Goose, 100 },
        new Array[] { HeadType.Wood, FletchingType.Plactic, 60 },
            new Array[] { HeadType.Obsidian, FletchingType.Turkey, 78 }
    };


public float HasArrow()
            {
                //for (int i = 0; i < arrows.GetLength(0); i++)
                {
                   // for (int j = 0; j < arrows.GetLength(1); j++)
                    {
                        //Console.WriteLine(arrows[i, j]);
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

