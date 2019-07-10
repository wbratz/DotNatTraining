using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TrendCheckerdService.Code.Contract.Request
{
    [DataContract]
    public class TrendCheckRequest
    {
        [DataMember(IsRequired = true)]
        public List<int> CensusIds { get; set; }
    }
}