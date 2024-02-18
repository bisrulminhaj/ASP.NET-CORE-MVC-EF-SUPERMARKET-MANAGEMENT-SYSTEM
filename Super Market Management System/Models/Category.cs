﻿using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Super_Market_Management_System.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
