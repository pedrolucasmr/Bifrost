using System;
using Bifrost.Models.Enums;

namespace Bifrost.Models.Interfaces
{
    public interface IPontualExperience: IExperience
    {
        PontualTimeStamps TimeStamps { get; set; }
        DateTime LastResearchedAt { get; set; }
    }
}