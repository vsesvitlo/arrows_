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
        public void FactCheck()
        {
            var arrow = new Arrow(HeadType.Obsidian, FletchingType.Goose, 60);
            var traderArrows = new Arrow[] {
            new Arrow(HeadType.Obsidian, FletchingType.Goose, 60),
            new Arrow(HeadType.Wood, FletchingType.Plastic, 60)
        };
            var trader = new Trader(traderArrows);

            Assert.Equal(trader.GetCost(arrow), 11f);
        }
    }
}
