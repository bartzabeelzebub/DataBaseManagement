﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "product added";
        public static string ProductNameInvalid = "product name is invalid";
        public static string MaintenanceTime= "system in maintenance";
        public static string ProductsListed="products listed";
        internal static string ProductCountOfCategoryError;
        internal static string ProductNameAlreadyExists;
    }
}
