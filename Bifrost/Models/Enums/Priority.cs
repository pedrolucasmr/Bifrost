using System.ComponentModel;

namespace Bifrost.Models.Enums
{
    public enum Priority
    {
        [Description("veryLow")]
        VeryLow,
        
        [Description("low")]
        Low,
        
        [Description("high")]
        High,
        
        [Description("veryHigh")]
        VeryHigh,
        
        [Description("extreme")]
        Extreme
    }
}