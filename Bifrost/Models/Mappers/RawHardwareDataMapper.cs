using System.Collections.Generic;
using Bifrost.External.Requests;
using Bifrost.Models.Enums;

namespace Bifrost.Models.Mappers
{
    public static class RawHardwareDataMapper
    {
        public static RawHardwareData MapRawHardwareData(WebScrapperHardwareDataRequest request)
        {
            RawHardwareData rawHardwareData = new RawHardwareData();

            rawHardwareData.Code = request.Code;
            rawHardwareData.ExperienceCode = request.ExperienceCode;
            rawHardwareData.KeywordsUsed = request.KeywordsUsed;
            rawHardwareData.YearCreated = request.YearCreated;
            rawHardwareData.MonthCreated = request.MonthCreated;
            rawHardwareData.DayCreated = request.DayCreated;
            rawHardwareData.HourCreated = request.HourCreated;
            rawHardwareData.MinuteCreated = request.MinuteCreated;
            rawHardwareData.SecondCreated = request.SecondCreated;

            rawHardwareData.IsPriority = SetPriority(request.ExperienceCode);

            rawHardwareData.Name = request.Name;
            rawHardwareData.StoreName = request.StoreName;
            rawHardwareData.StoreUrl = request.StoreUrl;
            rawHardwareData.IsMarketPlace = request.IsMarketPlace;
            rawHardwareData.HasDiscount = request.HasDiscount;
            
            var priceAndDiscount = SetPriceAndDiscount(request);
            rawHardwareData.Price = priceAndDiscount["Price"];
            rawHardwareData.Discount = priceAndDiscount["Discount"];
            rawHardwareData.TotalPrice = priceAndDiscount["TotalPrice"];
            

            rawHardwareData.IsNoInterestInstallmentsAvailable = request.IsNoInterestInstallmentsAvailable;
            
            if (!rawHardwareData.IsNoInterestInstallmentsAvailable)
            {
                rawHardwareData.MaxInstallmentsWithoutInterest = request.MaxInstallmentsWithoutInterest;
            }

            rawHardwareData.Category = (HardwareCategory) System.Enum.Parse(
                typeof(HardwareCategory),
                request.Category,
                true);
            
            rawHardwareData.Manufacturer = request.Manufacturer;
            rawHardwareData.YearReleased = request.YearReleased;
            
            return rawHardwareData;
        }

        private static bool SetPriority(string experienceCode)
        {
            return false;
        }

        private static Dictionary<string,decimal> SetPriceAndDiscount(WebScrapperHardwareDataRequest request)
        {
            decimal discount = request.HasDiscount ? request.Discount : 0;
            decimal totalPrice = CalculateTotalPrice(request);
            return new Dictionary<string, decimal>
            {
                {"Price", request.Price},
                {"Discount", discount},
                {"TotalPrice", totalPrice}
            };
        }

        private static decimal CalculateTotalPrice(WebScrapperHardwareDataRequest request)
        {
            if (request.HasDiscount)
            {
                return request.Price - request.Discount;
            }

            return request.Price;
        }
    }
}