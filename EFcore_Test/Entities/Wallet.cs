using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore_Test.Entities
{
    public class Wallet
    {
        public int Id { get; set; }
        public string? Holder { get; set; }
        public decimal? Balance { get; set; }
        public override string ToString()
        {
            return $"Id = {Id} ,Holder={Holder} , Balance={Balance:C} ";
        }

    }
}
