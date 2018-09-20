using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDelivery.Models
{
    //CarrierService - это любые услуги, которые перевозчик предлагает для своего адреса, и адреса, такие как «Ночлег», «2-й день», «3 дня»).
    public class CarrierService
    {
        //from address and to address like Overnight, 2nd Day Air, 3 day ground, etc
        public CarrierService(string addressFrom, string addressTo)
        {
            FromTo(addressFrom, addressTo);
        }

        private string _addressFrom;
        private string _addressTo;

        public string AddressFrom { get { return _addressFrom; } }
        public string AddressTo { get { return _addressTo; } }
        public bool IsOvernight { get; set; }
        public bool IsTwoDayAir { get; set;}
        public bool IsThreeDayGround { get; set; }
        public bool IsEtc { get; set; }

        private void FromTo(string addressFrom, string addressTo)
        {
            _addressFrom = addressFrom;
            _addressTo = addressTo;
        }
        
    }
}
