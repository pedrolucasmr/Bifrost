using System;

namespace Bifrost.Models.Interfaces
{
    public interface IRawProductData : IRawData
    {
        string Name { get; set; }
        
        Decimal Price { get; set; }
        
        string StoreName { get; set; }
        
        string StoreUrl { get; set; }
        
        bool IsMarketPlace { get; set; }
        
        bool HasDiscount { get; set; }
        
        Decimal? Discount { get; set; }
        
        Decimal TotalPrice { get; set; }
        bool IsNoInterestInstallmentsAvailable { get; set; }

        int? MaxInstallmentsWithoutInterest { get; set; }
    }
}