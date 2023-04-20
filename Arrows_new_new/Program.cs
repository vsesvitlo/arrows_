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
        
        string someN = Console.ReadLine();
        int.TryParse(someN, out int z);
        double fixLength = 0.005 * z;
        int length = Convert.ToInt32(fixLength);
        Console.WriteLine(length);
        

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
        Arrow arrow = new Arrow(headArr[hIndex], fletchArr[fIndex], length);

        int sum = headArr[hIndex] + fletchArr[fIndex] + length;
        Console.WriteLine(sum);

        int sum1 = arrow.HeadType + arrow.FletchingType + length;
        Console.WriteLine(sum1);
        

        //TODO: move everything about Random here - done
    }
}
