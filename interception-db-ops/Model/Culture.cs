﻿using System;
using System.Collections.Generic;

namespace interception_db_ops.Model
{
    public class Culture
    {
        public Culture()
        {
            ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCulture>();
        }

        public string CultureID { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture
        {
            get;
            set;
        }
    }
}