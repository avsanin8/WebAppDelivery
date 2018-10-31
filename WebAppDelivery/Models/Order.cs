using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDelivery.Models
{
    public class Order
    {
        //From
        public int OrderId { get; set; }
        public string FromNameСustomer { get; set; }        
        public string FromCompany { get; set; }
        public string FromCountry { get; set; }
        public string FromState { get; set; }
        public string FromSity { get; set; }
        public string FromAddress { get; set; }
        public string FromApartment { get; set; }
        public string FromAddress2 { get; set; }
        public string FromZIP { get; set; }
        public string FromPostalCode { get; set; }
        public string FromPhone { get; set; }
        public string FromEmail { get; set; }

        //To
        public string ToNameСustomer { get; set; }
        public string ToCompany { get; set; }
        public string ToCountry { get; set; }
        public string ToState { get; set; }
        public string ToSity { get; set; }
        public string ToAddress { get; set; }
        public string ToApartment { get; set; }
        public string ToAddress2 { get; set; }
        public string ToZIP { get; set; }
        public string ToPostalCode { get; set; }
        public string ToPhone { get; set; }
        public string ToEmail { get; set; }

        //PackageModel
        public int PackageModelId { get; set; }        
    }
}
