using System;
using System.Collections.Generic;
using Bifrost.Managers;
using Bifrost.Models;
using Bifrost.Models.Enums;
using Bifrost.Repositories;
using Bifrost.Tests.Mocks;
using Bifrost.Tests.Mocks.Models;
using Xunit;

namespace Bifrost.Tests.Managers
{
    public static class PriorityManagerTests
    {
        [Fact]
        public static void A_Experience_Created_As_Very_Low_Priority_Should_Have_Priority_4()
        {
            // arrange
            ExperiencesRepository experiencesRepository = new ExperiencesRepository();
            PriorityManager priorityManager = new PriorityManager(experiencesRepository);
            Experience experience = ExperienceMock.GetDefaultExperience();
            
            // act
            experience.Priority = priorityManager.SetPriority(priorityManager.ExperiencesRepository, ExperienceType.HardwarePriceComparison, Priority.VeryLow);
            
            // assert
            Assert.Equal(4, experience.Priority);
        }
        [Fact]
        public static void A_Experience_Created_As_Low_Priority_Should_Have_Priority_3()
        {
            // arrange
            ExperiencesRepository experiencesRepository = new ExperiencesRepository();
            PriorityManager priorityManager = new PriorityManager(experiencesRepository);
            Experience experience = ExperienceMock.GetDefaultExperience();
            
            // act
            experience.Priority = priorityManager.SetPriority(priorityManager.ExperiencesRepository, ExperienceType.HardwarePriceComparison, Priority.Low);
            
            // assert
            Assert.Equal(3, experience.Priority);
        }
        [Fact]
        public static void A_Experience_Created_As_High_Priority_Should_Have_Priority_2()
        {
            // arrange
            ExperiencesRepository experiencesRepository = new ExperiencesRepository();
            PriorityManager priorityManager = new PriorityManager(experiencesRepository);
            Experience experience = ExperienceMock.GetDefaultExperience();
            
            // act
            experience.Priority = priorityManager.SetPriority(priorityManager.ExperiencesRepository, ExperienceType.HardwarePriceComparison, Priority.High);
            
            // assert
            Assert.Equal(2, experience.Priority);
        }
        [Fact]
        public static void A_Experience_Created_As_Very_High_Priority_Should_Have_Priority_1()
        {
            // arrange
            ExperiencesRepository experiencesRepository = new ExperiencesRepository();
            PriorityManager priorityManager = new PriorityManager(experiencesRepository);
            Experience experience = ExperienceMock.GetDefaultExperience();
            
            // act
            experience.Priority = priorityManager.SetPriority(priorityManager.ExperiencesRepository, ExperienceType.HardwarePriceComparison, Priority.VeryHigh);
            
            // assert
            Assert.Equal(1, experience.Priority);
        }
        [Fact]
        public static void A_Experience_Created_As_Extreme_Priority_Should_Have_Priority_0()
        {
            // arrange
            ExperiencesRepository experiencesRepository = new ExperiencesRepository();
            PriorityManager priorityManager = new PriorityManager(experiencesRepository);
            Experience experience = ExperienceMock.GetDefaultExperience();
            
            // act
            experience.Priority = priorityManager.SetPriority(priorityManager.ExperiencesRepository, ExperienceType.HardwarePriceComparison, Priority.Extreme);
            
            // assert
            Assert.Equal(0, experience.Priority);
        }
    }
}