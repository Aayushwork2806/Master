﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YashCampus.Data
{
    [Table("devicecodes")]
    [Index(nameof(DeviceCode1), Name = "IX_DeviceCodes_DeviceCode", IsUnique = true)]
    [Index(nameof(Expiration), Name = "IX_DeviceCodes_Expiration")]
    public partial class Devicecode
    {
        [Key]
        [StringLength(200)]
        public string UserCode { get; set; }
        [Required]
        [Column("DeviceCode")]
        [StringLength(200)]
        public string DeviceCode1 { get; set; }
        [StringLength(200)]
        public string SubjectId { get; set; }
        [StringLength(100)]
        public string SessionId { get; set; }
        [Required]
        [StringLength(200)]
        public string ClientId { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [MaxLength(6)]
        public DateTime CreationTime { get; set; }
        [MaxLength(6)]
        public DateTime Expiration { get; set; }
        [Required]
        public string Data { get; set; }
    }
}
