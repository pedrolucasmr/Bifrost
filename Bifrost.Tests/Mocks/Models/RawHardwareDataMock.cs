using System;
using System.Collections.Generic;
using Bifrost.Models;
using Bifrost.Models.Enums;
using PackUtils;

namespace Bifrost.Tests.Models
{
    public static class RawHardwareDataMock
    {
        public static RawHardwareData GetDefaultRawHardwareData()
        {
            return new RawHardwareData()
            {
                Code = "20211004001",
                ExperienceCode = "MDkd13012s",
                KeywordsUsed = new List<string>() {"cpu", "amd"},
                YearCreated = 2021,
                MonthCreated = 04,
                DayCreated = 10,
                HourCreated = 15,
                MinuteCreated = 04,
                SecondCreated = 59,
                IsPriority = false,
                Name = "AMD Ryzen 7 5800",
                Price = (Decimal)2800.00,
                StoreName = "Kabum",
                StoreUrl = "https://www.kabum.com.br",
                IsMarketPlace = false,
                HasDiscount = false,
                Discount = 0,
                TotalPrice = (Decimal)2800.00,
                IsNoInterestInstallmentsAvailable = false,
                MaxInstallmentsWithoutInterest = 0,
                Category = HardwareCategory.CPU,
                Manufacturer = "AMD",
                YearReleased = 2020
            };
        }
    }
}