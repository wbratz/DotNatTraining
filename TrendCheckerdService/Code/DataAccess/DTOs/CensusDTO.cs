using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrendCheckerdService.Code.DataAccess.DTOs
{
    public class CensusDto
    {
        public string PropertyName { get; set; }
        public int CensusId { get; set; }
        public string Brand { get; set; }
        public string OwnerCompany { get; set; }
        public string ManagementCompany { get; set; }
        public string Country { get; set; }
        public string Market { get; set; }
        public string ParentCompany { get; set; }
        public int TotalRoomCount { get; set; }
        public string CountryCode { get; set; }
        public string MarketCode { get; set; }
    }
}