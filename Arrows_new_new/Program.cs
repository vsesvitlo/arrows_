using System;
using System.Threading;
using System.Xml.Linq;

namespace Arrows;
class Program
{
    public static void Main(string[] args)
    {
        //TODO: two modes of program
        // 1 - Random
        // 2 - Manual, which already is used
        // Use methods RunRandomApplicationMode, RunManualApplicationMode

        Console.WriteLine("What type of arrow`s head do you want? Please, choose: 1 - for steel, 2 - for wood, 3 - for odsidian");
        string chooseHead = Console.ReadLine();
        //float arrowhead_type = Convert.ToSingle(chooseHead);
        int.TryParse(chooseHead, out int chooseHeadNumber);
        Console.WriteLine("What type of arrow`s fletch do you want? Please, choose: 1 - for plastic, 2 - for turkey, 3 - for goose");
        string chooseFletch = Console.ReadLine();
        //float fletching_type = Convert.ToSingle(chooseFletch);
        int.TryParse(chooseFletch, out int chooseFletchNumber);
        Console.WriteLine("How long of arrow`s shaft do you want? Please, enter the length between 60 and 100 cm");
        string someN = Console.ReadLine();
     //float length = Convert.ToSingle(someN);

        int.TryParse(someN, out int lengthForCalculation);
        
        HeadType arrowhead_type;
        FletchingType fletching_type;

        if (((chooseHeadNumber == 1) || (chooseHeadNumber == 2) || (chooseHeadNumber == 3)) &&
            ((chooseFletchNumber == 1) || (chooseFletchNumber == 2) || (chooseFletchNumber == 3)) &&
            ((lengthForCalculation >= 60) && (lengthForCalculation <= 100)))

        {

            switch (chooseHeadNumber)
            {
                case (1):
                    arrowhead_type = HeadType.Steel;
                    break;
                case (2):
                    arrowhead_type = HeadType.Wood;
                    break;
                case (3):
                    arrowhead_type = HeadType.Obsidian;
                    break;
                
                default:
                    arrowhead_type = HeadType.Steel;
                    Console.WriteLine("Please, enter the correct values for choosing arow`s head parametrs");
                    break;
            }
            switch (chooseFletchNumber)
            {
                case (1):
                    fletching_type = FletchingType.Plastic;
                    break;
                case (2):
                    fletching_type = FletchingType.Turkey;
                    break;
                case (3):
                    fletching_type = FletchingType.Goose;
                    break;

                default:
                    fletching_type = FletchingType.Turkey;
                    Console.WriteLine("Please, enter the correct values for choosing arow`s fletch parametrs");
                    break;
            }
            var arrow = new Arrow (arrowhead_type, fletching_type, lengthForCalculation);
            float result = arrow.GetCost();
           Console.WriteLine(result); 

        }
        else
        {
            Console.WriteLine("Please, enter the correct values for choosing arow`s parametrs");
        }
    }

    public static void RunManualApplicationMode()
    {
        //TODO: move here
    }
    
    public static void RunRandomApplicationMode()
    //(length)
    {

       // int length = 100;
       // Random choice = new Random();
       // int[] headArr = { (int)HeadType.Steel, (int)HeadType.Wood, (int)HeadType.Obsidian };
       // int[] fletchArr = { (int)FletchingType.Plastic, (int)FletchingType.Turkey, (int)FletchingType.Goose };

       // int hIndex = choice.Next(headArr.Length);
       // int fIndex = choice.Next(fletchArr.Length);
       // Console.WriteLine(headArr[hIndex]);
       // Console.WriteLine(fletchArr[fIndex]);
       // Arrow arrowRandom = new Arrow(headArr[hIndex], fletchArr[fIndex], length);
       // int sumRandom = headArr[hIndex] + fletchArr[fIndex] + length;
       //Console.WriteLine(sumRandom);
    }
}
