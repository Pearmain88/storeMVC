﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.webMVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        //quantity purchased 
        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

    }
}