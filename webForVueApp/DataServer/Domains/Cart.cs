﻿using System;
using System.Collections.Generic;
using Common;

namespace DataServer.Domains
{
    public class Cart : EntityBase
    {
        public Cart()
        {
            Products = new List<CartProduct>();
        }
        public IList<CartProduct> Products { get; set; }
        public int TotalCount { get; set; }
        public float TotalPrize { get; set; }

        public MessageResult AddToCart(Guid productId)
        {

            return null;
        }

        public MessageResult RemoveFromCart(Guid productId)
        {
            return null;
        }

        public MessageResult Clear()
        {
            return null;
        }
    }
}
