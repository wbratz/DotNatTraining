using System.Collections.Generic;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.DataAccess.DTOs;

namespace TrendCheckerdService.Code.TrendCheckRules
{
    public abstract class RoomShareOfTotal : IRule
    {
        
        public TrendCheckError ExecuteRule(List<CensusDto> censusData)
        {
            var returnValue = new TrendCheckError
            {
                ErrorDetail = GetErrorDetailsText()
            };

            var totalRooms = AddTotalRooms(censusData);
            var comparatorCount = GetComparisonCount(censusData);

            foreach (var company in comparatorCount)
            {
                if (company.RoomCountTotal > ((double) totalRooms * GetThreshold()))
                {
                    returnValue.OffendingCensusIds.AddRange(company.CensusIds);
                }
            }

            return returnValue;
        }

        protected abstract double GetThreshold();

        protected abstract List<ComparisonData> GetComparisonCount(List<CensusDto> censusData);

        private object AddTotalRooms(List<CensusDto> censusData)
        {
            throw new System.NotImplementedException();
        }

        protected abstract string GetErrorDetailsText();
    }

    public class ComparisonData
    {
        public string CompanyName { get; set; }
        public List<int> CensusIds { get; set; }
        public int RoomCountTotal { get; set; }
    }
}