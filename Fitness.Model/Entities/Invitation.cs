using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Model.Entities
{
    public partial class Invitation
    {
        [Key]
        [StringLength(36)]
        public string Id { get; set; }
        [StringLength(36)]
        [Required]
        public string UserKey{ get; set; }
        [StringLength(100,ErrorMessage ="请输入一百个字以内",ErrorMessageResourceName ="长度错误",ErrorMessageResourceType = typeof(MissingFieldException) ,MinimumLength =1)]
        public string Theme { get; set; }
        public string Content { get; set; }
        public string PicUrl { get; set; }
        public DateTime PublishTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
