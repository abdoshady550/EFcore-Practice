using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESO.Entities
{
    public class GetBill
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public override string ToString()
        {
            return $"OrderId ={OrderId}, " +
                $"OrderDate= {OrderDate}\n" +
                $"ProductName= {ProductName}" +
                $"| UnitPrice = {UnitPrice:C} " +
                $"| Quantity = {Quantity} " +
                $"\n                  --------------------------" +
                $"\n                      Total = {SubTotal:C} ";
        }
    }
}
