using System;
using System.Collections.Generic;
using Bifrost.Models.Enums;

namespace Bifrost.Models.Interfaces
{
    public interface IExperience
    {
        string ExperienceCode { get; set; }
        string Name { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime? EndsAt { get; set; }
        DateTime LastUpdatedAt { get; set; }
        int Priority { get; set; }
        ExperienceStatus Status { get; set; }
        ExperienceType Type { get; set; }
        bool Closed { get; set; }
        List<string> Keywords { get; set; }
    }
}