using System;
using System.Numerics;

namespace Arrows;

public class PlayerClass
{
    const int quiver = 10;
    Arrow[] arrowsInThePocket;
    public int countOfArrowsInThePocket;
    public float amountOfMoneyInThePocket;

    public PlayerClass(float amountOfMoney)
    {
        countOfArrowsInThePocket = 0;
        amountOfMoneyInThePocket = amountOfMoney;
        arrowsInThePocket = new Arrow[quiver];

    }


    public BuyingResult BuyArrows(Trader trader, HeadType arrowhead, FletchingType fletching, float leng, int count)

    {   bool resultForCalculating = trader.HasArrow(arrowhead, fletching, leng);
        var arrow = new Arrow(arrowhead, fletching, leng);
        float sum = trader.GetCost(arrow);

        if (!resultForCalculating)
        {
            return BuyingResult.NotAvailable;
        }
        if (countOfArrowsInThePocket + count > quiver)
        {
            return BuyingResult.NoSpaceInQuiver;//BuyingResult.NoSpaceInQuiver;
        }

        //arrowsInThePocket.Length
        //todo loop count of arrows to pocket
        //if (amountOfMoneyInThePocket - (sum +count) > 0)
        if (amountOfMoneyInThePocket > (sum * count))
        {
            for (int i = 0; i <= (countOfArrowsInThePocket + count) - 1; i++)
            {
                arrowsInThePocket[i] = arrow;
            }
            amountOfMoneyInThePocket -= sum * count;
            countOfArrowsInThePocket += count;
            return BuyingResult.Successful;
        }
        return BuyingResult.NotEnoughMoney;
    }
}

