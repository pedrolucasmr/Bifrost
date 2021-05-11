using System.ComponentModel;

namespace Bifrost.Models.Enums
{
    public enum PontualTimeStamps
    {
        [Description("daily")]
        Daily,
        
        [Description("twoTimesADay")]
        TwoTimesADay,
        
        [Description("weekly")]
        Weekly,
        
        [Description("monthly")]
        Monthly,
        
        [Description("bimonthly")]
        bimonthly,
        
        [Description("semiannual")]
        Semiannual,
        
        [Description("annual")]
        Annual
    }
}