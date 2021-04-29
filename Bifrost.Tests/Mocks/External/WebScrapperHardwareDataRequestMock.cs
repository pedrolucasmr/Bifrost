using System;
using System.Collections.Generic;
using Bifrost.External.Requests;

namespace Bifrost.Tests.Mocks.External
{
    public static class WebScrapperHardwareDataRequestMock
    {
        public static WebScrapperHardwareDataRequest GetDefaultWebScrapperHardwareDataRequestMock()
        {
            return new WebScrapperHardwareDataRequest(
                        "20211004001",
                        "scrapper01",
                        "host01",
                        new List<string>() {"cpu", "amd"},
                        2021,
                        04,
                        10,
                        15,
                        04,
                        59,
                        "MAZSOMCDE",
                        "MDkd13012s",
                        "AMD Ryzen 7 5800",
                        (Decimal)2800.00,
                        "Kabum",
                        "https://www.kabum.com.br",
                        false,
                        false,
                        0,
                        false,
                        0,
                        "CPU",
                        "AMD",
                        2020    
                );
        }
    }
}