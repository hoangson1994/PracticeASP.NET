using PracticeASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeASP.Data
{
    public class DbInitializer
    {
        public static void Initialize(PracticeASPContext context)
        {
            // context.Database.EnsureCreated();

            // Look for any caterory.
            if (context.Category.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
            new Category{CategoryName="Laptop",Description="Laptop beautifull",Picture="imageLaptop.png"},
            new Category{CategoryName="Phone",Description="Phone beautifull",Picture="imagePhone.png"},
            };
            foreach (Category c in categories)
            {
                context.Category.Add(c);
            }
            context.SaveChanges();

            var products = new Product[]
            {
            new Product{CategoryID=1,ProductName="Lenovo",SupplierID=3, QuantityPerUnit=2, UnitPrice=2000, UnitslnStock=10, ReorderLevel=2, UnitOnOrder=5, Discountinued=false},
            new Product{CategoryID=1,ProductName="Dell",SupplierID=3, QuantityPerUnit=2, UnitPrice=5000, UnitslnStock=10, ReorderLevel=2, UnitOnOrder=5, Discountinued=false},
            new Product{CategoryID=2,ProductName="Iphone",SupplierID=3, QuantityPerUnit=2, UnitPrice=1000, UnitslnStock=10, ReorderLevel=2, UnitOnOrder=5, Discountinued=false},
            new Product{CategoryID=1,ProductName="Asus",SupplierID=3, QuantityPerUnit=2, UnitPrice=2500, UnitslnStock=10, ReorderLevel=2, UnitOnOrder=5, Discountinued=false},
            new Product{CategoryID=2,ProductName="Samsung",SupplierID=3, QuantityPerUnit=2, UnitPrice=1200, UnitslnStock=10, ReorderLevel=2, UnitOnOrder=5, Discountinued=false},
            };
            foreach (Product p in products)
            {
                context.Product.Add(p);
            }
            context.SaveChanges();          
        }
    }
}
