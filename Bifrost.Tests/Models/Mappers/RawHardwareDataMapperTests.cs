using System;
using System.Collections.Generic;
using Bifrost.Models;
using Bifrost.Models.Enums;
using Bifrost.External.Requests;
using Bifrost.Models.Mappers;
using Bifrost.Tests.Mocks.External;
using Xunit;
using PackUtils;

namespace Bifrost.Tests.Models.Mappers
{
    public class RawHardwareDataMapperTests
    {
        [Fact]
        public void MapRawHardwareData_Should_Return_Valid_RawHardwareData_Object()
        {
            // arrange
            WebScrapperHardwareDataRequest requestMock =
                WebScrapperHardwareDataRequestMock.GetDefaultWebScrapperHardwareDataRequestMock();
            RawHardwareData dataMock = RawHardwareDataMock.GetDefaultRawHardwareData();
            
            // act
            RawHardwareData resultData = RawHardwareDataMapper.MapRawHardwareData(requestMock);
            
            // assert
            Assert.Equal(dataMock.Code, resultData.Code);
            Assert.Equal(dataMock.ExperienceCode, resultData.ExperienceCode);
            Assert.Equal(dataMock.KeywordsUsed, resultData.KeywordsUsed);
            Assert.Equal(dataMock.YearCreated, resultData.YearCreated);
            Assert.Equal(dataMock.MonthCreated, resultData.MonthCreated);
            Assert.Equal(dataMock.DayCreated, resultData.DayCreated);
            Assert.Equal(dataMock.HourCreated, resultData.HourCreated);
            Assert.Equal(dataMock.MinuteCreated, resultData.MinuteCreated);
            Assert.Equal(dataMock.SecondCreated, resultData.SecondCreated);
            Assert.Equal(dataMock.IsPriority, resultData.IsPriority);
            Assert.Equal(dataMock.Name, resultData.Name);
            Assert.Equal(dataMock.Price, resultData.Price);
            Assert.Equal(dataMock.StoreName, resultData.StoreName);
            Assert.Equal(dataMock.StoreUrl, resultData.StoreUrl);
            Assert.Equal(dataMock.IsMarketPlace, resultData.IsMarketPlace);
            Assert.Equal(dataMock.HasDiscount, resultData.HasDiscount);
            Assert.Equal(dataMock.Discount, resultData.Discount);
            Assert.Equal(dataMock.TotalPrice, resultData.TotalPrice);
            Assert.Equal(dataMock.IsNoInterestInstallmentsAvailable, resultData.IsNoInterestInstallmentsAvailable);
            Assert.Equal(dataMock.MaxInstallmentsWithoutInterest, resultData.MaxInstallmentsWithoutInterest);
            Assert.Equal(dataMock.Category, resultData.Category);
            Assert.Equal(dataMock.Manufacturer, resultData.Manufacturer);
            Assert.Equal(dataMock.YearReleased, resultData.YearReleased);
        }

        [Fact]
        public void When_HasDiscout_Is_True_Discount_Should_Not_Be_Zero()
        {
            // arrange
            WebScrapperHardwareDataRequest requestMock =
                WebScrapperHardwareDataRequestMock.GetDefaultWebScrapperHardwareDataRequestMock();

            requestMock.HasDiscount = true;
            requestMock.Discount = (Decimal)50.00;
            // act
            RawHardwareData resultData = RawHardwareDataMapper.MapRawHardwareData(requestMock);
            
            // assert
            Assert.NotEqual(0, resultData.Discount);
        }
        
        [Fact]
        public void When_HasDiscout_Is_False_Discount_Should_Be_Zero()
        {
            // arrange
            WebScrapperHardwareDataRequest requestMock =
                WebScrapperHardwareDataRequestMock.GetDefaultWebScrapperHardwareDataRequestMock();

            requestMock.HasDiscount = false;
            requestMock.Discount = 0;
            // act
            RawHardwareData resultData = RawHardwareDataMapper.MapRawHardwareData(requestMock);
            
            // assert
            Assert.Equal(0, resultData.Discount);
        }
    }
}