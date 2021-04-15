using System;
using System.Collections.Generic;
using Bifrost.Models;
using Bifrost.Models.Enums;
using Bifrost.Models.Mappers;
using Xunit;
using PackUtils;

namespace Bifrost.Tests.Models.Mappers
{
    public class RawHardwareDataMapperTests
    {
        //TODO - Implement more tests on this class
        [Fact]
        public void MapRawHardwareData_Should_Return_Valid_RawHardwareData_Object()
        {
            // arrange
            string code = "20211004001";
            string sender = "scrapper01";
            List<string> keywords = new List<string>() {"cpu", "amd"};
            int year = 2021;
            int month = 04;
            int day = 10;
            int hour = 15;
            int minute = 04;
            int second = 59;
            DateTime createdAt = new DateTime(2021, 04, 10, 15, 04, 59);
            bool priority = false;
            string name = "AMD Ryzen 7 5800";
            Decimal price = (Decimal)2800.00;
            string storeName = "Kabum";
            string storeUrl = "https://www.kabum.com.br";
            bool isMarketPlace = false;
            bool HasDiscount = false;
            bool IsNoInterestInstallmentsAvailable = false;
            string category = HardwareCategory.CPU.GetDescriptionFromEnum();
            string manufacturer = "AMD";
            int yearReleased = 2020;
            
            // act
            RawHardwareData resultData = RawHardwareDataMapper.MapRawHardwareData();
            
            // arrage
            Assert.Equal(resultData.code, code);

        }
    }
}