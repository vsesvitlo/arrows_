using System;
namespace Arrows
{
	public class PlayerClass
	{
        Arrow[] arrowsInThePocket;
        int countOfArrowsInThePocket;
        float amountOfMoneyInThePocket;

        public PlayerClass(
            float amountOfMoney
			)
		{
            countOfArrowsInThePocket = 0;
            amountOfMoneyInThePocket = amountOfMoney;
            arrowsInThePocket = new Arrow[10];
        }


        public void BuyArrows(Trader trader, HeadType arrowhead, FletchingType fletching, float leng, int count)
        {
            //if(amountOfMoneyInThePocket >= amountOfMoney)
            {
              //  amountOfMoneyInThePocket -= sum;
                countOfArrowsInThePocket += 1; //(?)
               //new Arrow[] {
                //   new Arrow()
               //};
            }


        
        }
        }
}

