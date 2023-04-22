using System;

using System.Threading;

//TODO: fix namespece to Arrows in ALL FILES - done
namespace Arrows;
class Program
{
    public static void Main(string[] args)
    {
        // TestRandom(); uncomment when testing form console

        //TODO: Remove extra {} - done

        //TODO: add user input

        Console.WriteLine("What type of arrow`s head do you want? Please, choose: 1 - for steel, 2 - for wood, 3 - for odsidian");
        string chooseHead = Console.ReadLine();
        int.TryParse(chooseHead, out int arrowhead_type);
        Console.WriteLine("What type of arrow`s fletch do you want? Please, choose: 1 - for plastic, 2 - for turkey, 3 - for goose");
        string chooseFletch = Console.ReadLine();
        int.TryParse(chooseFletch, out int fletching_type);
        Console.WriteLine("How long of arrow`s shaft do you want? Please, enter the length between 60 and 100 cm");
        string someN = Console.ReadLine();
        int.TryParse(someN, out int z);

         if ((arrowhead_type == 1) || (arrowhead_type == 2) || (arrowhead_type == 3) || (fletching_type == 1) ||
            (fletching_type == 2) || (fletching_type == 3) || (z >= 60) && (z <= 100))
            
        {
            double fixLength = 0.005 * z;
            int length = Convert.ToInt32(fixLength);
            Console.WriteLine(length);


            //Arrow arrow = new Arrow((, , length);



            //int sum = arrow.HeadType + arrow.FletchingType + length;
            //Console.WriteLine(sum);

        }
        Console.WriteLine("Please, enter the correct values for choosing arow`s parametrs");
    }

    public static void TestRandom()
    {

        Random choice = new Random();
        int[] headArr = { (int)HeadType.Steel, (int)HeadType.Wood, (int)HeadType.Obsidian };
        int[] fletchArr = { (int)FletchingType.Plastic, (int)FletchingType.Turkey, (int)FletchingType.Goose };

        int hIndex = choice.Next(headArr.Length);
        int fIndex = choice.Next(fletchArr.Length);
        Console.WriteLine(headArr[hIndex]);
        Console.WriteLine(fletchArr[fIndex]);
        //Arrow arrowRandom = new Arrow(headArr[hIndex], fletchArr[fIndex], length);
       // int sumRandom = headArr[hIndex] + fletchArr[fIndex] + length;
       //Console.WriteLine(sumRandom);

       

        //TODO: move everything about Random here - done
    }
}
