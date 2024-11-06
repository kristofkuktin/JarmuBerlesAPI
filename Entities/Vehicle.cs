﻿using System.ComponentModel.DataAnnotations;

namespace JarmuBerlesAPI.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string LicensePlate { get; set; }
        [Required]
        public decimal DailyRate { get; set; }
        [Required]
        public bool Available { get; set; }
    }
}
