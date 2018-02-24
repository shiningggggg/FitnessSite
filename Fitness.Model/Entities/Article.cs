using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Model.Entities
{
    public partial class Article
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }
        [StringLength(100)]
        [Display(Name = "标题" )]
        public string Title { get; set; }
        [Display(Name = "正文" )]
        public string Content { get; set; }
        public DateTime WriteTime { get; set; }
        public string ForeignKey { get; set; }
    }
}
