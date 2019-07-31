using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrendCheckerdService.Code.DataAccess.DTOs;

namespace TrendCheckerdService.Code.TrendCheckRules
{
    public class BrandCompanyShareRule : RoomShareOfTotal
    {
        protected override double GetThreshold()
        {
            return .50;
        }

        protected override List<ComparisonData> GetComparisonCount(List<CensusDto> censusData)
        {
            var returnData = new Dictionary<string, ComparisonData>();

            foreach (var property in censusData)
            {
                if (returnData.ContainsKey(property.Brand))
                {
                    returnData[property.Brand].RoomCountTotal += property.TotalRoomCount;
                    returnData[property.Brand].CensusIds.Add(property.CensusId);
                }
                else
                {
                    returnData.Add(property.Brand, new ComparisonData
                    {
                        RoomCountTotal = property.TotalRoomCount,
                        CensusIds = new List<int>
                    {
                        property.CensusId
                    },
                        CompanyName = property.Brand

                    });
                }
            }

            return returnData.Values.ToList();
        }

        protected override string GetErrorDetailsText()
        {
            return "A single brand has exceeded its share of total rooms";
        }
    }
}