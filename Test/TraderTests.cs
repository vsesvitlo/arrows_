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
        public void TestSum()
        {
            Trader check = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Obsidian, FletchingType.Goose, 88)
            });
            var condition = check.HasArrow(HeadType.Obsidian, FletchingType.Goose, 88) == true; // 5 + 3 + 88 * 0.05f; 
            Assert.True(condition);
        }
    }
}
