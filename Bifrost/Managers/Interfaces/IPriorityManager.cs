using System.Collections.Generic;
using Bifrost.Models.Enums;
using Bifrost.Models.Interfaces;
using Bifrost.Repositories.Interfaces;

namespace Bifrost.Managers.Interfaces
{
    public interface IPriorityManager
    {
        IExperiencesRepository ExperiencesRepository { get; set; }
        abstract int SetPriority(IExperiencesRepository priorityExperiencesRepository, ExperienceType experienceType, Priority? priorityOnCreation);
    }
}