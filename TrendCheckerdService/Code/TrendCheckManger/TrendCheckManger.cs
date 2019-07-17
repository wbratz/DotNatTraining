using System.Collections.Generic;
using System.Linq;
using TrendCheckerdService.Code.Contract.Request;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.DataAccess.Repositories;
using TrendCheckerdService.Code.TrendCheckRules;

namespace TrendCheckerdService.Code.TrendCheckManger
{
    public class TrendCheckManger
    {
        private List<IRule> _rulesToExecute = new List<IRule>
        {
            new InvalidMarketRule(),
            new RestrictedAreasRule(),
            new MinimumPropertiesRule(),
            new SinglePropertyShareRule()
        };

        public TrendCheckResponse CheckTrendOk(TrendCheckRequest trendCheckRequest)
        {
            var response = new TrendCheckResponse();

            //get some dat
            var censusData = new CensusRepository().GetCensusInfo(trendCheckRequest.CensusIds);

            //process that data and run rules
            foreach(var rule in _rulesToExecute)
            {
                var results = rule.ExecuteRule(censusData);
                if (results.OffendingCensusIds.Any())
                {
                    response.TrendCheckErrors.Add(results);
                }
            }

            //formulate a response data
            return response;
        }
    }
}