using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TrendCheckerdService.Code.Contract.Response
{
    [DataContract]
    public class TrendCheckError
    {
        [DataMember]
        public string ErrorDetail { get; set; }
        [DataMember]
        public List<int> OffendingCensusIds => new List<int>();
    }
}