using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDelivery.Models
{
    public class Amount
    {
        public string CurrencyName { get; set; }

        public float GetAmount { get; }
        public float SetAmount
        {
            set { value = GetAmount; }
        }
    }
}
