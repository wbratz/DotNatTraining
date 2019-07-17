using System.Collections.Generic;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.DataAccess.DTOs;

namespace TrendCheckerdService.Code.TrendCheckRules
{
    public class RestrictedAreasRule : IRule
    {
        private readonly List<string> _restrictedAreas = new List<string>
        {
            "Finland", "Norway", "Sweden", "Lithuania", "Latvia", "Estonia", "Denmark", "Belgium",
            "Luxembourg", "France", "Germany", "Bulgaria", "Romania", "Netherlands", "Iceland",
            "Slovakia", "Czech Republic", "Cuba"
        };

        private string errorMessage = $"These CensusIds are in an AREA 51!!!";

        public TrendCheckError ExecuteRule(List<CensusDto> censusData)
        {
            var errors = new TrendCheckError()
            {
                ErrorDetail = errorMessage
            };

            foreach (var censusProperty in censusData)
            {
                if (_restrictedAreas.Contains(censusProperty.Country))
                {
                    errors.OffendingCensusIds.Add(censusProperty.CensusId);
                }
            }

            return errors;
        }
    }
}