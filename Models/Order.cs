using System.Collections.Generic;

namespace UrunSitesiMVC.Models
{
    public class Order
    {
        public int ID { get; set; }
        public List<Product> products { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int TotalPrice { get; set; }
    }
}
