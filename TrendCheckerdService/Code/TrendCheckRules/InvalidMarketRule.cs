﻿using System.Collections.Generic;
using TrendCheckerdService.Code.Contract.Response;
using TrendCheckerdService.Code.DataAccess.DTOs;

namespace TrendCheckerdService.Code.TrendCheckRules
{
    public class InvalidMarketRule : IRule
    {
        private List<int> _badMarkets = new List<int> { 82 };
        private string errorMessage = $"These CensusIds are in an invalid market";

        public TrendCheckError ExecuteRule(List<CensusDto> censusData)
        {
            var errors = new TrendCheckError()
            {
                ErrorDetail = errorMessage
            };

            foreach (var censusProperty in censusData)
            {
                if (_badMarkets.Contains(censusProperty.MarketCode))
                {
                    errors.OffendingCensusIds.Add(censusProperty.CensusId);
                }
            }

            return errors;
        }
    }
}