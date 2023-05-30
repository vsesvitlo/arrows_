using Arrows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TraderTests
    {
        [Fact]
        public void FactCheck1()
        {
            var arrow = new Arrow(HeadType.Obsidian, FletchingType.Goose, 60);
            var traderArrows = new Arrow[] {
            new Arrow(HeadType.Obsidian, FletchingType.Goose, 60),
            new Arrow(HeadType.Wood, FletchingType.Plastic, 60)
        };
            var trader = new Trader(traderArrows);

            Assert.Equal(trader.GetCost(arrow), 11f);
        }
        [Fact]
        public void FactCheck2()
        {
            var arrow = new Arrow(HeadType.Obsidian, FletchingType.Goose, 88);
            var traderArrows = new Arrow[] {
            new Arrow(HeadType.Obsidian, FletchingType.Goose, 88),
            new Arrow(HeadType.Wood, FletchingType.Plastic, 60)
        };
            var trader = new Trader(traderArrows);

            Assert.Equal(trader.GetCost(arrow), 12.4f);
        }
        [Fact]
        public void TestCheckSum()
        {
            Trader check = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Steel, FletchingType.Goose, 100)
            });
            var condition = check.HasArrow(HeadType.Steel, FletchingType.Goose, 100) == true; 
            Assert.True(condition);
        }

        [Fact]
        public void TestCheckSumNoAvailable()
        {
            Trader check = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Obsidian, FletchingType.Goose, 78)
            });
            var condition = check.HasArrow(HeadType.Obsidian, FletchingType.Goose, 98) == false; 
            Assert.True(condition);
        }
        [Fact]
        public void TestCheckSumAvailable()
        {
            Trader check = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Obsidian, FletchingType.Goose, 78)
            });
            var condition = check.HasArrow(HeadType.Obsidian, FletchingType.Goose, 78) == true;
            Assert.True(condition);
        }
    }
}
