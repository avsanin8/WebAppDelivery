using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Создайте API-интерфейс .Net CORE 2.1 REST, который взаимодействует с этими API-интерфейсами доставки:
Мы должны поддерживать все страны, которые поставляют следующие перевозчики:
USPS - Почтовая служба Соединенных Штатов
FedEx
UPS - United Parcel Service
DHL
Почта Австралии
Сообщение Canada

Там должен быть выставлен метод:

открытый список <ShippingOption> getShippingOptions (адрес из адреса, адрес в адрес, список <пакет>, валюта CurrencyName)

Это потребует создания этих классов:
    Вариант доставки (CarrierName, CarrierService, Amount, date GuaranteedBy) - Сумма должна быть в запрошенной валюте. 
    CarrierService - это любые услуги, которые перевозчик предлагает для своего адреса, и адреса, такие как «Ночлег», «2-й день», «3 дня» и т. Д.).

    Адрес (адресная строка 1, адресная строка 2, номер квартиры, город, штат, почтовый индекс, страна) и т. Д.

    Пакет (PackageType packageType, Length, Width, Height, DimensionType, Weight, WeightType) - 
    packageType - это конверт, сумка, коробка и т. Д., 
    DimensionType - дюймы или сантиметры, 
    WeightType - унции, фунты, граммы и т. Д.*/

namespace WebAppDelivery.Models
{
    public class PackageModel
    {
        public int Id { get; set; }
        public Amount amount;
        public Carrier carrierName;
        public CarrierService carrierService;
        public GuaranteedByDate byDate;

        //form front
        //public string ShipService { get; set; }
        public string PackageType { get; set; } // maby beter create class/iterface
        public string DimensionType { get; set; }
        public string PackLength { get; set; }
        public string PackWidth { get; set; }
        public string PackHeight { get; set; }
        public string PackWeighteType { get; set; }
        public string Weight { get; set; }
        public string CurrencyType { get; set; }
        public string WhichTaxi { get; set; }
        public string Extras { get; set; }
        public string PickupPlace { get; set; }
        public string DropoffPlace { get; set; }
        public string Destinations { get; set; }        
        public string SpecialInstructions { get; set; } // maxLen 500


    }
}
