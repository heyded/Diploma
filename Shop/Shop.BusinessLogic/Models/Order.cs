﻿namespace Shop.BusinessLogic.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public string UserEmail { get; set; }
    }
}
