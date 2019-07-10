using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrendCheckerdService.Code.DataAccess.Database;
using TrendCheckerdService.Code.DataAccess.DTOs;

namespace TrendCheckerdService.Code.DataAccess.Repositories
{
    public class CensusRepository
    {
        public List<CensusDto> GetCensusInfo(IEnumerable<int> CensusIds)
        {
            var returnValues = new List<CensusDto>();

            using (var db = new HotelReportEntities())
            {
                var results = db.Census.Where(x => CensusIds.Contains(x.CensusID));

                foreach (var result in results)
                {
                    returnValues.Add(ConvertCensusToDTO(result));
                }
            }

            return returnValues;
        }

        private CensusDto ConvertCensusToDTO(Censu result)
        {
            return new CensusDto()
            {
                PropertyName = result.PropertyName,
                CensusId = result.CensusID,
                Country = result.CountryName,
                CountryCode = result.CountryCode,
                Market = result.MarketName,
                MarketCode = int.Parse(result.MarketCode),
                TotalRoomCount = result.TotalRooms ?? 0,
                Brand = result.ChainName,
                ManagementCompany = result.MgmtCoName,
                OwnerCompany = result.OwnerName,
                ParentCompany = result.ParentCoName
            };
        }
    }
}