﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    public interface IDiscount
    {
        int PeopleNumber { get; }
        double FindTotalPrice();

        double Discount();
    }
}