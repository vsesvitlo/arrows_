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
        bool resultForCalculating = trader.HasArrow(arrowhead, fletching, leng);

        if ((resultForCalculating == true)&&
            (amountOfMoneyInThePocket > 0)&&
           (countOfArrowsInThePocket + count <= quiver))
        {
            //todo loop count of arrows to pocket
            var arrow = new Arrow(arrowhead, fletching, leng);
            arrowsInThePocket[0] = arrow;//


            float sum = trader.GetCost(arrow);
            amountOfMoneyInThePocket -= sum * count;
            countOfArrowsInThePocket += count;
            return BuyingResult.Successful;

        }
    }
 }
    
    

