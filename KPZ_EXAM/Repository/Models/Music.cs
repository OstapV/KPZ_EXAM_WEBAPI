using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace KPZ_EXAM.Repository.Models
{
    [Table("Music")]
    public partial class Music
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Path { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
