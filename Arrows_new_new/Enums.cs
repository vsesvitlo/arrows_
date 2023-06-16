using System;
using System.ComponentModel;
using System.Numerics;

namespace Arrows;

public enum HeadType
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }

public enum FletchingType
    {
        Plastic = 10,
        Turkey = 5,
        Goose = 3
    }


public enum BuyingResult
{
    [Description("There is no space in your quiver. Sorry")]
    NoSpaceInQuiver = 1,
    [Description("Unfortunately, the sum of your order is more than you have.")]
    NotEnoughMoney = 2,
    [Description("There is no arrow that you want. Sorry. Please, try another parametres")]
    NotAvailable = 3,
    [Description($"Please, pay here.")]
    Successful = 4
}


