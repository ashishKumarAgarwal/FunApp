﻿using System.ComponentModel.DataAnnotations;

namespace FunApp.Common.Models
{
    public class Video
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
        public string RelatedArea { get; set; }
    }
}