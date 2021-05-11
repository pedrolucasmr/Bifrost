using Bifrost.Models.Interfaces;
using Bifrost.Repositories.Interfaces;

namespace Bifrost.Managers.Interfaces
{
    public interface IPriorityManager
    {
        abstract void GetPriorityExperiencesList(IPriorityExperiencesRepository priorityExperiencesRepository);
        abstract void UpdatePriorityQueue(IExperience experience);
        abstract bool UpdatePriorityExperiencesList(
            IPriorityExperiencesRepository priorityExperiencesRepository,
            IExperience experience);
        
        abstract int SetPriority(IPriorityExperiencesRepository priorityExperiencesRepository, IExperience experience);
    }
}