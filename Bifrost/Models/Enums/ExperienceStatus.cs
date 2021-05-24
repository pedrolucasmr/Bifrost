using System.ComponentModel;

namespace Bifrost.Models.Enums
{
    public enum ExperienceStatus
    {
        [Description("created")]
        Created,
        
        [Description("waiting")]
        Waiting,
        
        [Description("scrapping")]
        Scrapping,
        
        [Description("researching")]
        Researching,
        
        [Description("researched")]
        Researched
    }
}