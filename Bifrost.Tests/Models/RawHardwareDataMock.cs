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
                RequisitionCode = "MDkd13012s",
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
                Discount = null,
                TotalPrice = (Decimal)2800.00,
                IsNoInterestInstallmentsAvailable = false,
                MaxInstallmentsWithoutInterest = null,
                Category = HardwareCategory.CPU,
                Manufacturer = "AMD",
                YearReleased = 2020
            };
        }
    }
}