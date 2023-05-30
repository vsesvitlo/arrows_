using System;
using System.Numerics;

namespace Arrows;

public class PlayerClass
{
    const int quiver = 10;
    Arrow[] arrowsInThePocket;
    public int countOfArrowsInThePocket;
    public float amountOfMoneyInThePocket;

    public PlayerClass(
        float amountOfMoney
            )
    {
        countOfArrowsInThePocket = 0;
        amountOfMoneyInThePocket = amountOfMoney;
        arrowsInThePocket = new Arrow[quiver];
      
    }


    public void BuyArrows(Trader trader, HeadType arrowhead, FletchingType fletching, float leng, int count)
       
    {
        bool resultForCalculating = trader.HasArrow(arrowhead, fletching, leng);

        if ((resultForCalculating == true)&&
            (amountOfMoneyInThePocket > 0)&&
           (countOfArrowsInThePocket <= quiver))
        {
            var arrow = new Arrow(arrowhead, fletching, leng);
            float sum = trader.GetCost(arrow);
            amountOfMoneyInThePocket -= sum;
            count += 1;
            countOfArrowsInThePocket += count;
            arrowsInThePocket[0] = arrow;
        
        }
       
    }
 }
    
    

