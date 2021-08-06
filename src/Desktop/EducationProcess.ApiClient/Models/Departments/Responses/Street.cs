﻿using EducationProcess.ApiClient.Models.Departments.Responses;

namespace EducationProcess.ApiClient.Models
{
    public class Street
    {
        public int StreetId { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public City City { get; set; }
    }
}