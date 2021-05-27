using System;

namespace Bifrost.Models.Interfaces
{
    public interface IRawData
    {
        string Code { get; set; }
        
        DateTime CreatedAt { get; set; }
        
        public string ExperienceCode { get; set; }
    }
}