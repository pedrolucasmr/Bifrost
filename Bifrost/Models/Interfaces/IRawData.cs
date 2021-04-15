using System;
using System.Collections.Generic;

namespace Bifrost.Models.Interfaces
{
    public interface IRawData
    {
        string Code { get; set; }
        
        List<string> KeywordsUsed { get; set; }
        
        public int YearCreated { get; set; }
        
        public int MonthCreated { get; set; }
        
        public int DayCreated { get; set; }
        
        public int HourCreated { get; set; }
        
        public int MinuteCreated { get; set; }
        
        public int SecondCreated { get; set; }
        
        bool IsPriority { get; set; }
    }
}