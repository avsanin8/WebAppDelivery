using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDelivery.Models
{
    public static class SampleData
    {
        public static void Initialize(OrderContext context)
        {
            if (!context.PackageModels.Any())
            {
                context.PackageModels.AddRange(
                    new PackageModel
                    {
                        Id = 1,
                        carrierName = { Country = "US", Name = "USPS - United States Postal Service" },
                        carrierService = { IsEtc = true, IsOvernight = false, IsThreeDayGround = true, IsTwoDayAir = false },
                        PackageType = "box",
                        DimensionType = "centimeters",
                        PackLength = "180",
                        PackWidth = "125",
                        PackHeight = "80",
                        PackWeighteType = "pounds",
                        Weight = "2",
                        CurrencyType = "USD",
                        amount = { CurrencyName = "", SetAmount = 40 },
                        WhichTaxi = "car",
                        Extras = "baby",
                        PickupPlace = "office",
                        DropoffPlace = "dropoff_place",
                        Destinations = "Airport",
                        SpecialInstructions = "comments" // maxLen 500
                        
                    }
                );
                //Order
                context.Orders.Add(
                    new Order
                    {
                        OrderId = 1,

                        FromNameСustomer = "Vasya",
                        FromCompany = "West.LCC",
                        FromCountry = "US",
                        FromState = "TX",
                        FromSity = "Austin",
                        FromAddress = "Research Boulevard",
                        FromApartment = "12845",
                        FromAddress2 = "temp adress2",
                        FromZIP = "78759",
                        FromPostalCode = "78759",
                        FromPhone = "+10123456789",
                        FromEmail = "example@.gmail.com",

                        ToNameСustomer = "Andrii",
                        ToCompany = "East.LCC",
                        ToCountry = "UA",
                        ToState = "StateNone",
                        ToSity = "Kakhovka",
                        ToAddress = "To address 1",
                        ToApartment = "Number 123",
                        ToAddress2 = "To addr 2",
                        ToZIP = "74800",
                        ToPostalCode = "74800",
                        ToPhone = "+380123456789",
                        ToEmail = "example2@gmail.com",

                        //PackageModel
                        PackageModelId = 1

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
