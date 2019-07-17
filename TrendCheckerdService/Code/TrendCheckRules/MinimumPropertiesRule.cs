using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.DataAccess.DTOs;

namespace TrendCheckerdService.Code.TrendCheckRules
{
    public class MinimumPropertiesRule : IRule
    {
        private static int _minimumProperties = 4;
        private string errorMessage = $"There are less than {_minimumProperties} properties in this set.";


        public TrendCheckError ExecuteRule(List<CensusDto> censusData)
        {
            var returnErrors = new TrendCheckError()
            {
                ErrorDetail = errorMessage
            };

            if (censusData.Count < _minimumProperties)
            {
                returnErrors.OffendingCensusIds.AddRange(censusData.Select(x => x.CensusId));
            }

            return returnErrors;
        }
    }
}