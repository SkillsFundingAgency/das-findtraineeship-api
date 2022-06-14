﻿using System.Collections.Generic;
using MediatR;
using SFA.DAS.FAT.Domain.Models;

namespace SFA.DAS.FAT.Application.Vacancies.Queries.SearchTraineeshipVacancies
{
    public class SearchTraineeshipVacanciesQuery : IRequest<SearchTraineeshipVacanciesResult>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int? Ukprn { get; set; }
        public string AccountPublicHashedId { get; set; }
        public string AccountLegalEntityPublicHashedId { get ; set ; }
        public List<int> RouteIds { get ; set ; }
        public bool? NationWideOnly { get ; set ; }
        public uint? DistanceInMiles { get ; set ; }
        public uint? PostedInLastNumberOfDays { get ; set ; }
        public List<string> Categories { get ; set ; }
        public double? Lat { get ; set ; }
        public double? Lon { get ; set ; }
        public VacancySort VacancySort { get ; set ; }
    }
    
}