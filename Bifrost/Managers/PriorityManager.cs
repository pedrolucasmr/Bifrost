using System;
using System.Collections.Generic;
using Bifrost.Managers.Interfaces;
using Bifrost.Models;
using Bifrost.Models.Enums;
using Bifrost.Models.Interfaces;
using Bifrost.Repositories.Interfaces;
using PackUtils;

namespace Bifrost.Managers
{
    public class PriorityManager: IPriorityManager
    {
        public PriorityManager(IExperiencesRepository _experiencesRepository)
        {
            this.ExperiencesRepository = _experiencesRepository;
        }
        public IExperiencesRepository ExperiencesRepository { get; set; }
        
        public int SetPriority(
            IExperiencesRepository experiencesRepository,
            ExperienceType experienceType,
            Priority? priorityOnCreation = null)
        {
            if (experienceType.GetDescriptionFromEnum().Contains("pontual"))
            {
                return 3;
            }
            
            switch (priorityOnCreation)
            {
                case Priority.VeryLow:
                    return 4;
                
                case Priority.Low:
                    return 3;
                
                case Priority.High:
                    return 2;
                
                case Priority.VeryHigh:
                    return SetPriority1(experiencesRepository);
                
                case Priority.Extreme:
                    return SetPriority0(experiencesRepository);
                
                default:
                    return 2;
            }
        }

        private int SetPriority1(IExperiencesRepository experiencesRepository)
        {
            int priority0ExperiencesCount = experiencesRepository.GetExperiencesCountByPriority(1);
            int experiencesCount = experiencesRepository.GetExperiencesCount();
            double percentageOfPriorityExperiences = CalculatePriorityPercentage(experiencesCount, priority0ExperiencesCount);

            return percentageOfPriorityExperiences >= 10 ? 2 : 1; 
        }
        
        private int SetPriority0(IExperiencesRepository experiencesRepository)
        {
            int priority0ExperiencesCount = experiencesRepository.GetExperiencesCountByPriority(0);
            int experiencesCount = experiencesRepository.GetExperiencesCount();
            double percentageOfPriorityExperiences = CalculatePriorityPercentage(experiencesCount, priority0ExperiencesCount);

            return percentageOfPriorityExperiences >= 5 ? SetPriority1(experiencesRepository) : 0; 
        }

        private double CalculatePriorityPercentage(int experiencesCount, int priorityExperiencesCount) =>
            ((priorityExperiencesCount - experiencesCount) / experiencesCount) * 100;
    }
}