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
        var arrow = new Arrow(arrowhead, fletching, leng);
        float sum = trader.GetCost(arrow);


        //arrowsInThePocket.Length
        //todo loop count of arrows to pocket
        if (
           (resultForCalculating == true) &&
           (amountOfMoneyInThePocket > 0) &&
           (countOfArrowsInThePocket + count <= quiver))
        {
            for (int i = 0; i <= (countOfArrowsInThePocket + count) - 1; i++)
            {
                arrowsInThePocket[i] = arrow;
                //float initialMoney = amountOfMoneyInThePocket;
                if ((amountOfMoneyInThePocket > (sum * count)) && (amountOfMoneyInThePocket != 0))
                {

                    amountOfMoneyInThePocket -= sum * count;
                    countOfArrowsInThePocket += count;


                    
                }


                return success;
            }
            return nomoney;
        }


        /*if ((amountOfMoneyInThePocket == 0) || (amountOfMoneyInThePocket < (sum * count)))
        {
            return nomoney;
        }
        if ((amountOfMoneyInThePocket == 0) || (amountOfMoneyInThePocket < (sum * count)))
                {
                    amountOfMoneyInThePocket = initialMoney;
                }
                return nomoney;
       */
        if (!resultForCalculating)
        {
            return notavailable;
        }
        if (countOfArrowsInThePocket + count > quiver)
        {
            return nospace;//BuyingResult.NoSpaceInQuiver;
        }
        return notavailable;
    }

    }
 
    
    

