﻿using CsvHelper.Configuration.Attributes;
using static System.Formats.Asn1.AsnWriter;
using System.Globalization;
using CsvHelper.Configuration;

namespace Blazor.Models
{
    public class EmployeeProjectHistory
    {
        [Name("EmpID")]
        public int EmpId { get; set; }

        [Name("ProjectID")]
        public int ProjectId { get; set; }

        [Name("DateFrom")]
        public DateTime DateFrom { get; set; }

        [Name("DateTo")]
        public DateTime? DateTo { get; set; }
    }
}
