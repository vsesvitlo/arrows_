using System;
namespace Arrows;

public class Arrow
{
    //TODO: use Enums 
    public float HeadType;
    public float FletchingType;
    public float _length;


    public Arrow(float arrowhead_type, float fletching_type, float length)
    {
        HeadType = arrowhead_type;
        FletchingType = fletching_type;
        _length = length;
        
    }

    //TODO: add GetCost 

   public float GetCost()
  {

           // Arrow arrow = new Arrow(this.HeadType, this.FletchingType, _length);

    Console.WriteLine((this.HeadType, this.FletchingType, _length));

            float sum = this.HeadType + this.FletchingType + _length;
    Console.WriteLine(sum);
        return sum;
  }

}

