using System.Runtime.Serialization;
using System.ServiceModel;
using TrendCheckerdService.Code.Contract.Request;
using TrendCheckerdService.Code.Contract.Response;

namespace TrendCheckerdService.Code.Contract
{
    [ServiceContract]
    public interface ITrendCheckService
    {


        [OperationContract]
        TrendCheckResponse CheckForTrendOrderOk(TrendCheckRequest trendCheckRequest);
    }
}
