// See https://aka.ms/new-console-template for more information

using System;

namespace Arrows;
class Program

{
    enum HeadType
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }
    enum FletchingType
    {
        Plastic = 10,
        Turkey = 5,
        Goose = 3
    }


    //string x = Console.ReadLine();
    //string y = Console.ReadLine();
    //int length = 0,005;

    // public int Sum() => (HeadType + FletchingType + length * z);
    Arrow arrow = new Arrow(10, 3, 5);


    public class Arrow
    {
        public int _arrowhead_type;
        public int _fletching_type;
        public int _length;


        public Arrow(int arrowhead_type, int fletching_type, int length)
        {
            _arrowhead_type = arrowhead_type;
            _fletching_type = fletching_type;
            _length = length;

        }


        static void Main(string[] args)

        {
            //Arrow arrow = new Arrow(10, 3, 5);

            string someN = Console.ReadLine();
            int.TryParse(someN, out int z);
            double fixLength = 0.005 * z; // ???
            int length = Convert.ToInt32(fixLength);
            Console.WriteLine(length);

            //public int Sum() => (HeadType + FletchingType + length);
            //
            //Arrow arrow = new Arrow(10, 3, 5);
            int headArrSteel = (int)HeadType.Steel;
            int headArrWood = (int)HeadType.Wood;
            int headArrObsidian = (int)HeadType.Obsidian;

            int fletchArrPlastic = (int)FletchingType.Plastic;
            int fletchArrTurkey = (int)FletchingType.Turkey;
            int fletchArrGoose = (int)FletchingType.Goose;

            //string arrowhead_type = Console.ReadLine();
            //string fletching_type = Console.ReadLine();
            HeadType arrowhead_type = HeadType.Steel; // make a changes!!!
            FletchingType fletching_type = FletchingType.Plastic; // make a changes!!!

            switch (arrowhead_type, fletching_type)
             {
                 case (HeadType.Steel, FletchingType.Plastic):
                     int sum1 = headArrSteel + fletchArrPlastic + length;
                     Console.WriteLine(sum1);
                     break;
                 case (HeadType.Wood, FletchingType.Plastic):
                    int sum2 = headArrWood + fletchArrPlastic + length;
                    Console.WriteLine(sum2);
                     break;
                 case (HeadType.Obsidian, FletchingType.Plastic):
                    int sum3 = headArrObsidian + fletchArrPlastic + length;
                    Console.WriteLine(sum3);
                    break;
                 case (HeadType.Steel, FletchingType.Turkey):
                    int sum4 = headArrSteel + fletchArrTurkey + length;
                    Console.WriteLine(sum4);
                    break;
                 case (HeadType.Wood, FletchingType.Turkey):
                    int sum5 = headArrWood + fletchArrTurkey + length;
                    Console.WriteLine(sum5);
                    break;
                 case (HeadType.Obsidian, FletchingType.Turkey):
                    int sum6 = headArrObsidian + fletchArrTurkey + length;
                    Console.WriteLine(sum6);
                    break;
                 case (HeadType.Steel, FletchingType.Goose):
                    int sum7 = headArrSteel + fletchArrGoose + length;
                    Console.WriteLine(sum7);
                    break;
                 case (HeadType.Wood, FletchingType.Goose):
                    int sum8 = headArrWood + fletchArrGoose + length;
                    Console.WriteLine(sum8);
                    break;
                 /*case (HeadType.Obsidian, FletchingType.Goose):
                    int sum9 = headArrObsidian + fletchArrGoose + length;
                    Console.WriteLine(sum9);
                    break;*/
                 default:
                    int sum9 = headArrObsidian + fletchArrGoose + length; //HeadType.Obsidian, FletchingType.Goose
                    Console.WriteLine(sum9);
                    break;
             }
        }
    }
}
/*switch (headArr)
{
    case HeadType.Steel:
        Console.WriteLine("HeadType.Steel");
        break;
    case HeadType.Wood:
        Console.WriteLine("3");
        break;
    case HeadType.Obsidian:
        Console.WriteLine("5");
        break;
}
FletchingType fletchingArr = FletchingType.Plastic;
switch (fletchingArr)
{
    case FletchingType.Plastic:
        Console.WriteLine("10");
        break;
    case FletchingType.Turkey:
        Console.WriteLine("5");
        break;
    case FletchingType.Goose:
        Console.WriteLine("3");
        break;
}

}*/




/*{
    static void Main(string[] args)
    {
        Arrow arrow = new Arrow(10, 3, 5);
      

       // length = 0.005;
        //int x = Console.ReadLine();

       // public int Sum() => (arrow + fletching_type + length * x);


    }
    public class Arrow
    {
        public int _arrowhead_type;
        public int _fletching_type;
        public int _length;


        public Arrow(int arrowhead_type, int fletching_type, int length)
        {
            _arrowhead_type = arrowhead_type;
            _fletching_type = fletching_type;
            _length = length;

        }
        

    }*/




