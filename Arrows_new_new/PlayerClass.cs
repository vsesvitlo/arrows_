using System;
namespace Arrows
{
	public class PlayerClass
	{
        Arrow[] arrowsInThePocket;
        public PlayerClass(
            Arrow[] purchaseArrows,
            float amountOfMoney,
            int countOfArrows
			)
		{
            arrowsInThePocket = purchaseArrows;
        }

        public bool BuyArrows(PlayerClass playerClass, Arrow[] purchaseArrows, float amountOfMoney,
            float amountOfMoneyInThePocket = 1000, int countOfArrowsInThePocket = 0, sum)
        {
            if(amountOfMoneyInThePocket >= amountOfMoney)
            {
                amountOfMoneyInThePocket -= sum;
                countOfArrowsInThePocket += 1; //(?)
               //new Arrow[] {
                //   new Arrow()
               //};
            }


            return true;
        }
        }
}

