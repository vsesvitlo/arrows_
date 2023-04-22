using System;
namespace Arrows;

public class Arrow
{
    //TODO: use Enums - done
    public float HeadType;
    public float FletchingType;
    public float _length;


    public Arrow(float arrowhead_type, float fletching_type, float length)
    {
        HeadType = arrowhead_type;
        FletchingType = fletching_type;
        _length = length;
        
    }

    //TODO: add GetCost - done

   public static float GetCost()
  {
   double fixLength = 0.05 * z;
    float length = Convert.ToSingle(fixLength);
    Console.WriteLine(length);
            Arrow arrow = new Arrow(arrowhead_type, fletching_type, length);

    Console.WriteLine((arrowhead_type, fletching_type, length));

            float sum = arrow.HeadType + arrow.FletchingType + length;
    Console.WriteLine(sum);
  }

}

