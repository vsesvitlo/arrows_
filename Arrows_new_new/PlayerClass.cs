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
       
    {
        BuyingResult nospace = BuyingResult.NoSpaceInQuiver;
        BuyingResult notavailable = BuyingResult.NotAvailable;
        BuyingResult nomoney = BuyingResult.NotEnoughMoney;
        BuyingResult success = BuyingResult.Successful;

        bool resultForCalculating = trader.HasArrow(arrowhead, fletching, leng);

        if ((resultForCalculating == true)&&
            (amountOfMoneyInThePocket > 0)&&
           (countOfArrowsInThePocket + count <= quiver))
        {

            var arrow = new Arrow(arrowhead, fletching, leng);
            float sum = trader.GetCost(arrow);
            amountOfMoneyInThePocket -= sum * count;
            countOfArrowsInThePocket += count;

            for (int i = 0; i <= countOfArrowsInThePocket + count; i++)
            {
                arrowsInThePocket[i] = arrow;
            }

            //todo loop count of arrows to pocket

            return success;

        }

        if (countOfArrowsInThePocket + count > quiver)
        {
            return nospace;//BuyingResult.NoSpaceInQuiver;
        }

        if (!resultForCalculating)
        {
            return notavailable;
        }

        return nomoney;
    }
 }
    
    

