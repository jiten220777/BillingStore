using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public class DbInitializer
    {
        public static void Initialize(BillingContext context)
        {
            if (context.Products.Any()) return;
             var products = new List<Product>
            {
                new Product
                {
                    ProductCode="P001",
                    ProductName="ABCD",
                    HSNCode="7025",
                    Category="abcd",
                    Qty=10,
                    Unit="Nos",
                    PurchaseRate=1200,
                    SaleRate=1400,
                    CGST=9,
                    SGST=9,
                    IGST=0,
                    ReorderLevel=4
                },
                 new Product
                {
                    ProductCode="P002",
                    ProductName="pqrs",
                    HSNCode="7025",
                    Category="abcd",
                    Qty=10,
                    Unit="Nos",
                    PurchaseRate=1200,
                    SaleRate=1400,
                    CGST=9,
                    SGST=9,
                    IGST=0,
                    ReorderLevel=4
                },
                 new Product
                {
                    ProductCode="P003",
                    ProductName="xyz",
                    HSNCode="7025",
                    Category="abcd",
                    Qty=10,
                    Unit="Nos",
                    PurchaseRate=1200,
                    SaleRate=1400,
                    CGST=9,
                    SGST=9,
                    IGST=0,
                    ReorderLevel=4
                },
            };
            
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }

    }
}