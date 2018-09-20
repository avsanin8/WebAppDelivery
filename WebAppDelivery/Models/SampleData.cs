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
                        FromNameСustomer = "Vasya",
                        FromCompany = "West.LCC",
                        FromCountry = "US",
                        FromState = "TX",
                        FromSity = "Austin",
                        FromAddress = "Research Boulevard",



                        FromAddress2 = "",// todo: init DB and show
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
