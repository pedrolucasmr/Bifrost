using System;
using System.Collections.Generic;
using Bifrost.Models.Enums;
using Bifrost.Models.Interfaces;

namespace Bifrost.Models
{
    public class RawHardwareData : IRawHardwareData
    {
        public string Code { get; set; }
        public string RequisitionCode { get; set; }
        public List<string> KeywordsUsed { get; set; }
        public int YearCreated { get; set; }
        public int MonthCreated { get; set; }
        public int DayCreated { get; set; }
        public int HourCreated { get; set; }
        public int MinuteCreated { get; set; }
        public int SecondCreated { get; set; }
        public bool IsPriority { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string StoreUrl { get; set; }
        public bool IsMarketPlace { get; set; }
        public bool HasDiscount { get; set; }
        public decimal? Discount { get; set; } = null;
        public decimal TotalPrice { get; set; }
        public bool IsNoInterestInstallmentsAvailable { get; set; }
        public int? MaxInstallmentsWithoutInterest { get; set; } = null;
        public HardwareCategory Category { get; set; }
        public string Manufacturer { get; set; }
        public int YearReleased { get; set; }
    }
}