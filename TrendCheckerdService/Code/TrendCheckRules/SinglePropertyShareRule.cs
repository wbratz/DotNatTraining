using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.DataAccess.DTOs;

namespace TrendCheckerdService.Code.TrendCheckRules
{
    public class SinglePropertyShareRule : IRule
    {
        private const int _maximumRoomsPercentage = 50;
        private string errorMessage = $"A single property has exceeded its share of total rooms({ _maximumRoomsPercentage}%)";

        public TrendCheckError ExecuteRule(List<CensusDto> censusData)
        {
            var returndata = new TrendCheckError()
            {
                ErrorDetail = errorMessage
            };

            var totalRooms = censusData.Sum(x => x.TotalRoomCount);
            var maxRoomAllotment = totalRooms * (_maximumRoomsPercentage / 100);

            foreach (var property in censusData)
            {
                if(property.TotalRoomCount > maxRoomAllotment)
                {
                    returndata.OffendingCensusIds.Add(property.CensusId);
                }
            }

            return returndata;
        }
    }
}