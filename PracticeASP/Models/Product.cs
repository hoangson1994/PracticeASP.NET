using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeASP.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitslnStock { get; set; }
        public int UnitOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discountinued { get; set; }

        public Category Category { get; set; }
    }
}
