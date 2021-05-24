namespace Bifrost.Repositories.Interfaces
{
    public interface IExperiencesRepository
    {
        abstract int GetExperiencesCount();

        abstract int GetExperiencesCountByPriority(int priority);

        abstract bool IsExperiencePontual(string experienceCode);
    }
}