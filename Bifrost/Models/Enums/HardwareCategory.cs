using System.ComponentModel;

namespace Bifrost.Models.Enums
{
    public enum HardwareCategory
    {
        [Description("cpu")]
        CPU,
        
        [Description("gpu")]
        GPU,
        
        [Description("ram")]
        RAM,
        
        [Description("motherboard")]
        MotherBoard,
        
        [Description("powersource")]
        PowerSource,
        
        [Description("cooler")]
        Cooler,
        
        [Description("ssd")]
        SSD,
        
        [Description("hdd")]
        HDD,
        
        [Description("case")]
        Case
    }
}