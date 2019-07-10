using System;
using TrendCheckerdService.Code.Contract;
using TrendCheckerdService.Code.Contract.Request;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.TrendCheckManger;

namespace TrendCheckerdService
{
    public class TrendCheckService : ITrendCheckService
    {
        public TrendCheckResponse CheckForTrendOrderOk(TrendCheckRequest trendCheckRequest)
        {
            //try
            return new TrendCheckManger().CheckTrendOk(trendCheckRequest);
            //catch
            //return a FIXED response error.
        }
    }
}
