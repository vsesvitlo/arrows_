
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
            string someN = Console.ReadLine();
            int.TryParse(someN, out int z);
            double length = 5; // ???
        
            //
            //Arrow arrow = new Arrow(10, 3, 5);
            //int headArr = (int)HeadType.April;
            HeadType arrowhead_type = HeadType.Steel;
            FletchingType fletching_type = FletchingType.Plastic;

            switch (arrowhead_type, fletching_type)
            {
                case (HeadType.Steel, FletchingType.Plastic):
                    int sum = 10 + 10 + length * z;
                    Console.WriteLine(sum);
                    break;
                case (HeadType.Wood, FletchingType.Plastic):
                    Console.WriteLine("3 + 10 + 0,005 * z");
                    break;
                case (HeadType.Obsidian, FletchingType.Plastic):
                    Console.WriteLine("5 + 10 + 0,005 * z");
                    break;
                case (HeadType.Steel, FletchingType.Turkey):
                    Console.WriteLine("10 + 5 + 0,005 * z");
                    break;
                case (HeadType.Wood, FletchingType.Turkey):
                    Console.WriteLine("3 + 5 + 0,005 * z");
                    break;
                case (HeadType.Obsidian, FletchingType.Turkey):
                    Console.WriteLine("5 + 5 + 0,005 * z");
                    break;
                case (HeadType.Steel, FletchingType.Goose):
                    Console.WriteLine("10 + 3 + 0,005 * z");
                    break;
                case (HeadType.Wood, FletchingType.Goose):
                    Console.WriteLine("3 + 3 + 0,005 * z");
                    break;
                case (HeadType.Obsidian, FletchingType.Goose):
                    Console.WriteLine("5 + 3 + 0,005 * z");
                    break;
                default:
                    Console.WriteLine("!");
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



