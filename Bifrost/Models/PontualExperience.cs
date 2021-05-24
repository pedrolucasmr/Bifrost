using System;
using System.Collections.Generic;
using Bifrost.Models.Enums;
using Bifrost.Models.Interfaces;

namespace Bifrost.Models
{
    public class PontualExperience: IPontualExperience
    {
        public string ExperienceCode { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public int Priority { get; set; }
        public ExperienceStatus Status { get; set; }
        public ExperienceType Type { get; set; }
        public bool Closed { get; set; }
        public List<string> Keywords { get; set; }
        public PontualTimeStamps TimeStamps { get; set; }
        public DateTime LastResearchedAt { get; set; }
    }
}