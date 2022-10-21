using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Animals.Models;

namespace Animals.Stores;

public class PetStore
{
    public Dog Dog
    {
        get ;
        set;
    }

    public Cat Cat
    {
        get;
        set;
    }

    public Cat BuyCat()
    {
        return new Cat();
    }

    public Dog BuyDog()
    {
        throw new System.NotImplementedException();
    }
}