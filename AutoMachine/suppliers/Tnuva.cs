﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine
{
    internal class Tnuva : Supplier
    {
        public Tnuva(string name, string phoneNumber) : base(name, phoneNumber)
        {
        }

        public override void OrderAProduct(ProductType productType, int numToOrder)
        {
            //Handles the order
        }
    }
}
