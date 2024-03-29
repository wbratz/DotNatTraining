//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrendCheckerdService.Code.DataAccess.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Censu
    {
        public int CensusID { get; set; }
        public string PropertyName { get; set; }
        public string DisplayName { get; set; }
        public string SpecialName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> StateID { get; set; }
        public string StateName { get; set; }
        public string StateCode { get; set; }
        public string StateCodeFP { get; set; }
        public string Zip { get; set; }
        public string ZIP5 { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string ISOCountryCode { get; set; }
        public string OpenDate { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string PhoneCountryPrefix { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string FaxExtension { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string MailingAddress1 { get; set; }
        public string MailingAddress2 { get; set; }
        public string MailingCity { get; set; }
        public string MailingState { get; set; }
        public string MailingPostalCode { get; set; }
        public string MailingCountry { get; set; }
        public string MailingCountryCode { get; set; }
        public Nullable<int> MSAID { get; set; }
        public string MSAName { get; set; }
        public Nullable<int> MSACode { get; set; }
        public Nullable<int> TractID { get; set; }
        public string TractName { get; set; }
        public string TractCode { get; set; }
        public string TractCodeFP { get; set; }
        public Nullable<int> MarketID { get; set; }
        public string MarketName { get; set; }
        public string MarketCode { get; set; }
        public string MarketCodeFP { get; set; }
        public Nullable<int> MarketStateID { get; set; }
        public string MarketStateName { get; set; }
        public string MarketStateCode { get; set; }
        public bool Top25Market { get; set; }
        public Nullable<int> CountyID { get; set; }
        public string CountyName { get; set; }
        public string CountyCode { get; set; }
        public string CountyCodeFP { get; set; }
        public Nullable<int> RegionID { get; set; }
        public string RegionName { get; set; }
        public string RegionCode { get; set; }
        public string RegionCodeFP { get; set; }
        public Nullable<int> SubContinentID { get; set; }
        public string SubContinentName { get; set; }
        public string SubContinentCode { get; set; }
        public Nullable<int> ContinentID { get; set; }
        public string ContinentName { get; set; }
        public string ContinentCode { get; set; }
        public Nullable<int> TotalRooms { get; set; }
        public Nullable<int> GuestRooms { get; set; }
        public Nullable<int> SuiteRooms { get; set; }
        public Nullable<int> CondoRooms { get; set; }
        public Nullable<decimal> APR { get; set; }
        public Nullable<decimal> ADR { get; set; }
        public Nullable<decimal> APRLocal { get; set; }
        public Nullable<decimal> ADRLocal { get; set; }
        public Nullable<int> OperationID { get; set; }
        public string OperationName { get; set; }
        public string OperationCode { get; set; }
        public Nullable<int> SizeID { get; set; }
        public string SizeName { get; set; }
        public Nullable<int> TierID { get; set; }
        public string TierName { get; set; }
        public string TractTierCode { get; set; }
        public Nullable<int> ExtendedStayID { get; set; }
        public string ExtendedStayName { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string LocationName { get; set; }
        public string LocationCode { get; set; }
        public Nullable<int> PriceID { get; set; }
        public string PriceName { get; set; }
        public string MarketPriceCode { get; set; }
        public Nullable<int> TotalMeetingSpace { get; set; }
        public Nullable<int> LargestMeetingSpace { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string LatLongAccuracy { get; set; }
        public Nullable<int> ClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassCode { get; set; }
        public Nullable<int> TotalExtendedStayID { get; set; }
        public string TotalExtendedStayName { get; set; }
        public Nullable<int> StarRatingID { get; set; }
        public Nullable<int> StarRatingYear { get; set; }
        public Nullable<bool> HasRestaurant { get; set; }
        public Nullable<bool> IsAllSuites { get; set; }
        public Nullable<bool> IsBoutique { get; set; }
        public Nullable<bool> HasCasino { get; set; }
        public Nullable<bool> HasConference { get; set; }
        public Nullable<bool> HasConvention { get; set; }
        public Nullable<bool> HasGolf { get; set; }
        public Nullable<int> GolfHoleCount { get; set; }
        public Nullable<bool> IsResort { get; set; }
        public string ResortTypeDescription { get; set; }
        public Nullable<bool> HasSki { get; set; }
        public Nullable<bool> HasSpa { get; set; }
        public Nullable<bool> IsAllInclusive { get; set; }
        public Nullable<bool> IsTimeshare { get; set; }
        public Nullable<bool> HasWaterPark { get; set; }
        public Nullable<bool> HasCondo { get; set; }
        public Nullable<bool> IsCorporateHousing { get; set; }
        public Nullable<bool> HasBeach { get; set; }
        public Nullable<bool> HasPool { get; set; }
        public Nullable<int> PoolCount { get; set; }
        public Nullable<bool> HasBedandBreakfast { get; set; }
        public Nullable<bool> HasBusinessCenter { get; set; }
        public Nullable<bool> HasExerciseRoom { get; set; }
        public Nullable<bool> HasBarLounge { get; set; }
        public Nullable<bool> HasGiftShop { get; set; }
        public Nullable<bool> IsLEEDCertified { get; set; }
        public Nullable<bool> IsLifestyleBrand { get; set; }
        public Nullable<bool> HasMarina { get; set; }
        public Nullable<bool> HasParkingGarage { get; set; }
        public Nullable<bool> HasRetailSpace { get; set; }
        public Nullable<bool> HasShuttle { get; set; }
        public Nullable<bool> IsPermanentClosure { get; set; }
        public Nullable<bool> IsUnderRenovation { get; set; }
        public Nullable<bool> IsUnderConstruction { get; set; }
        public Nullable<bool> HasInteriorCorridors { get; set; }
        public Nullable<bool> HasExteriorCorridors { get; set; }
        public Nullable<int> FloorCount { get; set; }
        public Nullable<decimal> SingleLowRate { get; set; }
        public Nullable<decimal> SingleHighRate { get; set; }
        public Nullable<decimal> DoubleLowRate { get; set; }
        public Nullable<decimal> DoubleHighRate { get; set; }
        public Nullable<decimal> SuiteLowRate { get; set; }
        public Nullable<decimal> SuiteHighRate { get; set; }
        public Nullable<decimal> SingleRateLowLocal { get; set; }
        public Nullable<decimal> SingleRateHighLocal { get; set; }
        public Nullable<decimal> DoubleRateLowLocal { get; set; }
        public Nullable<decimal> DoubleRateHighLocal { get; set; }
        public Nullable<decimal> SuiteRateLowLocal { get; set; }
        public Nullable<decimal> SuiteRateHighLocal { get; set; }
        public Nullable<int> ChainID { get; set; }
        public string ChainName { get; set; }
        public Nullable<System.DateTime> ChainStartDate { get; set; }
        public string ChainCodeFP { get; set; }
        public string ChainExternalID { get; set; }
        public string FirstChainName { get; set; }
        public string FirstChainCode { get; set; }
        public string PreviousChainName { get; set; }
        public string PreviousChainCode { get; set; }
        public string PreviousChainExternalID { get; set; }
        public Nullable<System.DateTime> PreviousChainStartDate { get; set; }
        public string PreviousChainStartYYYYMM { get; set; }
        public string TwoPreviousChainName { get; set; }
        public string TwoPreviousChainCode { get; set; }
        public string TwoPreviousChainExternalID { get; set; }
        public Nullable<System.DateTime> TwoPreviousChainStartDate { get; set; }
        public string TwoPreviousChainStartYYYYMM { get; set; }
        public string ThreePreviousChainName { get; set; }
        public string ThreePreviousChainCode { get; set; }
        public string ThreePreviousChainExternalID { get; set; }
        public Nullable<System.DateTime> ThreePreviousChainStartDate { get; set; }
        public string ThreePreviousChainStartYYYYMM { get; set; }
        public Nullable<int> ScaleID { get; set; }
        public string ScaleName { get; set; }
        public string scalecode { get; set; }
        public Nullable<int> CollapsedScaleID { get; set; }
        public string CollapsedScaleName { get; set; }
        public Nullable<int> CollapsedClassID { get; set; }
        public string CollapsedClassName { get; set; }
        public Nullable<int> PlusScaleID { get; set; }
        public string PlusScaleName { get; set; }
        public Nullable<int> MgmtCoID { get; set; }
        public string MgmtCoCode { get; set; }
        public string MgmtCoName { get; set; }
        public Nullable<System.DateTime> MgmtCoStartDate { get; set; }
        public string MgmtCoExternalID { get; set; }
        public string MgmtCoContactName { get; set; }
        public string MgmtCoTitle { get; set; }
        public string MgmtCoAddress { get; set; }
        public string MgmtCoAddress2 { get; set; }
        public string MgmtCoCity { get; set; }
        public string MgmtCoState { get; set; }
        public string MgmtCoCountry { get; set; }
        public string MgmtCoPostalCode { get; set; }
        public string MgmtCoPhone { get; set; }
        public string MgmtCoEmail { get; set; }
        public string MgmtCoWebsite { get; set; }
        public Nullable<int> OwnerID { get; set; }
        public string OwnerCode { get; set; }
        public string OwnerName { get; set; }
        public Nullable<System.DateTime> OwnerStartDate { get; set; }
        public string OwnerExternalID { get; set; }
        public string OwnerContactName { get; set; }
        public string OwnerTitle { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerAddress2 { get; set; }
        public string OwnerCity { get; set; }
        public string OwnerState { get; set; }
        public string OwnerCountry { get; set; }
        public string OwnerPostalCode { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerEmail { get; set; }
        public string OwnerWebsite { get; set; }
        public Nullable<int> AssetMgmtCoID { get; set; }
        public string AssetMgmtCoCode { get; set; }
        public string AssetMgmtCoName { get; set; }
        public Nullable<System.DateTime> AssetMgmtCoStartDate { get; set; }
        public string AssetMgmtCoExternalID { get; set; }
        public string AssetMgmtCoContactName { get; set; }
        public string AssetMgmtCoTitle { get; set; }
        public string AssetMgmtCoAddress { get; set; }
        public string AssetMgmtCoAddress2 { get; set; }
        public string AssetMgmtCoCity { get; set; }
        public string AssetMgmtCoState { get; set; }
        public string AssetMgmtCoCountry { get; set; }
        public string AssetMgmtCoPostalCode { get; set; }
        public string AssetMgmtCoPhone { get; set; }
        public string AssetMgmtCoEmail { get; set; }
        public string AssetMgmtCoWebsite { get; set; }
        public Nullable<int> ParentCoID { get; set; }
        public string ParentCoName { get; set; }
        public string ParentCoCodeFP { get; set; }
        public string HiltonID { get; set; }
        public string HyattSpiritCode { get; set; }
        public Nullable<bool> IHGComp { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public string CurrencyISO { get; set; }
        public string CurrencyName { get; set; }
        public bool ClosedJan { get; set; }
        public bool ClosedFeb { get; set; }
        public bool ClosedMar { get; set; }
        public bool ClosedApr { get; set; }
        public bool ClosedMay { get; set; }
        public bool ClosedJun { get; set; }
        public bool ClosedJul { get; set; }
        public bool ClosedAug { get; set; }
        public bool ClosedSep { get; set; }
        public bool ClosedOct { get; set; }
        public bool ClosedNov { get; set; }
        public bool ClosedDec { get; set; }
        public bool AllowSegmentation { get; set; }
        public bool IsMonthlyStarParticipant { get; set; }
        public bool IsDailyStarParticipant { get; set; }
        public bool IsMonthlySegStarParticipant { get; set; }
        public bool IsDailySegStarParticipant { get; set; }
        public bool IsMonthlyAddRevStarParticipant { get; set; }
        public bool IsDailyAddRevStarParticipant { get; set; }
        public bool IsWeeklyStarParticipant { get; set; }
        public bool IsWeeklySegStarParticipant { get; set; }
        public Nullable<int> CurrentTotalRooms { get; set; }
        public Nullable<int> RoomsAddDropCount1 { get; set; }
        public string RoomsAddDropDate1 { get; set; }
        public string RoomsAddDropDate1YYYYMMDD { get; set; }
        public Nullable<int> RoomsAddDropCount2 { get; set; }
        public string RoomsAddDropDate2 { get; set; }
        public string RoomsAddDropDate2YYYYMMDD { get; set; }
        public Nullable<int> RoomsAddDropCount3 { get; set; }
        public string RoomsAddDropDate3 { get; set; }
        public string RoomsAddDropDate3YYYYMMDD { get; set; }
        public int ShareID { get; set; }
        public string MembershipID1 { get; set; }
        public string MembershipName1 { get; set; }
        public string MembershipID2 { get; set; }
        public string MembershipName2 { get; set; }
        public string MembershipID3 { get; set; }
        public string MembershipName3 { get; set; }
        public bool IsWeeklySTARHotelSurvey { get; set; }
        public bool IsMonthlySTARParticipationLastMonth { get; set; }
        public bool IsMonthlyHotelSurvey { get; set; }
        public bool IsMonthlySegParticipationLastMonth { get; set; }
        public Nullable<int> ChainShareID { get; set; }
        public Nullable<int> MgmtCoShareID { get; set; }
        public Nullable<int> OwnerShareID { get; set; }
        public Nullable<int> ParentCoShareID { get; set; }
        public Nullable<int> ExpediaMarketID { get; set; }
        public Nullable<bool> IsMonthlyStarParticipantWCompset { get; set; }
        public Nullable<bool> IsDailyStarParticipantWCompset { get; set; }
        public Nullable<bool> IsMonthlySegParticipantWSuffCompset { get; set; }
        public Nullable<bool> IsServicedApartments { get; set; }
        public string StarRating { get; set; }
        public Nullable<decimal> StarRatingCode { get; set; }
        public Nullable<bool> IsDailyCasinoStarParticipant { get; set; }
        public Nullable<bool> IsWeeklyCasinoStarParticipant { get; set; }
        public Nullable<bool> IsMonthlyCasinoStarParticipant { get; set; }
        public bool IsMonthlyFBStarParticipant { get; set; }
        public Nullable<int> RefAustradeSA2ID { get; set; }
        public Nullable<int> AustradeAccommodationTypeID { get; set; }
        public Nullable<bool> AustradeAccommodationOverride { get; set; }
        public Nullable<bool> AustradeSA2Override { get; set; }
    }
}
