using System;

using System.Threading;
using System.Xml.Linq;

//TODO: fix namespece to Arrows in ALL FILES - done
namespace Arrows;
class Program
{
    public static void Main(string[] args)
    {
        // TestRandom(); uncomment when testing form console

        //TODO: Remove extra {} - done

        //TODO: add user input - done

        Console.WriteLine("What type of arrow`s head do you want? Please, choose: 1 - for steel, 2 - for wood, 3 - for odsidian");
        string chooseHead = Console.ReadLine();
        float arrowhead_type = Convert.ToSingle(chooseHead);
        //int.TryParse(chooseHead, out int arrowhead_type);
        Console.WriteLine("What type of arrow`s fletch do you want? Please, choose: 1 - for plastic, 2 - for turkey, 3 - for goose");
        string chooseFletch = Console.ReadLine();
        float fletching_type = Convert.ToSingle(chooseFletch);
        //int.TryParse(chooseFletch, out int fletching_type);
        Console.WriteLine("How long of arrow`s shaft do you want? Please, enter the length between 60 and 100 cm");
        string someN = Console.ReadLine();
        float length = Convert.ToSingle(someN);
        //int.TryParse(someN, out int length);
       
        if ((arrowhead_type == 1) || (arrowhead_type == 2) || (arrowhead_type == 3) || (fletching_type == 1) ||
            (fletching_type == 2) || (fletching_type == 3) || (length >= 60) && (length <= 100))

        {
            switch (arrowhead_type)
            {
                case (1):
                    arrowhead_type = (int)HeadType.Steel;
                    Console.WriteLine(arrowhead_type);
                    break;
                case (2):
                    arrowhead_type = (int)HeadType.Wood;
                    Console.WriteLine(arrowhead_type);
                    break;
                case (3):
                    arrowhead_type = (int)HeadType.Obsidian;
                    Console.WriteLine(arrowhead_type);
                    break;
                
                default:
                    Console.WriteLine("Please, enter the correct values for choosing arow`s head parametrs");
                    break;
            }
            switch (fletching_type)
            {
                case (1):
                    fletching_type = (int)FletchingType.Plastic;
                    Console.WriteLine(fletching_type);
                    break;
                case (2):
                    fletching_type = (int)FletchingType.Turkey;
                    Console.WriteLine(fletching_type);
                    break;
                case (3):
                    fletching_type = (int)FletchingType.Goose;
                    Console.WriteLine(fletching_type);
                    break;

                default:
                    Console.WriteLine("Please, enter the correct values for choosing arow`s fletch parametrs");
                    break;
            }
            float lengthSum = 0.05f * length;

            Console.WriteLine(lengthSum);
          var arrow = new Arrow (arrowhead_type, fletching_type, length);
          //  float result = arrow.GetCost();

        }
        //Console.WriteLine("Please, enter the correct values for choosing arow`s parametrs");???
    }
    
    public static void TestRandom()
    //(length)
    {

        int length = 100;
        Random choice = new Random();
        int[] headArr = { (int)HeadType.Steel, (int)HeadType.Wood, (int)HeadType.Obsidian };
        int[] fletchArr = { (int)FletchingType.Plastic, (int)FletchingType.Turkey, (int)FletchingType.Goose };

        int hIndex = choice.Next(headArr.Length);
        int fIndex = choice.Next(fletchArr.Length);
        Console.WriteLine(headArr[hIndex]);
        Console.WriteLine(fletchArr[fIndex]);
        Arrow arrowRandom = new Arrow(headArr[hIndex], fletchArr[fIndex], length);
        int sumRandom = headArr[hIndex] + fletchArr[fIndex] + length;
       Console.WriteLine(sumRandom);

       

        //TODO: move everything about Random here - done
    }
}
