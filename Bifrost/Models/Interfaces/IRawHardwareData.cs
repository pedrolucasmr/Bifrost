using Bifrost.Models.Enums;

namespace Bifrost.Models.Interfaces
{
    public interface IRawHardwareData : IRawProductData
    {
        HardwareCategory Category { get; set; }
        
        string Manufacturer { get; set; }
        
        int YearReleased { get; set; }
    }
}