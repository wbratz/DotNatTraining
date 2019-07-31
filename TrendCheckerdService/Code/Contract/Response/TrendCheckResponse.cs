
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace TrendCheckerdService.Code.Contract.Response
{
    public class TrendCheckResponse
    {
        [DataMember]
        public bool TrendCheckOk { get; set; }

        public List<TrendCheckError> TrendCheckErrors => new List<TrendCheckError>();
    }
}