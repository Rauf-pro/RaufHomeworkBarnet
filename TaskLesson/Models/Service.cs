using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskLesson.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Subtitle { get; set; }
        [MaxLength(150)]
        public string Content { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(250)]
        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        [ForeignKey("Service")]
        public int ServiceCategoryId { get; set; }
        public ServiceCategory ServiceCategory { get; set; }


    }
}
