using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrendCheckerdService.Code.Contract.Request;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.DataAccess.Repositories;

namespace TrendCheckerdService.Code.TrendCheckManger
{
    public class TrendCheckManger
    {
        public TrendCheckResponse CheckTrendOk(TrendCheckRequest trendCheckRequest)
        {
            //get some dat
            var censusData = new CensusRepository().GetCensusInfo(trendCheckRequest.CensusIds);

            //process that data and run rules
            //formulate a response dat

            return new TrendCheckResponse();
        }
    }
}