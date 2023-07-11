﻿using System.ComponentModel.DataAnnotations;

namespace InspetctionAPI.Models
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; } = string.Empty;
    }
}
