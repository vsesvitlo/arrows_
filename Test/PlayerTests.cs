using Arrows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class PlayerTests
    {
        [Fact]
        public void TestCheckBuy1Arrow()
        {
            PlayerClass check = new PlayerClass(100);
            var trader = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Obsidian, FletchingType.Goose, 78)
            });
            check.BuyArrows(trader, HeadType.Obsidian, FletchingType.Goose, 78, 1);
            var condition = (check.countOfArrowsInThePocket == 1) &&
                (check.amountOfMoneyInThePocket == 88.1f);
            Assert.True(condition);
        }

        [Fact]
        public void TestCheckBuy3Arrows()
        {
            PlayerClass check = new PlayerClass(100);
            var trader = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Obsidian, FletchingType.Goose, 78)
            });
            check.BuyArrows(trader, HeadType.Obsidian, FletchingType.Goose, 78, 3);
            var condition = (check.countOfArrowsInThePocket == 3) &&
                (check.amountOfMoneyInThePocket == 64.3f);
            Assert.True(condition);
        }

        [Fact]
        public void TestCheckBuy11Arrows()
        {
            PlayerClass check = new PlayerClass(100);
            var trader = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Obsidian, FletchingType.Goose, 78)
            });
            check.BuyArrows(trader, HeadType.Obsidian, FletchingType.Goose, 78, 11);
            var condition = (check.countOfArrowsInThePocket == 0) &&
                (check.amountOfMoneyInThePocket == 100f);
            Assert.True(condition);
        }

        [Fact]
        public void TestCheckBuy5DifArrows()
        {
            PlayerClass check = new PlayerClass(100);
            var trader = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Obsidian, FletchingType.Goose, 78),
                new Arrow(HeadType.Wood, FletchingType.Plastic, 98)
            });
            check.BuyArrows(trader, HeadType.Obsidian, FletchingType.Goose, 78, 2);
            check.BuyArrows(trader, HeadType.Wood, FletchingType.Plastic, 98, 3);
            var condition = (check.countOfArrowsInThePocket == 5) &&
                (check.amountOfMoneyInThePocket == 22.5f);//count
            Assert.True(condition);
        }


        [Fact]
        public void TestCheckNoMoney()
        {
            PlayerClass check = new PlayerClass(100);
            var trader = new Trader(new Arrow[]
            {
                new Arrow(HeadType.Wood, FletchingType.Plastic, 98)
            });
            check.BuyArrows(trader, HeadType.Wood, FletchingType.Plastic, 98, 3);
            var condition = (check.countOfArrowsInThePocket == 0) &&
                (check.amountOfMoneyInThePocket == 100f);// -33.699997f
            Assert.True(condition);
        }
    }
}

