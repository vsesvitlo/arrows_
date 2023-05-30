using System;
namespace Arrows;

public class PlayerClass
{
    Arrow[] arrowsInThePocket;
    int countOfArrowsInThePocket;
    float amountOfMoneyInThePocket;

    public PlayerClass(
        float amountOfMoney
            )
    {
        countOfArrowsInThePocket = 10;
        amountOfMoneyInThePocket = amountOfMoney;
        arrowsInThePocket = new Arrow[countOfArrowsInThePocket];
      
    }


    public void BuyArrows(Trader trader, HeadType arrowhead, FletchingType fletching, float leng, int count)
       
    {
        float sumMoney = 100;
        bool resultForCalculating = trader.HasArrow(arrowhead, fletching, leng);

        if ((resultForCalculating == true)&&
            (amountOfMoneyInThePocket >= sumMoney))
        {
            var arrow = new Arrow(arrowhead, fletching, leng);
            float sum = trader.GetCost(arrow);
            amountOfMoneyInThePocket -= sum;
            countOfArrowsInThePocket += count;
            arrowsInThePocket = new Arrow[countOfArrowsInThePocket];
        }
       
    }
 }
    
    

