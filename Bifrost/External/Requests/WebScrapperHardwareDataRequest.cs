using System;
using System.Collections.Generic;


namespace Bifrost.External.Requests
{
    public class WebScrapperHardwareDataRequest
    {
        public string Code { get; set; }
        public string Sender { get; set; }
        public string? Host { get; set; }
        public List<string> KeywordsUsed { get; set; }
        public int YearCreated { get; set; }
        public int MonthCreated { get; set; }
        public int DayCreated { get; set; }
        public int HourCreated { get; set; }
        public int MinuteCreated { get; set; }
        public int SecondCreated { get; set; }
        public string RequestKey { get; set; }
        public string RequisitionCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string StoreName { get; set; }
        public string StoreUrl { get; set; }
        public bool IsMarketPlace { get; set; }
        public bool HasDiscount { get; set; }
        public decimal Discount { get; set; } = 0;
        public bool IsNoInterestInstallmentsAvailable { get; set; }
        public int MaxInstallmentsWithoutInterest { get; set; } = 0;
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public int YearReleased { get; set; }

        public WebScrapperHardwareDataRequest(string code, 
                                  string sender,
                                  string host,
                                  List<string> keywords,
                                  int yearCreated,
                                  int monthCreated,
                                  int dayCreated,
                                  int hourCreated,
                                  int minuteCreated,
                                  int secondCreated,
                                  string requestKey,
                                  string requisitionCode,
                                  string name, 
                                  decimal price, 
                                  string storeName,
                                  string storeUrl,
                                  bool isMarketPlace,
                                  bool hasDiscount,
                                  decimal discount,
                                  bool isNoInterest,
                                  int maxInstallmentsWithoutInterest,
                                  string category,
                                  string manufacturer,
                                  int yearReleased)
        {
            this.Code = code;
            this.Sender = sender;
            this.Host = host;
            this.KeywordsUsed = keywords;
            this.YearCreated = yearCreated;
            this.MonthCreated = monthCreated;
            this.DayCreated = dayCreated;
            this.HourCreated = hourCreated;
            this.MinuteCreated = minuteCreated;
            this.SecondCreated = secondCreated;
            this.RequestKey = requestKey;
            this.RequisitionCode = requisitionCode;
            this.Name = name;
            this.Price = price;
            this.StoreName = storeName;
            this.StoreUrl = storeUrl;
            this.IsMarketPlace = isMarketPlace;
            this.HasDiscount = hasDiscount;
            this.Discount = discount;
            this.IsNoInterestInstallmentsAvailable = isNoInterest;
            this.MaxInstallmentsWithoutInterest = maxInstallmentsWithoutInterest;
            this.Category = category;
            this.Manufacturer = manufacturer;
            this.YearReleased = yearReleased;
        }
    }
}