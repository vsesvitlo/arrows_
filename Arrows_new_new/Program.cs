using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;

namespace Arrows;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Do you want to calculate the price of arrow manual or random? Please, enter: 1 - for manual, 2 - for random");
        string chooseWayCalculation = Console.ReadLine();
        int.TryParse(chooseWayCalculation, out int calculation);
        if (calculation == 1)
        {
            RunManualApplicationMode();
        }
        else if (calculation == 2)
        {
            RunRandomApplicationMode();
        }
        else
        {
            Console.WriteLine("Please, enter the correct values for choosing calculation");
        }
    }
    

public static void RunManualApplicationMode()
    {
     
        Console.WriteLine("What type of arrow`s head do you want? Please, choose: 1 - for steel, 2 - for wood, 3 - for odsidian");
        string chooseHead = Console.ReadLine();
        int.TryParse(chooseHead, out int chooseHeadNumber);
        Console.WriteLine("What type of arrow`s fletch do you want? Please, choose: 1 - for plastic, 2 - for turkey, 3 - for goose");
        string chooseFletch = Console.ReadLine();
        int.TryParse(chooseFletch, out int chooseFletchNumber);
        Console.WriteLine("How long of arrow`s shaft do you want? Please, enter the length between 60 and 100 cm");
        string someN = Console.ReadLine();

        int.TryParse(someN, out int lengthForCalculation);

        HeadType arrowhead_type;
        FletchingType fletching_type;


        Arrow[] arrows = new[]
        {
            new Arrow( HeadType.Steel, FletchingType.Goose, 100 ),
            new Arrow( HeadType.Wood, FletchingType.Plastic, 60 ),
            new Arrow( HeadType.Obsidian, FletchingType.Turkey, 78 )
        };
     
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
            
            var trader = new Trader(arrows);




            bool result = trader.HasArrow(arrowhead_type, fletching_type, lengthForCalculation);
            int countOfArrowsInThePocket = 0;

            var player = new PlayerClass(100);
            bool check = player.BuyArrows(trader, arrowhead_type, fletching_type, lengthForCalculation, countOfArrowsInThePocket);
            //player.BuyArrows(trader, arrowhead_type, fletching_type, lengthForCalculation, countOfArrowsInThePocket);
            if (result == true)
            {
             var arrow = new Arrow(arrowhead_type, fletching_type, lengthForCalculation);
             float sum = trader.GetCost(arrow);
            
             Console.WriteLine(sum);
             Console.WriteLine("Please, pay here");
             Console.WriteLine("Now you have ${countOfArrowsInThePocket} arrows");
            }
            else 
                {
            Console.WriteLine("There is no array that you want. Sorry. Please, try another parametres");
            }
        }
        else
        {
        
            Console.WriteLine("Please, enter the correct values for choosing arow`s parametrs");
        }
    }

    public static void RunRandomApplicationMode()
    //(length)
    {

        int length = 100;
        Console.WriteLine(length);
        Random choice = new Random();
        HeadType[] headArr = { HeadType.Steel, HeadType.Wood, HeadType.Obsidian };
        FletchingType[] fletchArr = { FletchingType.Plastic, FletchingType.Turkey, FletchingType.Goose };

        int hIndex = choice.Next(headArr.Length);
        int fIndex = choice.Next(fletchArr.Length);
        Console.WriteLine(headArr[hIndex]);
        Console.WriteLine(fletchArr[fIndex]);
        Arrow arrowRandom = new Arrow(headArr[hIndex], fletchArr[fIndex], length);

        Arrow[] arrows = new[]
        {
            new Arrow( HeadType.Steel, FletchingType.Goose, 100 ),
            new Arrow( HeadType.Wood, FletchingType.Plastic, 60 ),
            new Arrow( HeadType.Obsidian, FletchingType.Turkey, 78 )
        };

        var trader = new Trader(arrows);
        float sum = trader.GetCost(arrowRandom);
        Console.WriteLine(sum);

    }

}

