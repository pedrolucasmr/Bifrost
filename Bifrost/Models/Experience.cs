using System;
using System.Collections.Generic;
using Bifrost.Models.Enums;
using Bifrost.Models.Interfaces;

namespace Bifrost.Models
{
    public class Experience: IExperience
    {
        public string ExperienceCode { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? EndsAt { get; set; } = null;
        public DateTime LastUpdatedAt { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public ExperienceType Type { get; set; }
        public bool Closed { get; set; } = false;
        public List<string> Keywords { get; set; }
    }
}