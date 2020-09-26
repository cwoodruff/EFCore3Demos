﻿using System;

namespace interception_db_ops.Model
{
    public class ProductCostHistory
    {
        public int ProductID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal StandardCost { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}